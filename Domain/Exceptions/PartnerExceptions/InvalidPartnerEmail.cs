namespace Samauma.Domain.Errors
{
    public class InvalidPartnerEmailException : BaseException
    {
        public InvalidPartnerEmailException() : base("005", "Invalid Partner Email") { }
    }
}
