using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5_1.Models
{
    public class UserContext:DbContext
    {
        public UserContext() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }
    }
}