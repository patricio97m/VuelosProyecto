using System.Data.Entity;

namespace Vuelos.Models
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }

        public DbSet<Vuelo> Vuelo { get; set; }

    }
}