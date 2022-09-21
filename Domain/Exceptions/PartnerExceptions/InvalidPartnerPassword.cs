namespace Samauma.Domain.Errors
{
    public class InvalidPartnerPasswordException : BaseException
    {
        public InvalidPartnerPasswordException() : base("005", "Invalid Partner Password") { }
    }
}
