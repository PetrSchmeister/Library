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
    public class ChangesService : IChangesService
    {
        private readonly LibraryDBContext _context;

        public ChangesService(LibraryDBContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<ChangeDto>> GetChanges()
        {
            var changes = await _context.Changes
              .AsNoTracking()              
              .ToListAsync();

            return changes.Select(change => this.MapToDTO(change));
        }

        public async Task AddChanges(List<Change> changes)
        {            
            await _context.Changes.AddRangeAsync(changes);
        }

        private ChangeDto MapToDTO(Change change)
        {            
            return new ChangeDto
            {
                Id = change.Id,
                BookId = change.BookId,
                Property = change.Property,
                Value = change.Value,
                Timestamp = change.Timestamp
            };
        }
    }
}
