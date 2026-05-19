using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1mvc1.Models;

namespace WebApplication1mvc1.Configuration
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(500);
            builder.Property(p => p.DurationDays).IsRequired();
            builder.Property(p => p.Price).HasPrecision(10, 2);
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.UpdatedAt);
            builder.ToTable(tp =>
            {
                tp.HasCheckConstraint("CK_Plan_DurationDays", "DurationDays Between 1 and 365");

            });
        }
    }
}
