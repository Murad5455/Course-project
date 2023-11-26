using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CorseUILayer.Controllers
{
    public class ExamController : Controller
    {
        ExamManager Em = new ExamManager(new EfExamRepository());

        [HttpGet]
        public IActionResult Index(int id)
        {
            var result1 = Em.GetListStudentNameExam(id);
            ViewBag.StudentName = result1;
           var result = Em.GetByIdExamAll(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GetAddExam()
        {
            var result1 = Em.ExamChooseList();
            ViewBag.Values = result1;
            return View();
        
        }

        [HttpPost]
        public IActionResult ExamAdd(Exam exam) 
        {
            Em.AddExam(exam);
            return Redirect("/Exam/Index/" + exam.StudentID);

        }

        [HttpGet]
        public IActionResult GetUpdateExam(int id)
        {
            var result1 = Em.ExamChooseList();
            ViewBag.Values = result1;
            var result = Em.GetByIdExam(id);
            return View("GetUpdateExam",result);
        }

        [HttpPost]
        public IActionResult UpdateExam(Exam exam)
        {
             Em.UpdateExam(exam);
            return Redirect("/Exam/Index/" + exam.StudentID);
        }
     
        public IActionResult ExamDelete(int id)
        {
            Em.DeleteExam(id);
            var result = Em.GetByIdExam(id);
            return Redirect("/Exam/Index/" + result.StudentID);
        }
       

    }
}
