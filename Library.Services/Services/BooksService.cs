using Library.Core.Domains;
using Library.Infrastructure;
using Library.Services.Contracts.DTOs;
using Library.Services.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Services
{
    public class BooksService : IBooksService
    {
        private readonly LibraryDBContext _context;

        public BooksService(LibraryDBContext context)
        {
            this._context = context;
        }

        public async Task<BookDto> CreateBook(BookDto dto)
        {
            var book = new Book
            {
                Title = dto.Title,
                Description = dto.Description,
                PublishedDate = dto.PublishedDate,
                Authors = dto.Authors
            };

            await _context.Books.AddAsync(book);

            await _context.SaveChangesAsync();

            return this.MapToDTO(book);
        }

        public async Task<BookDto> GetBook(int bookId)
        {
            var book = await _context.Books
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == bookId);

            if (book == null)
            {
                return null;
            }

            return this.MapToDTO(book);
        }

        public async Task<IEnumerable<BookDto>> GetBooks()
        {
            var books = await _context.Books
              .AsNoTracking()
              .ToListAsync();

            return books.Select(book => this.MapToDTO(book));
        }

        public async Task<BookDto> UpdateBook(int bookId, BookDto bookDto)
        {
            var book = await _context.Books             
               .FirstOrDefaultAsync(c => c.Id == bookId);

            if (book == null)
            {
                throw new ArgumentOutOfRangeException($"Book with id={bookId} doesn't exist");
            }

            var changes = this.GetChanges(book, bookDto);

            changes.ForEach(change =>
            {
                _context.Changes.Add(change);
            });            

            book.Title = bookDto.Title;
            book.Description = bookDto.Description;
            book.PublishedDate = bookDto.PublishedDate;
            book.Authors = bookDto.Authors;            

            await _context.SaveChangesAsync();

            return this.MapToDTO(book);
        }

        private BookDto MapToDTO(Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublishedDate = book.PublishedDate,
                Authors = book.Authors
            };
        }

        private List<Change> GetChanges(Book book, BookDto bookDto)
        {
            var now = DateTime.UtcNow;
            var changes = new List<Change>();

            if (book.Title != bookDto.Title)
            {
                var change = new Change()
                {
                    BookId = book.Id,
                    Property = ChangedProperty.Title,
                    Value = bookDto.Title,
                    Timestamp = now
                };

                changes.Add(change);
            }

            if (book.Description != bookDto.Description)
            {
                var change = new Change()
                {
                    BookId = book.Id,
                    Property = ChangedProperty.Description,
                    Value = bookDto.Description,
                    Timestamp = now
                };

                changes.Add(change);
            }

            if (book.PublishedDate != bookDto.PublishedDate)
            {
                var change = new Change()
                {
                    BookId = book.Id,
                    Property = ChangedProperty.PublishedDate,
                    Value = bookDto.PublishedDate.ToString(),
                    Timestamp = now
                };

                changes.Add(change);
            }

            if (book.Authors != bookDto.Authors)
            {
                var change = new Change()
                {
                    BookId = book.Id,
                    Property = ChangedProperty.Authors,
                    Value = bookDto.Authors,
                    Timestamp = now
                };

                changes.Add(change);
            }

            return changes;
        }
    }
}
