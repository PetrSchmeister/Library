using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Domains
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PublishedDate { get; set; }
        public string Authors { get; set; }

        public virtual ICollection<Change> Changes { get; set; }
    }
}
