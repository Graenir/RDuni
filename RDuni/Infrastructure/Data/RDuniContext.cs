using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Models;

namespace Infrastructure.Data
{
    public class RDuniContext : DbContext
    {
        public RDuniContext(DbContextOptions<RDuniContext> options)
            : base(options)
        { 
        }

        public DbSet<User> User { get; set; }
    }
}
