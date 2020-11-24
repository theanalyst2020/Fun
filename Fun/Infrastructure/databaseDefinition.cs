using Fun.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fun.Infrastructure
{
    public class databaseDefinition: DbContext
    {
        public databaseDefinition(DbContextOptions<databaseDefinition> options):base(options)
        {

        }
        public DbSet<store> stores { get; set; }
    }
}
