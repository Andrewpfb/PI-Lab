using System;
using System.ComponentModel.DataAnnotations;

namespace MVC5_1.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Surname { get; set; }
        [MaxLength(30)]
        public string Firstname { get; set; }
        [MaxLength(30)]
        public string Middlename { get; set; }
        [DataType(DataType.Date)]
        [DateValidAttr] //собственный валидатор. Определен в классе DateValidAttr.
        public DateTime BDay{get;set;}
        [MaxLength(10)]
        public string Phone { get; set; }
    }
}