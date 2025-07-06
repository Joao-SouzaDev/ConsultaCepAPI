using ConsultaCepAPI.Responses;

namespace ConsultaCepAPI.Adapters.Interfaces
{
    public interface IViaCepService
    {
        Task<CepResponse> BuscaCep(string cep);
    }
}
