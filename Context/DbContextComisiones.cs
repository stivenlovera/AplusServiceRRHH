using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AplusServiceRRHH.Entities.DBComisiones;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AplusServiceRRHH.Context
{
    public class DbContextComisiones : IdentityDbContext
    {
        public DbContextComisiones(DbContextOptions<DbContextComisiones> options) : base(options)
        {
          
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public virtual DbSet<Gral_usuario> Gral_usuario { get; set; }
    }

}