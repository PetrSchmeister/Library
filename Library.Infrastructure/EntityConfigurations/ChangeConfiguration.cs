using Library.Core.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Infrastructure.EntityConfigurations {
    public class ChangeConfiguration : IEntityTypeConfiguration<Change> {
        public void Configure(EntityTypeBuilder<Change> builder) {
            builder.ToTable("Changes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.HasOne<Book>(s => s.Book)
                .WithMany(g => g.Changes)
                .HasPrincipalKey(s => s.Id)
                .HasForeignKey(s => s.BookId);

            builder.Property(p => p.Property).IsRequired();

            builder.Property(p => p.Value).IsRequired();

            builder.Property(p => p.Timestamp).IsRequired();
        }
    }
}
