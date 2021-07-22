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
    public class ChangesController : ControllerBase
    {
        private readonly IChangesService _changesService;

        public ChangesController(IChangesService changesService)
        {
            this._changesService = changesService;
        }

        // GET: api/changes        
        [HttpGet]
        public async Task<IEnumerable<ChangeDto>> GetChanges()
        {
            return await this._changesService.GetChanges();
        }
    }
}
