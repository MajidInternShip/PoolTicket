using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class PoolUserConfig : IEntityTypeConfiguration<PoolUser>
    {
        public void Configure(EntityTypeBuilder<PoolUser> builder)
        {
            builder.HasKey(x => x.Id);
            
        }
    }
}
