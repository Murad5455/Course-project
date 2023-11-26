using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUIService
    {
        public List<Teacher> GetListTeacherUI(int id);

        public List<LanguageAbout> GetListLanguage(int id);

        public List<GroupAbout> GetAllListGroup(int id);
       
        public List<Student> GetAllListStudent(int id);
        
        public List<Evaluation> GetAllListIdEvaluation(int id);
      
        public List<Exam> GetAllListIdExam(int id);
        
        public List<Schedule> GetAllListIdSchedule(int id);
       
        public List<string> GetListStudentNameUI(int id);


    }
}
