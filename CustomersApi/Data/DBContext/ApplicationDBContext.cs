using CustomersApi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace CustomersApi.Data.DBContext
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> context) : base(context)
        {
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
