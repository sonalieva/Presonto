using Microsoft.EntityFrameworkCore;
using Presento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
           
        {

        }
        public DbSet<Team> Teams { get; set; }
    }
}
