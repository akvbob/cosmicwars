using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CosmicWars.Models
{
    public class CosmicWarsContext : DbContext
    {
        public CosmicWarsContext(DbContextOptions<CosmicWarsContext> options) : base(options)
        {

        }

        public DbSet<Player> Players { get; set; }
    }
}
