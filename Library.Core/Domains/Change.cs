using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Core.Domains
{
    public class Change
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public ChangedProperty Property { get; set; }
        public string Value { get; set; }
        public DateTime Timestamp { get; set; }

        public virtual Book Book { get; set; }
    }

    public enum ChangedProperty
    {
        Title = 0,
        Description,
        PublishedDate,
        Authors
    }
}
