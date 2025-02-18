using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TestHsAPI.Models
{
    public class Hs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        [BsonElement("somondangki")]
        public int Somondangki { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("ngayDangKi")]
        public DateTime NgayDangKi { get; set; }
    }
}
