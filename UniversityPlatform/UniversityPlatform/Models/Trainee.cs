namespace UniversityPlatform.Models;

public class Trainee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Imag { get; set; }
    public string Address { get; set; }
    public string Grade { get; set; }
    public int Dept_id { get; set; }

    public Department Department { get; set; }
    public ICollection<CrsResult> CrsResults { get; set; }
}