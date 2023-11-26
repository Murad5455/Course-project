using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UIManager:IUIService
    {
        Context c = new Context();

        public List<GroupAbout> GetAllListGroup(int id)
        {
            
            var result = c.GroupAbouts.Where(x => x.LanguageAboutId == id && x.Status == true).ToList();
            return result;

        }

        public List<Evaluation> GetAllListIdEvaluation(int id)
        {
            var result = c.Evaluations.Where(x => x.StudentID == id && x.Status == true).ToList();
            return result;
        }

        public List<Exam> GetAllListIdExam(int id)
        {
            var result = c.Exams.Where(x => x.StudentID == id && x.Status == true).ToList();
            return result;
        }

        public List<Schedule> GetAllListIdSchedule(int id)
        {
            var resulr = c.Schedules.Where(x => x.GroupId == id && x.Status == true).ToList();
            return resulr;
        }

        public List<Student> GetAllListStudent(int id)
        {
            var result = c.Students.Where(x => x.GroupId == id && x.Status ==true).ToList();
          
            return result;
        }

        public List<LanguageAbout> GetListLanguage(int id)
        {
            var result = c.LanguageAbout.Where(x => x.Status == true).ToList();
            return result;
        }

        public List<string> GetListStudentNameUI(int id)
        {
            using Context c = new Context();
            var result1 = c.Students.Where(x => x.StudentID == id).Select(a => a.StudentName).ToList();
            return result1;
        }

        public List<Teacher> GetListTeacherUI(int id)
        {
            var result = c.Teachers.Where(x => x.Status == true).ToList();
            return result;
        }


    }
}
