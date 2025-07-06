using ConsultaCepAPI.Adapters.Interfaces;
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
        public Task<List<CepResponse>> BuscaEndereco(CepRequest cepResponse)
        {
            throw new NotImplementedException();
        }

        public async Task<CepResponse> BuscaEnderecoPorCep(string cep)
        {
            var response = await _viaCepService.BuscaCep(cep);
            return response;
        }
    }
}
