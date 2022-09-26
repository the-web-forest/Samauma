namespace Samauma.UseCases.PartnersUseCases.GetPartnerById
{
    public class GetPartnerByIdUseCaseOutput
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tree { get; set; }
        public string Url { get; set; }
        public bool Deleted { get; set; }
    }
}
