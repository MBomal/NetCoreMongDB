using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbPOC.Models
{
	public class Student
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string Id { get; set; }

		[BsonElement("Firstname")]
		public string Firstname { get; set; }

		[BsonElement("Lastname")]
		public string Lastname { get; set; }

		public string Formation { get; set; }

	}
}
