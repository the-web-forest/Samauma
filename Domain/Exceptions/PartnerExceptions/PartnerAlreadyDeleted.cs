namespace Samauma.Domain.Errors
{
    public class PartnerAlreadyDeletedEsception : BaseException
    {
        public PartnerAlreadyDeletedEsception() : base("004", "Partner Already Deleted") { }
    }
}
