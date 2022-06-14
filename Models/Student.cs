using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationTask.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Provide Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Provide Father Name")]
        public string FatherName { get; set; }


        [Required(ErrorMessage = "provide date of birth")]
        public DateTime DOB { get; set; }

        public int Age { get; set; }

        [Required(ErrorMessage = "provide Gender")]
        public string Gender { get; set; }
        public string Fee { get; set; }

    }
}
