namespace Samauma.Controllers.Partner.DTOs
{
    public class UpdatePartnerInput
    {
        public string Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Tree { get; set; }
        public string? Url { get; set; }
    }
}
