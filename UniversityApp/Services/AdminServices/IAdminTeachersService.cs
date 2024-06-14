using UniversityApp.DTOs.TeacherDTOs;

namespace UniversityApp.Services.AdminServices;

internal interface IAdminTeachersService
{
    public List<GetAllTeachersDto>? GetTeachers();
    public GetByIdTeacherDto? GetTeacherById(int id);
    public void CreateTeacher(CreateTeacherDto dto);
    public UpdateTeacherDto? UpdateTeacher(int id);     // Update Get
    public void UpdateTeacher(UpdateTeacherDto dto);    // Update Post
    public void RemoveTeacherById(int id);
}