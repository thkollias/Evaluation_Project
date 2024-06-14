using UniversityApp.Models.Courses;
using UniversityApp.Models.Employees;

namespace UniversityApp.Data;

internal class TeachersMockData : IMockData<Teacher>
{
    public List<Teacher> Data { get; set; } = [
        new Teacher
        {
            FirstName = "FirstName_1",
            LastName = "LastName_1",
            Age = 22,
            Courses =
            [
                new Course
                {
                    Title = "Maths",
                },
                new Course
                {
                    Title = "Physics III",
                }
            ]
        },
        new Teacher
        {
            FirstName = "FirstName_2",
            LastName = "LastName_2",
            Age = 21,
            Courses =
            [
                new Course
                {
                    Title = "Algebra II",
                },
                new Course
                {
                    Title = "Power Systems",
                }
            ]
        }
    ];
}