using ArticlesAPI.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticlesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepo _articleRepo;

        // GET: api/<WritersController>
        public ArticlesController(IArticleRepo articleRepo)
        {
            _articleRepo = articleRepo;   
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_articleRepo.GetAll());    
        }

        // GET api/<WritersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _articleRepo.GetById(id);
            if (article == null)
                return NotFound();
            return Ok(article);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var delArticle = _articleRepo.Delete(id);
            if (delArticle == 0)
                return NotFound();
            return NoContent();
        }

    }
}
