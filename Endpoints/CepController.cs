using ConsultaCepAPI.Exceptions;
using ConsultaCepAPI.Services.Interfaces;

namespace ConsultaCepAPI.Endpoints
{
    public static class CepController
    {
        public static void MapCepEndpoints(this WebApplication app)
        {
            app.MapGet("/cep/{cep}", async (string cep, ICepService cepService) =>
            {
                try
                {
                    var resultadoPesquisa = await cepService.BuscaEnderecoPorCep(cep);
                    return Results.Ok(resultadoPesquisa);
                }catch(RequestExceptions ex)
                {
                    return Results.BadRequest(ex.Message);
                }catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            });
            app.MapGet("/cep", async (string estado, string cidade, string logradouro, ICepService cepService) =>
            {
                try
                {
                    var resultadoPesquisa = await cepService.BuscaEndereco(estado, cidade, logradouro);
                    return Results.Ok(resultadoPesquisa);
                }catch(RequestExceptions ex)
                {
                    return Results.BadRequest(ex.Message);
                }catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            });
        }
    }
}
