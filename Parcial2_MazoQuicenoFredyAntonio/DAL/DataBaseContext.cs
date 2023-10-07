using Microsoft.EntityFrameworkCore;
using Parcial2_MazoQuicenoFredyAntonio.DAL.Entities;

namespace Parcial2_MazoQuicenoFredyAntonio.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
                
        }

        public DbSet<NaturalPerson> NaturalsPersons { get; set; }




    }
}
