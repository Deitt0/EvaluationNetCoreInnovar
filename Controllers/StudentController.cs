using Microsoft.AspNetCore.Mvc;
using NetCoreTestInnovar.BusinessService;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController
    {
        private StudentBusinessService _studentBusinessService;

        public StudentController(StudentBusinessService studentBusinessService){
            _studentBusinessService = studentBusinessService;
        }

        [HttpGet("[action]")]
        public List<Student> GetStudents(){
            return _studentBusinessService.GetStudents();
        }
        
        [HttpPost("[action]")]
        public Student CreateStudent(Student student){
            return _studentBusinessService.CreateStudent(student);
        }
    }
}