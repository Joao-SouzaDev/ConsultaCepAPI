namespace ConsultaCepAPI.Responses
{
    public class ViaCepResponse
    {
        public string cep { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }
        public string localidade { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
    }
}
