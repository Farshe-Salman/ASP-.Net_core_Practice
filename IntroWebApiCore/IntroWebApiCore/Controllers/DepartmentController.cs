using IntroWebApiCore.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroWebApiCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        [HttpPost("all")]
        public IActionResult All()
        {
            var d1 = new Department()
            {
                Id = 1,
                Name = "Phy"
            };

            var d2 = new Department()
            {
                Id = 2,
                Name = "Che"
            };
             
            var list = new List<Department>() { d1, d2 };
            return Ok(list);
        }



    }
}
