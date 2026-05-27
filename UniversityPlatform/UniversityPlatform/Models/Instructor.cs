namespace UniversityPlatform.Models;
using System.ComponentModel.DataAnnotations.Schema;
public class Instructor {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Imag { get; set; }
    [Column(TypeName = "decimal(18,2)")] 
    public decimal Salary { get; set; }
    public string Address { get; set; }
    public int Dept_id { get; set; }
    public int Crs_id { get; set; }

    // Navigation properties
    public Department Department { get; set; }
    public Course Course { get; set; }
}