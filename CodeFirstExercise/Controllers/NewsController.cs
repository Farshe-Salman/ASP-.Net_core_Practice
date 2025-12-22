using CodeFirstExercise.EF;
using CodeFirstExercise.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstExercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        readonly NEWSContext db;

        public NewsController(NEWSContext db)
        {
            this.db = db;
        }

        [HttpGet("all")]
        public IActionResult All()
        {
            var data = db.News.ToList();
            return Ok(data);
        }


        [HttpPost("create")]
        public IActionResult Create(News N)
        {
            db.News.Add(N);
            db.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var news = db.News.Find(id);
            if (news == null)
                return NotFound();

            db.News.Remove(news);
            db.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.News.Find(id);
            return Ok(data);
        }

    }


}
