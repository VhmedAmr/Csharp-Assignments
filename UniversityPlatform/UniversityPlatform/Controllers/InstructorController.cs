using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using UniversityPlatform.Models; // Ensure this matches your namespace
using UniversityPlatform.Data;   // Ensure this matches where your DbContext is

namespace UniversityPlatform.Controllers;

public class InstructorController : Controller {
    
    private readonly ApplicationDbContext _context;
    
    public InstructorController(ApplicationDbContext context) {
        _context = context;
    }

    public IActionResult Index(string searchString) {
      
        var instructors = from i in _context.Instructors
            select i;

       
        if (!string.IsNullOrEmpty(searchString)) {
            instructors = instructors.Where(i => i.Name.Contains(searchString));
        }

     
        return View(instructors.ToList());
    }
    
    public IActionResult Detail(int id) {
        var instructor = _context.Instructors.FirstOrDefault(i => i.Id == id);
        
        if (instructor == null) {
            return NotFound();
        }
        
        return View(instructor);
    }
}