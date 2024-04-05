using Microsoft.AspNetCore.Mvc;
using WriterAPI.Models;
using WriterAPI.Repos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WriterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private readonly IWriterRepo _writerRepo;

        // GET: api/<WritersController>
        public WritersController(IWriterRepo writerRepo)
        {
            _writerRepo = writerRepo;    
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_writerRepo.GetAll());    
        }

        // GET api/<WritersController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var writer= _writerRepo.Get(id);
            if(writer == null)
                return NotFound();
            return Ok(writer);
        }

        // POST api/<WritersController>
        [HttpPost]
        public IActionResult Post([FromBody] Writer writer)
        {
            var result= _writerRepo.Post(writer);
            return Created($"/get/{result.Id}", result);
        }
       

       
    }
}
