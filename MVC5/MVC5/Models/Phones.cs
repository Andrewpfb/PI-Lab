using System;
using System.ComponentModel.DataAnnotations;

namespace MVC5.Models
{
    public class Phones
    {
        [Required]
        [MaxLength(30)]
        public string Surname { get; set; }

        [Required]
        [MaxLength(30)]
        public string Firstname { get; set; }

        [MaxLength(30)]
        public string MiddleName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BDay { get; set; }

        [Key]
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }

        public Phones()
        {
            Surname = "Ivanov";
            Firstname = "Ivan";
            MiddleName = "Ivanovich";
            BDay = DateTime.Now.AddYears(-18);
            Phone = "1112233";
        }
        public Phones(string surname, string firstname, string middlename, DateTime bDay, string phone)
        {
            Surname = surname;
            Firstname = firstname;
            MiddleName = middlename;
            BDay = bDay;
            Phone = phone;
        }
    }
}