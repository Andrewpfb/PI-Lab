using System.Data.Entity;


namespace MVC5.Models
{
    public class PhonesContext : DbContext
    {
        public DbSet<Phones> Phones { get; set; }
    }
}