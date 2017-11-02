using System;
using System.Data.Entity;

namespace MVC5.Models
{
    public class PhonesDbInitializer : DropCreateDatabaseAlways<PhonesContext>
    {
        protected override void Seed(PhonesContext context)
        {
            context.Phones.Add(new Phones());
            context.Phones.Add(new Phones
            {
                Surname = "Petrov",
                Firstname = "Petr",
                MiddleName = "Petrovich",
                BDay = DateTime.Now.AddYears(-20),
                Phone = "1234567"
            });
            context.Phones.Add(new Phones
            {
                Surname = "Sidorov",
                Firstname = "Sidor",
                MiddleName = "Sidorovich",
                BDay = DateTime.Now.AddYears(-21),
                Phone = "1357924"
            });

            base.Seed(context);
        }
    }
}