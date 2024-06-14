using System.ComponentModel.DataAnnotations;
using UniversityApp.Models.Courses;

namespace UniversityApp.Models.Employees;

public class Teacher : Employee
{
    public override int Id { get; init; }
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
    public override int Age { get; set; }
    public override double Wage { get; set; }
    public override DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Teacher cannot serve without having courses!")]
    public List<Course> Courses { get; set; } = [];
}