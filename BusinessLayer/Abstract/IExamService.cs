using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IExamService
    {
        public List<Exam> GetByIdExamAll(int id);

        public void DeleteExam(int id);

        public void UpdateExam(Exam exam);

        public void AddExam(Exam exam);

        public Exam GetByIdExam(int id);

        public List<SelectListItem> ExamChooseList();
        
        public List<string> GetListStudentNameExam(int id);



    }
}
