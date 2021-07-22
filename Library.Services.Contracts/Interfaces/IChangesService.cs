using Library.Core.Domains;
using Library.Services.Contracts.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Contracts.Interfaces
{
    public interface IChangesService
    {
        Task<IEnumerable<ChangeDto>> GetChanges();
        Task AddChanges(List<Change> changes);
    }
}
