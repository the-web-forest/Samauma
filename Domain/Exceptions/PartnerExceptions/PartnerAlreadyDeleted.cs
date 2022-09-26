namespace Samauma.Domain.Errors
{
    public class PartnerAlreadyDeletedException : BaseException
    {
        public PartnerAlreadyDeletedException() : base("004", "Partner Already Deleted") { }
    }
}
