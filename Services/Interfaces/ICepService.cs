using ConsultaCepAPI.Request;
using ConsultaCepAPI.Responses;

namespace ConsultaCepAPI.Services.Interfaces
{
    public interface ICepService
    {
        Task<CepResponse> BuscaEnderecoPorCep(string cep);
        Task<List<CepResponse>> BuscaEndereco(string estado,string cidade,string logradouro);
    }
}
