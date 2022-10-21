using System.Runtime.Serialization;

namespace Samauma.Domain.Errors
{
    [Serializable]
    public class InvalidPartnerPasswordException : BaseException
    {
        public InvalidPartnerPasswordException() : base("009", "Invalid Partner Password") { }

        protected InvalidPartnerPasswordException(SerializationInfo info, StreamingContext context) : base("009", "Invalid Partner Password") { }
    }
}
