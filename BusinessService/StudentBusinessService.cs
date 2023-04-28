using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreTestInnovar.DataService;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.BusinessService
{
    public class StudentBusinessService
    {
        private StudentDataService _studentDataService;

        public StudentBusinessService(StudentDataService studentDataService){
            _studentDataService = studentDataService;
        }

        public List<Student> GetStudents(){
            return _studentDataService.GetStudents();
        }

        public Student CreateStudent(Student student){
            return _studentDataService.CreteStudent(student);
        }
    }
}