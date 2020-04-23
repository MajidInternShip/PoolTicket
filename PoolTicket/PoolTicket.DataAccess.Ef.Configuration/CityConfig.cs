using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Cities");
            
            
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            //builder.HasIndex(x => new { x.OstanId, x.Name }).IsUnique();
            // کد خط بالا  را که کامنت کرده ام در جدول هر شهر ها  شهر تکراری در صورتی می توانیم داشته باشیم که
            // استان آن ها با هم فرق داشته باشد 
            builder.HasOne<Ostan>(x => x.Ostan).WithMany(x => x.Cities).HasForeignKey(x => x.OstanId);

        }
    }
}
