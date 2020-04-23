using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class OstanConfig : IEntityTypeConfiguration<Ostan>
    {
        public void Configure(EntityTypeBuilder<Ostan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Ostans");
            

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

        }
    }
}
