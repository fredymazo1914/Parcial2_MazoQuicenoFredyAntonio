using Microsoft.EntityFrameworkCore;
using Parcial2_MazoQuicenoFredyAntonio.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial2_MazoQuicenoFredyAntonio.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //La siguiente línea comtrola la duplicidad de los países
            modelBuilder.Entity<NaturalPerson>().HasIndex(c => c.FullName).IsUnique();
        }


        public DbSet<NaturalPerson> NaturalsPersons { get; set; }




    }
}
