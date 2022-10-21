using System.Runtime.Serialization;

namespace Samauma.Domain.Errors
{
    [Serializable]
    public class InvalidTreeObjectIdException : BaseException
    {
        public InvalidTreeObjectIdException() : base("007", "Invalid Tree Object Id") { }

        protected InvalidTreeObjectIdException(SerializationInfo info, StreamingContext context) : base("007", "Invalid Tree Object Id") { }
    }
}
