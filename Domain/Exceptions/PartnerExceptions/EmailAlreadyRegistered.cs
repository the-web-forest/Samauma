namespace Samauma.Domain.Errors
{
    public class EmailAlreadyRegisteredException : BaseException
    {
        public EmailAlreadyRegisteredException() : base("012", "Partner Email Already Registered") { }
    }
}
