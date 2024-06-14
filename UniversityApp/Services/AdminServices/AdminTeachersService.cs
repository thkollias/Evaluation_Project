using UniversityApp.Data;
using UniversityApp.DTOs.TeacherDTOs;
using UniversityApp.Models.Employees;

namespace UniversityApp.Services.AdminServices;

internal class AdminTeachersService : IAdminTeachersService
{
    private readonly TeachersMockData _teachersMockData;

    internal AdminTeachersService(TeachersMockData teachersMockData)
    {
        _teachersMockData = teachersMockData;
    }

    public List<GetAllTeachersDto>? GetTeachers() =>
        _teachersMockData.Data.Count == 0
            ? null
            : _teachersMockData.Data
                .Select(t => new GetAllTeachersDto
                {
                    FirstName = t.FirstName,
                    LastName = t.LastName,
                    Age = t.Age
                }).ToList();

    public GetByIdTeacherDto? GetTeacherById(int id) =>
        _teachersMockData.Data
            .Select(t => new GetByIdTeacherDto
            {
                FirstName = t.FirstName,
                LastName = t.LastName,
            })
            .FirstOrDefault(t => t.Id.Equals(id));

    public void CreateTeacher(CreateTeacherDto dto)
    {
        if (_teachersMockData.Data.Any(t => t.Id.Equals(dto.Id)))
            return;
        _teachersMockData.Data.Add(new Teacher
        {
            Id = dto.Id,
            FirstName = dto.FirstName,
            LastName = dto.LastName
        });
    }

    /* Update - Get */
    public UpdateTeacherDto? UpdateTeacher(int id) =>
        _teachersMockData.Data
            .Select(t => new UpdateTeacherDto
            {
                FirstName = t.FirstName,
                LastName = t.LastName,
                Age = t.Age,
                Wage = t.Age,
                StartDate = t.StartDate,
                Courses = t.Courses
            })
            .FirstOrDefault(t => t.Id.Equals(id));

    /* Update - Post */
    public void UpdateTeacher(UpdateTeacherDto dto)
    {
        int index;
        try
        {
            index = _teachersMockData.Data
                .FindIndex(t => t.Id.Equals(dto.Id));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
            return;
        }
        
        _teachersMockData.Data[index] = new Teacher
        {
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            Age = dto.Age,
            Wage = dto.Age,
            StartDate = dto.StartDate,
            Courses = dto.Courses,
        };
    }

    public void RemoveTeacherById(int id)
    {
        int index;
        try
        {
         index = _teachersMockData.Data
            .FindIndex(t => t.Id.Equals(id));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
            return;
        }
        
        _teachersMockData.Data.RemoveAt(index);
    }
}