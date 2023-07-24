using System.ComponentModel.DataAnnotations;

namespace MVCdb.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MinLength(3,ErrorMessage ="Minimum 3 character required")]
        [MaxLength(15,ErrorMessage ="max 15 character allowed")]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Department { get; set; }  

    }
}
