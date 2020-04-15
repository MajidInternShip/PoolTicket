using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PoolTicket.DataAccess.Ef.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.UserId);
            builder.ToTable("User");

            builder.Property(e => e.UserId).HasColumnName("UserId");
            builder.Property(e => e.CreatedDate).HasColumnType("datetime");
            builder.Property(e => e.ModifiedDate).HasColumnType("datetime");
            builder.Property(e => e.DeletedDate).HasColumnType("datetime");

            builder.Property(e => e.Name)
             .HasMaxLength(100);

            builder.Property(e => e.Family)
           .HasMaxLength(200);

            builder.Property(e => e.UserName)
            .HasMaxLength(100);

            builder.Property(e => e.MobileNumber)
              .IsRequired()
              .HasColumnType("char(11)")
              .IsUnicode(false);


        }
    }
}
