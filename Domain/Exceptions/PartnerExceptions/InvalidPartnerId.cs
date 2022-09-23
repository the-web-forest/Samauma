namespace Samauma.Domain.Errors
{
    public class InvalidPartnerIdException : BaseException
    {
        public InvalidPartnerIdException() : base("005", "Invalid Parter Id") { }
    }
}
