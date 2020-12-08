using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BoulderBeta.Models;



namespace BoulderBeta.Context
{
    public class BoulderContext : DbContext
    {
        public BoulderContext (DbContextOptions<BoulderContext> options)
            : base(options)
        {

        }
        public DbSet<Boulder> Boulders { get; set; }
    }

}
