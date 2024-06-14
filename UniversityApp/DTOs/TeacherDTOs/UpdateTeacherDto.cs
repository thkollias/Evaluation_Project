using UniversityApp.Models.Courses;

namespace UniversityApp.DTOs.TeacherDTOs;

public class UpdateTeacherDto : BaseTeacherDto
{
    public int Id { get; }
    public int Age { get; set; }
    public double Wage { get; set; }
    public DateTime StartDate { get; set; }
    public List<Course> Courses { get; set; } = [];
    public override string FirstName { get; set; } = null!;
    public override string LastName { get; set; } = null!;
}