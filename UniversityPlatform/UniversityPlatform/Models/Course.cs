namespace UniversityPlatform.Models;

public class Course {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Degree { get; set; }
    public int MinDegree { get; set; }
    public int Hrs { get; set; }
    public int Dept_id { get; set; }

    public Department Department { get; set; }
    public ICollection<Instructor> Instructors { get; set; }
    public ICollection<CrsResult> CrsResults { get; set; }
}