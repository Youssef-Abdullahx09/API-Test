using Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Data.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Session)
                .WithOne(x => x.Rating)
                .HasForeignKey<Session>(x => x.RatingId)
                .IsRequired();
        }
    }
}
