using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarApi.Models;
using NetCoreTestInnovar.Models;

namespace NetCoreTestInnovar.DataService
{
    public class StudentDataService
    {
        private Context _context;
        public StudentDataService(Context context){
            _context = context;
        }

        public List<Student> GetStudents(){
            return _context.Students.ToList();
        }
        public Student CreteStudent(Student student){
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }
    }
}