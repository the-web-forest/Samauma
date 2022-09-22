namespace Samauma.Domain.Errors
{
    public class InvalidPartnerPasswordException : BaseException
    {
        public InvalidPartnerPasswordException() : base("001", "Invalid Partner Password") { }
    }
}
