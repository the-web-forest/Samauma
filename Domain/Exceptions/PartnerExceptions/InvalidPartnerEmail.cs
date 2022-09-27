using System.Runtime.Serialization;

namespace Samauma.Domain.Errors
{
    [Serializable]
    public class InvalidPartnerEmailException : BaseException
    {
        public InvalidPartnerEmailException() : base("011", "Invalid Partner Email") { }

        protected InvalidPartnerEmailException(SerializationInfo info, StreamingContext context) : base("011", "Invalid Partner Email") { }
    }
}
