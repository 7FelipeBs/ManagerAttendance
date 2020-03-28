using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlAttendance.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Anniversary { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string CPF { get; set; }

        [Required]
        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        public int NumberPhone { get; set; }

        [Required]
        [Range(0, 999999)]
        [Column(TypeName = "double(18, 2)")]
        public double Salary { get; set; }
        [Required]
        [Display(Name = "Street/Avenue ")]
        public string AnyAddress { get; set; }

        [Required]
        [Display(Name = "Number ")]
        public int NumberAdress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string District { get; set; }
    }
}
