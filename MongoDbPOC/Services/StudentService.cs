using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDbPOC.Models;

namespace MongoDbPOC.Services
{
	public class StudentService
	{
		private readonly IMongoCollection<Student> _students;

		public StudentService(IStudentDatabaseSettings settings)
		{
			var client = new MongoClient(settings.ConnectionString);
			var database = client.GetDatabase(settings.DatabaseName);

			_students = database.GetCollection<Student>(settings.StudentCollectionName);
		}
		public List<Student> Get() =>
			_students.Find(student => true).ToList();
		public Student Get(string id) =>
			_students.Find<Student>(student => student.Id == id).FirstOrDefault();
		public Student Create(Student studentInput)
		{
			_students.InsertOne(studentInput);
			return studentInput;
		}
		public void Update(Student studentInput) =>
			_students.ReplaceOne(student => student.Id == studentInput.Id, studentInput);
		public void Remove(Student studentInput) =>
			_students.DeleteOne(student => student.Id == studentInput.Id);
		public void Remove(string id) =>
			_students.DeleteOne(student => student.Id == id);
	}
}
