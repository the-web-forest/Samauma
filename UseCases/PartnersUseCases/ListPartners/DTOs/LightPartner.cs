namespace Samauma.UseCases.PartnersUseCases.ListPartners.DTOs
{
    public class LightPartner
    {
        public LightPartner(string id, string name, int code, string email, string url)
        {
            Id = id;
            Name = name;
            Code = code;
            Email = email;
            Url = url;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
    }
}
