using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class PoolFacilityConfig : IEntityTypeConfiguration<PoolFacility>
    {
        public void Configure(EntityTypeBuilder<PoolFacility> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("PoolFacilities");
            builder.Property(x => x.Description).HasMaxLength(200);
            
            //create relationship between pool and facility tables

            builder.HasOne(x => x.Facility).WithMany().HasForeignKey(x => x.FacilityId);
            builder.HasOne(x => x.Pool).WithMany(x => x.Facilities).HasForeignKey(x => x.PoolId);

        }
    }
}
