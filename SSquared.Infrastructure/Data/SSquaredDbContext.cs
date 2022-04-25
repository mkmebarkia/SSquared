using Microsoft.EntityFrameworkCore;
using SSquared.Core.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSquared.Infrastructure.Data
{
    public class SSquaredDbContext : DbContext
    {

        public SSquaredDbContext(DbContextOptions<SSquaredDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
