using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Backend.CrudDemo.Domain
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; } 
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Grade { get; set; }
        public int Age { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
