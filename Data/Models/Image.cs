using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace oldCapitalWeb.Data.Models
{
    public class Image
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Path { get; set; } = null!;
    }
}
