namespace Samauma.Domain.Errors
{
    public class InvalidPartnerPasswordException : BaseException
    {
        public InvalidPartnerPasswordException() : base("009", "Invalid Partner Password") { }
    }
}
