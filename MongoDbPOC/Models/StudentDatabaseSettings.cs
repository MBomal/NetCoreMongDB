using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPOC.Models
{
	public class StudentDatabaseSettings : IStudentDatabaseSettings
		{
			public string StudentCollectionName { get; set; }
			public string ConnectionString { get; set; }
			public string DatabaseName { get; set; }
		}
}
