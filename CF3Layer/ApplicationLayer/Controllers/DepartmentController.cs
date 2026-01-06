using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BLL.Services;
using BLL.DTOs;

namespace ApplicationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : Controller
    {
        DepartmentService service;

        public DepartmentController(DepartmentService service)
        {
         this.service = service;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            var data = service.All();
            return Ok(data);
        }

    }
}
