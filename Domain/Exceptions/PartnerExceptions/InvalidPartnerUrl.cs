namespace Samauma.Domain.Errors
{
    public class InvalidPartnerUrlException : BaseException
    {
        public InvalidPartnerUrlException() : base("008", "Invalid Partner Url") { }
    }
}
