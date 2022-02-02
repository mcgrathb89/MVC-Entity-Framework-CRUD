using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Subject
    {
        [Key]
        public int SubjetId { get; set; }
        public string SubjectName { get; set; }
        public string SubjetTerm { get; set; }
        public string SubjectCredits { get; set; }
        public List<Teacher> SubjectTeachers { get; set; } = new List<Teacher>();
    }
}
