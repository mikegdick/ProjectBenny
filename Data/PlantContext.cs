using Microsoft.EntityFrameworkCore;
using ProjectBenny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBenny.Data
{
    public class PlantContext : DbContext
    {

        public PlantContext(DbContextOptions<PlantContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

    }
}
