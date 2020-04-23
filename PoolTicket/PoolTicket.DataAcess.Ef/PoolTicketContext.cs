using Domain.PoolTicket;
using Microsoft.EntityFrameworkCore;
using PoolTicket.DataAccess.Ef.Configuration;
using System;

namespace PoolTicket.DataAcess.Ef
{
    public class PoolTicketContext : DbContext
    {
        public PoolTicketContext(DbContextOptions options)
        : base(options)
        {
        }

        //entites
        public virtual DbSet<User> User { get; set; }
        public DbSet<Ostan> Ostans { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Address> Addreses { get; set; }
        public DbSet<Pool> Pools { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<PoolFacility> PoolFacilities { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Sanse> Sanses { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new PoolConfig());
            modelBuilder.ApplyConfiguration(new PictureConfig());
            modelBuilder.ApplyConfiguration(new SanseConfig());
            modelBuilder.ApplyConfiguration(new ReserveConfig());
            modelBuilder.ApplyConfiguration(new PaymentConfig());
            modelBuilder.ApplyConfiguration(new FacilityConfig());
            modelBuilder.ApplyConfiguration(new PoolFacilityConfig());
            modelBuilder.ApplyConfiguration(new OstanConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new RoleConfig());
            modelBuilder.ApplyConfiguration(new UserRoleConfig());

        }


        public override int SaveChanges()
        {
            int result;
            try
            {
                result = base.SaveChanges();
                if (result == 0)
                    return 1;
                else
                    return result;
            }

            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
            }
            catch (DbUpdateException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
