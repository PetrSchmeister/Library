using Library.Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using Library.Infrastructure.EntityConfigurations;

namespace Library.Infrastructure
{
    public class LibraryDBContext : DbContext
    {

            public LibraryDBContext(DbContextOptions<LibraryDBContext> options)
                : base(options)
            {
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new BookConfiguration());
                modelBuilder.ApplyConfiguration(new ChangeConfiguration());
            }

            public DbSet<Book> Books { get; set; }

            public DbSet<Change> Changes { get; set; }        
    }
}
