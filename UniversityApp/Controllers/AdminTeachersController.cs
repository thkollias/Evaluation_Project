using Microsoft.AspNetCore.Mvc;
using UniversityApp.Data;
using UniversityApp.DTOs.TeacherDTOs;
using UniversityApp.Services.AdminServices;

namespace UniversityApp.Controllers;

public class AdminTeachersController : Controller
{
    /* Service Injection Fail */
    // private readonly IAdminTeachersService _adminTeachersService;
    // internal AdminTeachersController(IAdminTeachersService adminTeachersService)
    // {
    //     _adminTeachersService = adminTeachersService;
    // }

    /* Plan-B, DB-list & service as coupled dependencies in Controller */
    private static readonly TeachersMockData TeacherMocks = new();
    private readonly AdminTeachersService _adminTeachersService = new(TeacherMocks);

    [HttpGet]
    public IActionResult Teachers() =>
        View(_adminTeachersService.GetTeachers());

    [HttpGet]
    public IActionResult Create() =>
        View();

    [HttpPost]
    public IActionResult Create(CreateTeacherDto dto)
    {
        _adminTeachersService.CreateTeacher(dto);
        return RedirectToAction("Teachers");
    }

    [HttpGet]
    public IActionResult Edit(int id) =>
        View(_adminTeachersService.UpdateTeacher(id));

    [HttpPost]
    public IActionResult Edit(UpdateTeacherDto dto)
    {
        _adminTeachersService.UpdateTeacher(dto);
        return RedirectToAction("Teachers");
    }
    
    [HttpPost]
    public IActionResult Delete(int id) 
    {
        _adminTeachersService.RemoveTeacherById(id);
        return RedirectToAction("Teachers");
    }
    
}