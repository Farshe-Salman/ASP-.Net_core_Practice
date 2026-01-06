using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.DTOs;
using BLL.Services;

namespace APIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryService Service;
        public CategoryController(CategoryService service)
        {
            Service = service;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            var data = Service.Get();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = Service.Get(id);
            return Ok(data);
        }

        [HttpPost("create")]
        public IActionResult Create(CategoryDTO category)
        {
            var res = Service.Create(category);
            if (res) return Ok(new { Msg = "Category Created" });
            return BadRequest(new { Msg = "Category Creation Failed" });
        }

        [HttpPost("Update")]
        public IActionResult Update(CategoryDTO category)
        {
            var res = Service.Update(category);
            if (res) return Ok(new { Msg = "Category Updated" });
            return BadRequest(new { Msg = "Category Updation Failed" });
        }

        [HttpDelete("delete/{id}")]

        public IActionResult Delete(int id) {
            var res = Service.Delete(id);
            if (res) return Ok(new { Msg = "Category Deleted" });
            return BadRequest(new { Msg = "Category Deletion Failed" });

        }
    }
}
