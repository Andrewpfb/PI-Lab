using System.Data.Entity;

namespace MVC5_3.Models
{
    public class VideoContext : DbContext
    {
        public VideoContext() : base("DbConnection") { }
        public DbSet<Video> Videos { get; set; }
    }
}