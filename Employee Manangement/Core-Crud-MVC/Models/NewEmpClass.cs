using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core_Crud_MVC.Models
{
    public class NewEmpClass
    {
        [Key]

        public int Empid { get; set; }

        [Required(ErrorMessage ="Enter employee name: ")]

        [Display(Name ="Employee Name")]


        public string Empname { get; set; }
        [Required(ErrorMessage = "Enter the email: ")]

        [Display(Name = "Email")]

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter the age: ")]

        [Display(Name = "Age")]

        [Range(20,50)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter the salary: ")]

        [Display(Name = "Salary")]

        public int Salary { get; set; }
    }
}
