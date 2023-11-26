using BusinessLayer.Concrete;
using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;

namespace CorseUILayer.Controllers
{
   [Authorize]
    public class GroupController : Controller
    {
        GroupManager gm = new GroupManager(new EfGroupRepository());
        LanguageManager la = new LanguageManager(new EfLanguageRepository());

        [HttpGet]
        public IActionResult Index(int id)
        {
           
            var result = gm.GetAllIdGroupList(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult GetUpdateGroup(int id)
        {
            var resultT = gm.TeacherChooseList();
            ViewBag.Values2 = resultT;
            var resultG = gm.GroupChooseList();
            ViewBag.Values = resultG;
            var result = gm.GetByIdGroup(id);
            /*ViewBag.languageId = result.LanguageAboutId;
            ViewBag.LanguageAbout = la.GetByIdLanguage(ViewBag.languageId);*/
            

        return View("GetUpdateGroup", result);
        }

        [HttpPost]
        public IActionResult GroupUpdate(GroupAbout group)
        {          
            gm.UpdateGroup(group); 
            return Redirect("/Group/Index/"+group.LanguageAboutId);
        }

        public IActionResult DeleteGroup(int id)
        {
          var result = gm.GetByIdGroup(id);
            gm.ChangeGroup(result);
            return Redirect("/Group/Index/" + result.LanguageAboutId);
        }

        [HttpGet]
        public IActionResult GetAddGroup()
        {
            var resultT = gm.TeacherChooseList();
            ViewBag.Values2 = resultT;
            var result1 = gm.GroupChooseList();
            ViewBag.Values = result1;

            return View();
        }

        [HttpPost]
        public IActionResult GroupAdd(GroupAbout group)
        {
            gm.AddGroup(group);
            return Redirect("/Group/Index/" + group.LanguageAboutId);
        }
        
    }
}
