using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testapi28112022.Models;

namespace testapi28112022.Data
{
    public class testapi28112022Context : DbContext
    {
        public testapi28112022Context (DbContextOptions<testapi28112022Context> options)
            : base(options)
        {
        }

        public DbSet<testapi28112022.Models.Cliente> Cliente { get; set; }
    }
}
