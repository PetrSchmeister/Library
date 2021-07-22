using Library.Services.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Contracts.Interfaces
{
    public interface IBooksService
    {                    
            Task<IEnumerable<BookDto>> GetBooks();
            Task<BookDto> GetBook(int bookId);
            Task<BookDto> CreateBook(BookDto book);
            Task<BookDto> UpdateBook(int bookId, BookDto book);
    }
}
