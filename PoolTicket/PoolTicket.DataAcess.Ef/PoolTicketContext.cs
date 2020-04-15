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



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());

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
