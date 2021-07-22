using Library.Core.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Contracts.DTOs
{
    public class ChangeDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public ChangedProperty Property { get; set; }
        public string Value { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
