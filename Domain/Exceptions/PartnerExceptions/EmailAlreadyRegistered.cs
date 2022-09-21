namespace Samauma.Domain.Errors
{
    public class EmailAlreadyRegisteredException : BaseException
    {
        public EmailAlreadyRegisteredException() : base("004", "Partner Email Already Registered") { }
    }
}
