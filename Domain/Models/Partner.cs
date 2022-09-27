using MongoDB.Bson.Serialization.Attributes;

namespace Samauma.Domain.Models
{
    [BsonIgnoreExtraElements]
    public class Partner : Model
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("code")]
        public int Code { get; set; }
        [BsonElement("password")]
        public string Password { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("tree")]
        public string Tree { get; set; }
        [BsonElement("url")]
        public string Url { get; set; }
        [BsonElement("deleted")]
        public bool Deleted { get; set; }
    }
}
