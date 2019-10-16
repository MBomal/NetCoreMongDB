namespace MongoDbPOC.Models
{
	public class StudentDatabaseSettings : IStudentDatabaseSettings
		{
			public string StudentCollectionName { get; set; }
			public string ConnectionString { get; set; }
			public string DatabaseName { get; set; }
		}
}
