using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ILogger<BookController> _logger;

        public BookController(IBookRepository bookRepository, ILogger<BookController> logger)
        {
            _bookRepository = bookRepository;
            _logger = logger;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            try
            {
                var getBook = _bookRepository.GetBookbyId(id);

                return Ok(getBook);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet("")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var getBooks = _bookRepository.GetAllBooks();

                return Ok(getBooks);
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpPost("")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Post(Book book)
        {
            try
            {
                _bookRepository.IncludeNewBook(book);

                return Ok(book);

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                _bookRepository.DeleteBookbyId(id);

                return Ok();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}