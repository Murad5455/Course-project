using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CorseUILayer.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        StudentManager sm =new StudentManager(new EfStudentRepository());

        public IActionResult Index(int id)
        {
            var ressult = sm.GetAllIdStudentList(id);
            return View(ressult);
        }

        [HttpGet]
        public IActionResult GetUpdateStudent(int id)
        {
            var result1 = sm.StudentChooseList();
            ViewBag.Values = result1;
            var result = sm.GetByIdStudent(id);
            return View("GetUpdateStudent", result);
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            sm.UpdateStudent(student);
            return Redirect("/Student/Index/"+student.GroupId);
        }

        [HttpGet]
        public IActionResult GetNewStudent()
        {
            var result1 = sm.StudentChooseList();
            ViewBag.Values = result1;
            return View();
        }

        [HttpPost]
        public IActionResult AddNewStudent(Student student)
        {
           sm.AddStudent(student);
            return Redirect("/Student/Index/" + student.GroupId);
        }

        [HttpGet]
        public IActionResult DeleteStudentt(int id)
        {
             var result = sm.GetByIdStudent(id);
            sm.ChangeStatus(result);
            return Redirect("/Student/Index/" + result.GroupId);   
        }
    }
}


