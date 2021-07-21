using Library.Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.EntityConfigurations {
    public class BookConfiguration : IEntityTypeConfiguration<Book> {
        public void Configure(EntityTypeBuilder<Book> builder) {
            builder.ToTable("Books");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(p => p.Title).IsRequired();

            builder.Property(p => p.Description).IsRequired();

            builder.Property(p => p.PublishedDate).IsRequired();

            builder.Property(p => p.Authors).IsRequired();
        }    
    }
}
