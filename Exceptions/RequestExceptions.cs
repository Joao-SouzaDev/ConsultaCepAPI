namespace ConsultaCepAPI.Exceptions
{
    public class RequestExceptions : Exception
    {
        public RequestExceptions() { }
        public RequestExceptions(string mensagem) :base(mensagem)
        {

        }
        public RequestExceptions(string mensagem, Exception inner) : base(mensagem, inner)
        {

        }
    }
}
