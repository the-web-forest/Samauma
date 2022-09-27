namespace Samauma.Domain.Errors
{
    public class InvalidPartnerEmailException : BaseException
    {
        public InvalidPartnerEmailException() : base("011", "Invalid Partner Email") { }
    }
}
