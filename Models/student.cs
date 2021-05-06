using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HW.Models
{
    public class student
    {
        public student()
        {
            CreationDate = DateTime.Today;
            LastUpdateDate = DateTime.Now;
        }

        public int Id { get; set; }
        [DisplayName("Student ID")]
        [Required]
        public string StudentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Department { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreationDate { get; set; }
        [DisplayName("Last Update Date")]

        public DateTime LastUpdateDate { get; set; }


    }
}
