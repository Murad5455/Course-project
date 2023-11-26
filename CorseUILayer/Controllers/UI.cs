using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CorseUILayer.Controllers
{
    public class UI : Controller
    {
        UIManager UIM = new UIManager();

        public IActionResult Index(int id)
        {
           
            var result = UIM.GetListTeacherUI(id);
                return View(result);
        }

        [HttpGet]
        public IActionResult GetListLanguageAll(int id)
        {
           var result = UIM.GetListLanguage(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GetListGroup(int id)
        {
            var result = UIM.GetAllListGroup(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GeALLIdStudent(int id) 
        { 
       var result = UIM.GetAllListStudent(id);
            return View(result);
                   
        }

        [HttpGet]
        public IActionResult GetAllIdEvaluation(int id)
        {
            var result1 = UIM.GetListStudentNameUI(id);
            ViewBag.StudentName = result1;
            var result = UIM.GetAllListIdEvaluation(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GetAllIdExam(int id)
        {
            var result1 = UIM.GetListStudentNameUI(id);
            ViewBag.StudentName = result1;
            var result = UIM.GetAllListIdExam(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GetAllIdSchedule(int id)
        {
            var result = UIM.GetAllListIdSchedule(id);
            return View(result);
        } 

    }
}

