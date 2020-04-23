using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class SanseConfig : IEntityTypeConfiguration<Sanse>
    {
        public void Configure(EntityTypeBuilder<Sanse> builder)
        {
            builder.HasKey(x => x.Id);
            
            //fields automatic map to  database column with correct type not necessary to configure them

            builder.HasOne(x => x.Pool).WithMany(x => x.Sanses).HasForeignKey(x => x.PoolId);
            builder.HasMany(x => x.Reserves).WithOne(x => x.Sanse);

            

        }
    }
}
