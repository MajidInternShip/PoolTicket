using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Addreses");

            builder.Property(x => x.ExactAddress).IsRequired().HasMaxLength(200);
            builder.Property(x => x.PostalCode).HasMaxLength(10);
            builder.Property(x => x.Latitude).HasColumnType("decimal(10,6");
            builder.Property(x => x.Longitdue).HasColumnType("decimal(10,6");


            builder.HasOne(x => x.City).WithMany().HasForeignKey(x => x.CityId);

        }
    }
}
