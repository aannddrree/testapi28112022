using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testweb.Models;

namespace testweb.Data
{
    public class testwebContext : DbContext
    {
        public testwebContext (DbContextOptions<testwebContext> options)
            : base(options)
        {
        }

        public DbSet<testweb.Models.Cliente> Cliente { get; set; }
    }
}
