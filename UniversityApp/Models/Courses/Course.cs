using System.ComponentModel.DataAnnotations;
using UniversityApp.Models.Employees;
using UniversityApp.Models.Sessions;
using UniversityApp.Models.Students;

namespace UniversityApp.Models.Courses;

public class Course
{
    [Key] public int Id { get; init; }

    [Required(ErrorMessage = "Course Title is required!")]
    [StringLength(30, MinimumLength = 2, ErrorMessage = $"{nameof(Title)} must be between 2 to 30 characters.")]
    public string Title { get; init; } = null!;

    public Dictionary<WeekDays, List<Session>>? WeeklyLessonsPerDay { get; init; } = [];

    [Range(0, 100, ErrorMessage = $"{nameof(OralMark)} must be between 0 and 100.")]
    public int OralMark { get; set; }

    [Range(0, 100, ErrorMessage = $"{nameof(WritingMark)} must be between 0 and 100.")]
    public int WritingMark { get; set; }

    public Teacher Teacher { get; set; } = null!;
    public List<Student> Students { get; set; } = [];
}