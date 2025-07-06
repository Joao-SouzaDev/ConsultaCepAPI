using ConsultaCepAPI.Responses;

namespace ConsultaCepAPI.Adapters.Interfaces
{
    public interface IViaCepService
    {
        Task<CepResponse> BuscaCep(string cep);
        Task<List<CepResponse>> BuscaCepPorEstadoCidadeLogradouro(string estado, string cidade,string logradouro);
    }
}
