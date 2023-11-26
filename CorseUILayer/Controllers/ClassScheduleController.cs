using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace CorseUILayer.Controllers
{
    [Authorize]
    public class ClassScheduleController : Controller
    {
        ClassScheduleManager CSM = new ClassScheduleManager(new EfClassScheduleRepository());

        [HttpGet]
        public IActionResult Index(int id)
        {
            var result = CSM.GetAllIdScheduleList(id);
            return View(result);
         }
    
        public IActionResult ScheduleDelete(int id) 
        {
            var result = CSM.GetByIdSchedule(id);
            CSM.DeleteSchedule(id);
            return Redirect("/ClassSchedule/Index/" + result.GroupId);
        }

        [HttpGet]
        public IActionResult GetUpdateSchedule(int id) 
        {
            var result1 = CSM.ScheduleChooseList();
            ViewBag.Values = result1;
            var result = CSM.GetByIdSchedule(id);
            return View("GetUpdateSchedule", result);
        }

        [HttpPost]
        public IActionResult UpdateSchedule(Schedule schedule)
        {
            CSM.UpdateSchedule(schedule);
            return Redirect("/ClassSchedule/Index/" + schedule.GroupId);
        }

        [HttpGet]
        public IActionResult GetAddSchedule() 
        {
            var result1 = CSM.ScheduleChooseList();
            ViewBag.Values = result1;
            return View();
        }

        [HttpPost]
        public IActionResult AddSchedule(Schedule schedule)
        {
            CSM.AddSchedule(schedule);
            return Redirect("/ClassSchedule/Index/"+schedule.GroupId);
        }




    }
}
