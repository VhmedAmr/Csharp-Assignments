namespace UniversityPlatform.Models;

public class Department {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Manager { get; set; }
    // Navigation properties
    public ICollection<Instructor> Instructors { get; set; }
    public ICollection<Trainee> Trainees { get; set; }
    public ICollection<Course> Courses { get; set; }
}