namespace MongoDbPOC.Models
{
	public interface IStudentDatabaseSettings
	{
		string StudentCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}
