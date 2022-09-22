namespace Samauma.Domain.Errors
{
    public class InvalidPartnerEmailException : BaseException
    {
        public InvalidPartnerEmailException() : base("001", "Invalid Partner Email") { }
    }
}
