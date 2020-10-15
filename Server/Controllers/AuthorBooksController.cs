using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Library.Server;
using Library.Shared.Models;

namespace Library.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorBooksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorBooksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AuthorBooks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuthorBook>>> GetAuthorBooks()
        {
            return await _context.AuthorBooks.ToListAsync();
        }

        // GET: api/AuthorBooks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorBook>> GetAuthorBook(int id)
        {
            var authorBook = await _context.AuthorBooks.FindAsync(id);

            if (authorBook == null)
            {
                return NotFound();
            }

            return authorBook;
        }

        // PUT: api/AuthorBooks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuthorBook(int id, AuthorBook authorBook)
        {
            if (id != authorBook.Id)
            {
                return BadRequest();
            }

            _context.Entry(authorBook).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorBookExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AuthorBooks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AuthorBook>> PostAuthorBook(AuthorBook authorBook)
        {
            _context.AuthorBooks.Add(authorBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuthorBook", new { id = authorBook.Id }, authorBook);
        }

        // DELETE: api/AuthorBooks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AuthorBook>> DeleteAuthorBook(int id)
        {
            var authorBook = await _context.AuthorBooks.FindAsync(id);
            if (authorBook == null)
            {
                return NotFound();
            }

            _context.AuthorBooks.Remove(authorBook);
            await _context.SaveChangesAsync();

            return authorBook;
        }

        private bool AuthorBookExists(int id)
        {
            return _context.AuthorBooks.Any(e => e.Id == id);
        }
    }
}
