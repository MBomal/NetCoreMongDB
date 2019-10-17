using MongoDbPOC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPOC.Services
{
    public interface IStudentService
    {
        public List<Student> Get();
        public Student Get(string id);
        public Student Create(Student studentInput);
        public void Update(Student studentInput);
        public void Remove(string id);
    }
}
