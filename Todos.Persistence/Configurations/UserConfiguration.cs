using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Todos.Domain.Entities;

namespace Todos.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.UserName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Created_by).IsRequired();
            builder.Property(e => e.Created_at).IsRequired();
            builder.Property(e => e.Status).IsRequired();
        }
    }
}
