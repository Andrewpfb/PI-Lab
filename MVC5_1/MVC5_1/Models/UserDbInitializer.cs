using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5_1.Models
{
    public class UserDbInitializer:DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User { Firstname = "Ivan", Surname = "Ivanov", Middlename = "Ivanovich", BDay = new DateTime(1994, 7 ,20), Phone = "123-24-24" });
            context.Users.Add(new User { Firstname = "Sidor", Surname = "Sidorov", Middlename = "Sidorovich", BDay = new DateTime(1990, 7, 20), Phone = "333-24-24" });
            context.Users.Add(new User { Firstname = "Fedor", Surname = "Fedorov", Middlename = "Fedorovich", BDay = new DateTime(1995, 7, 20), Phone = "444-24-24" });

            base.Seed(context);
        }
    }
}