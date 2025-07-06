using ConsultaCepAPI.Adapters.Interfaces;
using ConsultaCepAPI.Exceptions;
using ConsultaCepAPI.Responses;

namespace ConsultaCepAPI.Adapters
{
    public class ViaCepService : IViaCepService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ViaCepService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<CepResponse> BuscaCep(string cep)
        {
            var httpClient = _httpClientFactory.CreateClient("ViaCep");
            var response = await httpClient.GetAsync($"{cep}/json");
            if(response.IsSuccessStatusCode)
            {
                var viaCepResponse = await response.Content.ReadFromJsonAsync<ViaCepResponse>();
                try
                {
                    var cepResponse = CepResponse.ToCeResponse(viaCepResponse.cep, viaCepResponse.uf, viaCepResponse.estado, viaCepResponse.localidade, viaCepResponse.bairro, viaCepResponse.logradouro, viaCepResponse.complemento);
                    return cepResponse;
                }catch(Exception ex)
                {
                    throw new RequestExceptions(ex.Message,ex);
                }
            }
            else
            {
                var erro = await response.Content.ReadAsStringAsync();
                throw new RequestExceptions(erro);
            }
        }

        public async Task<List<CepResponse>> BuscaCepPorEstadoCidadeLogradouro(string estado, string cidade, string logradouro)
        {
            var httpCliente = _httpClientFactory.CreateClient("ViaCep");
            var response = await httpCliente.GetAsync($"{estado}/{cidade}/{logradouro}/json");
            if(response.IsSuccessStatusCode)
            {
                var viaCepResponse = await response.Content.ReadFromJsonAsync<List<ViaCepResponse>>();
                try
                {
                    if (viaCepResponse == null || !viaCepResponse.Any())
                    {
                        return new List<CepResponse>();
                    }
                    var cepResponses = viaCepResponse.Select(viaCep => 
                        CepResponse.ToCeResponse(viaCep.cep, viaCep.uf, viaCep.estado, viaCep.localidade, viaCep.bairro, viaCep.logradouro, viaCep.complemento)).ToList();
                    return cepResponses;
                }catch(Exception ex)
                {
                    throw new RequestExceptions(ex.Message,ex);
                }
            }
            else
            {
                var erro = await response.Content.ReadAsStringAsync();
                throw new RequestExceptions(erro);
            }
        }
    }
}
