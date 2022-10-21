using System.Runtime.Serialization;

namespace Samauma.Domain.Errors
{
    [Serializable]
    public class InvalidPartnerIdException : BaseException
    {
        public InvalidPartnerIdException() : base("010", "Invalid Partner Id") { }

        protected InvalidPartnerIdException(SerializationInfo info, StreamingContext context) : base("010", "Invalid Partner Id") { }
    }
}
