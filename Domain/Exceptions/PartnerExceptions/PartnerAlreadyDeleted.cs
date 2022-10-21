using System.Runtime.Serialization;

namespace Samauma.Domain.Errors
{
    [Serializable]
    public class PartnerAlreadyDeletedException : BaseException
    {
        public PartnerAlreadyDeletedException() : base("006", "Partner Already Deleted") { }

        protected PartnerAlreadyDeletedException(SerializationInfo info, StreamingContext context) : base("006", "Partner Already Deleted") { }
    }
}
