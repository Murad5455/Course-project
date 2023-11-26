using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace CorseUILayer.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        TeacherManager tm = new TeacherManager(new EfTeacherRepository());

        public IActionResult Index()
        {
          var result = tm.GetAllIdTeacherList();
            return View(result);
        }

        public IActionResult DeleteTeacher(int id)
        {
            var result = tm.GetByIdTeacher(id);
            tm.ChangeStatusTeacher(result);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetUpdateTeacher(int id)
        { 
           var result = tm.GetByIdTeacher(id);
            return View("GetUpdateTeacher",result);
        }

        [HttpPost]
        public IActionResult UpdateTeacher(Teacher teacher)
        {  
            tm.UpdateTeacher(teacher);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetAddTeacher()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetTeacherAdd(Teacher teacher)
        {
            tm.AddTeacher(teacher);
            return RedirectToAction("Index");
        }

    }
}
