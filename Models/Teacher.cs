namespace WebApplication4.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherAddress { get; set; }
        public int TeacherAge { get; set; }
        public Subject Subject { get; set; }
    }
}
