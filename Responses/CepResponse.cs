namespace ConsultaCepAPI.Responses
{
    public class CepResponse
    {
        public string Cep {  get; set; }
        public string UF { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public CepResponse(string cep, string uF, string estado, string cidade, string bairro, string logradouro, string complemento)
        {
            Cep = cep;
            UF = uF;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Logradouro = logradouro;
            Complemento = complemento;
        }

        public static CepResponse ToCeResponse(string cep,string uF,string estado, string cidade, string bairro,string logradouro,string complemento)
        {
            return new CepResponse(cep,uF, estado, cidade, bairro, logradouro, complemento);
        }
    }
}
