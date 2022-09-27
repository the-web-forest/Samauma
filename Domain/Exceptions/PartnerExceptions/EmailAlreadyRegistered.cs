namespace Samauma.Domain.Errors
{
    [Serializable]
    public class EmailAlreadyRegisteredException : BaseException
    {
        public EmailAlreadyRegisteredException() : base("012", "Partner Email Already Registered") { }

        protected EmailAlreadyRegisteredException(string Code, string Message) : base(Code, Message) { }
    }
}
