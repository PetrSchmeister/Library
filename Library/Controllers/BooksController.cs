using Library.Services.Contracts.DTOs;
using Library.Services.Contracts.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        public BooksController(IBooksService booksService)
        {
            this._booksService = booksService;
        }

        // GET: api/books
        [HttpGet]
        public async Task<IEnumerable<BookDto>> GetBooks()
        {
            return await this._booksService.GetBooks();
        }

        // GET: api/books/5        
        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetBook(int id)
        {
            var book = await this._booksService.GetBook(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        // POST: api/books
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.        
        [HttpPost]
        public async Task<ActionResult<BookDto>> PostBook(BookDto request)
        {
            var book = await this._booksService.CreateBook(request);       

            return CreatedAtAction("PostBook", new { id = book.Id }, book);
        }

        // PUT: api/books/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id, BookDto book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            var updatedBook = await this._booksService.UpdateBook(id, book);

            if (updatedBook == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
