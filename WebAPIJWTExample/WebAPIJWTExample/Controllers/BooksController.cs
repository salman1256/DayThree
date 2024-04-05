using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIJWTExample.Model;

namespace WebAPIJWTExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book() {Id=1, Title="Wings of Fire",Author="A.P.J. Kalam",Price=450},
            new Book() {Id=2,Title="Midnight Children ", Author="Arundhati Roy",Price=550 },
            new Book() {Id=3,Title="Discovery of India",Author="Pt. Nehru",Price=345}
        };
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(books);
        }
        }
    }

