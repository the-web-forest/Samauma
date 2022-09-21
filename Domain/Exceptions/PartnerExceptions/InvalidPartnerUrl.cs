namespace Samauma.Domain.Errors
{
    public class InvalidPartnerUrlException : BaseException
    {
        public InvalidPartnerUrlException() : base("005", "Invalid Partner Url") { }
    }
}
