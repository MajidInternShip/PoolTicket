using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class PictureConfig : IEntityTypeConfiguration<Picture>
    {
        public void Configure(EntityTypeBuilder<Picture> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Pictures");
            builder.Property(x => x.ImageMimeType).HasMaxLength(100);


            builder.HasOne(x => x.Pool).WithMany(x => x.Pictures).HasForeignKey(x => x.PoolId);
            builder.HasOne(x => x.PoolFacility).WithMany().HasForeignKey(x => x.PoolFacilityId);

        }
    }
}
