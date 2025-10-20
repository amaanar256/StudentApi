namespace StudentAPI.Models
{
    public class Student
    {
        public int Id { get; set; } // Auto-generated ID
        public string Name { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Status { get; set; } = "Active"; // Default Active
    }
}
