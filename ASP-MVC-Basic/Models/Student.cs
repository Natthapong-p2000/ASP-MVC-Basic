using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Basic.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Student_Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Score { get; set; }
    }
}
