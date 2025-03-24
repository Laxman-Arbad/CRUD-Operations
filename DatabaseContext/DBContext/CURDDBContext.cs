using DatabaseContext.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContextTier.DBContext
{
    public class CURDDBContext : DbContext
    {
        public CURDDBContext(DbContextOptions<CURDDBContext> options) : base(options)
        { 
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
