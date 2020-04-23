using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class PoolConfig : IEntityTypeConfiguration<Pool>
    {
        public void Configure(EntityTypeBuilder<Pool> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Pools");


            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);
            
            builder.HasOne(x => x.Address).WithMany().HasForeignKey(x => x.AddressId);
            builder.HasMany(x => x.PoolUsers).WithOne(x=>x.Pool);
            builder.HasMany(x => x.Facilities).WithOne(x => x.Pool);
            builder.HasMany(x => x.Pictures).WithOne(x => x.Pool);
            builder.HasMany(x => x.Sanses).WithOne(x => x.Pool);

            

        }
    }
}
