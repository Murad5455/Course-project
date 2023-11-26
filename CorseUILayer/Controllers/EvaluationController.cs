using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.DependencyResolver;

namespace CorseUILayer.Controllers
{
    [Authorize]
    public class EvaluationController : Controller
    {
        EvaluationManager EM = new EvaluationManager(new EfEvaluationRepository());


        [HttpGet]
        public IActionResult Index(int id)
        {
            var result1 = EM.GetListStudentNameEvaluation(id);
            ViewBag.StudentName = result1;
            var result = EM.GetIdEvaluationList(id);
            return View(result);
        }

        [HttpGet]
        public IActionResult GetEvaluation()
        {
            var result1 = EM.EvaluationChooseList();
            ViewBag.Values = result1;
            return View();               
        }

        [HttpPost]
        public IActionResult GetAddEvaluation(Evaluation evaluation,int id)
        {
           
            EM.AddEvaluation(evaluation,id);

            return Redirect("/Evaluation/Index/" + evaluation.StudentID);
        }

        [HttpGet]
        public IActionResult DeleteEvaluation(int id)
        {
            EM.ChangeEvaluation(id);
         var result = EM.GetByIdSEvaluation(id);
            return Redirect("/Evaluation/Index/"+ result.StudentID);
        }

        [HttpGet]
        public IActionResult GetUpdate(int id)
        {
            var result1 = EM.EvaluationChooseList();
            ViewBag.Values = result1;
            var result = EM.GetByIdSEvaluation(id);
            return View("GetUpdate", result);
        }

        [HttpPost]
        public IActionResult UpdateEvaluation(Evaluation evaluation, int id)
        {
            EM.UpdateEvaluation(evaluation,id);
            return Redirect("/Evaluation/Index/" + evaluation.StudentID);
        }




    }
}
