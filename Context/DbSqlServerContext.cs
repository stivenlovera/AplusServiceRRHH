using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace AplusServiceRRHH.Context
{
    public class DbSqlServerContext : DbContext
    {
        public DbSqlServerContext(DbContextOptions<DbSqlServerContext> options) : base(options)
        {

        }
    }
}