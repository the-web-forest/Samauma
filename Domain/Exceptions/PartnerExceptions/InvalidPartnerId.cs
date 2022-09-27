namespace Samauma.Domain.Errors
{
    public class InvalidPartnerIdException : BaseException
    {
        public InvalidPartnerIdException() : base("010", "Invalid Parter Id") { }
    }
}
