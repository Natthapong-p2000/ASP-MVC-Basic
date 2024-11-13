using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC_Basic.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนรหัสนักเรียน")]
        [DisplayName("รหัสนักเรียน")]
        public string Student_Id { get; set; }

        [Required(ErrorMessage = "กรุณาป้อนชื่อ")]
        [DisplayName("ชื่อ")]
        public string Name { get; set; }

        [DisplayName("คะแนน")]
        [Range(0, 100, ErrorMessage = "กรุณาป้อนคะแนนในช่วง 0-100")]
        public int Score { get; set; }
    }
}
