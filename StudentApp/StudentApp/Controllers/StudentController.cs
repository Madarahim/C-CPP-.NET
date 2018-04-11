
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentApp.Controllers
{
    public class StudentController : ApiController
    {
        public static StudentEntities dbcontext = new StudentEntities();

        List<Student> students = new List<Student>();
        /*{
            new Student { Id = 1, Name = "Tomato Soup"},
            new Student { Id = 2, Name = "Yo Yo" },
            new Student { Id = 3, Name = "Hammer Head" }
        };*/

        public IEnumerable<Student> GetAllStudents()
        {
            students=dbcontext.Students.ToList();
            return students;
        }
        public IHttpActionResult PostNewStudent(Student student)
        {
            dbcontext.Students.Add(student);
            dbcontext.SaveChanges();
           
            
            return Ok();
        }
        public IHttpActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault((p) => p.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

    }
}
