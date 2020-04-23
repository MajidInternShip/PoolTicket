using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class ReserveConfig : IEntityTypeConfiguration<Reserve>
    {
        public void Configure(EntityTypeBuilder<Reserve> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("Reserves");

            builder.HasOne(x => x.Sanse).WithMany(x => x.Reserves).HasForeignKey(x => x.SanseId);
            builder.HasOne(x => x.Payment).WithOne(x => x.Reserve);
            

        }
    }
}
