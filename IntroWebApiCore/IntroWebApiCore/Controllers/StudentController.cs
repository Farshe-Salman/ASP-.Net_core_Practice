using IntroWebApiCore.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var s1 = new Student()
            {
                Id = 1,
                FirstName = "John",
                LastName= "Doe",
                DateOfBirth = new DateTime(2000, 1, 1)
            };

            var s2 = new Student()
            {
                Id = 2,
                FirstName = "Jane",
                LastName= "Smith",
                DateOfBirth = new DateTime(1999, 5, 15)
            };

            var list = new List<Student>() { s1, s2 };
            return Ok(list);
        }

        [HttpPost]
        public IActionResult post(Student s)
        {
            return Ok("Hello");
        }
    }
}
