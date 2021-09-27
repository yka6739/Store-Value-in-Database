using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication30.Shared.Entities;

namespace WebApplication30.Server
{
    public class ApplicationDbContext:DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Online>().HasKey(x => new { x.Id });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Online> Genres { get; set; }
    }
}
