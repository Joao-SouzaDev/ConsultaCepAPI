using ConsultaCepAPI.Adapters.Interfaces;
using ConsultaCepAPI.Exceptions;
using ConsultaCepAPI.Request;
using ConsultaCepAPI.Responses;
using ConsultaCepAPI.Services.Interfaces;

namespace ConsultaCepAPI.Services
{
    public class CepService : ICepService
    {
        private readonly IViaCepService _viaCepService;
        public CepService(IViaCepService viaCepService)
        {
            _viaCepService = viaCepService;
        }
        public Task<List<CepResponse>> BuscaEndereco(string estado, string cidade, string logradouro)
        {
            var responses = _viaCepService.BuscaCepPorEstadoCidadeLogradouro(estado, cidade, logradouro);
            if (responses == null || !responses.Result.Any())
            {
                throw new RequestExceptions("Não foi encontrado nenhum endereço");
            }
            try
            {
                return responses;
            }
            catch (Exception ex)
            {
                throw new RequestExceptions(ex.Message, ex);
            }
        }

        public async Task<CepResponse> BuscaEnderecoPorCep(string cep)
        {
            var response = await _viaCepService.BuscaCep(cep);
            if (response == null)
            {
                throw new RequestExceptions("Não foi encontrado nenhum endereço para o CEP informado");
            }
            return response;
        }
    }
}
