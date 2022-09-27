namespace Samauma.Domain.Errors
{
    public class PartnerAlreadyDeletedException : BaseException
    {
        public PartnerAlreadyDeletedException() : base("006", "Partner Already Deleted") { }
    }
}
