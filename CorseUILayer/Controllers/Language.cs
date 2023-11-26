using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;

namespace CorseUILayer.Controllers
{
    [Authorize]
    public class Language : Controller
    {
        LanguageManager Lm = new LanguageManager(new EfLanguageRepository());

     
        public IActionResult Index()
        {
            var result = Lm.GetListAllCheckStatusLanguage();
            return View(result);
        }

        [HttpGet]
        public IActionResult GetAddLanguage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLanguage(LanguageAbout language)
        {
            Lm.AddLanguage(language);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetUpdateLanguage(int id)
        {
           var result = Lm.GetByIdLanguage(id);
            return View("GetUpdateLanguage", result);
        }

        [HttpPost]
        public IActionResult UpdateLanguage(LanguageAbout language)
        {
         
            Lm.UpdateLanguage(language);
            return RedirectToAction("Index");
        }

       
        public IActionResult LanguageDelete(int id)
        { 
            Lm.DeleteLanguage(id);
           return RedirectToAction("Index");

        }

    }
}
