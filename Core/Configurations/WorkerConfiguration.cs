using Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Core.Configurations
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.Property(worker => worker.FullName).IsRequired().HasMaxLength(50);
            builder.Property(worker => worker.Description).IsRequired().HasMaxLength(100);
            builder.Property(worker => worker.SocialMediaUrl).IsRequired().HasMaxLength(100);
            builder.Property(worker => worker.ImgUrl).IsRequired().HasMaxLength(100);
            builder.Property(worker => worker.Salary).IsRequired().HasMaxLength(10);
        }
    }
}
