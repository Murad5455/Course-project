using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExamManager : IExamService
    {
        private readonly IExamDal examDal;
        public ExamManager(IExamDal _examDal)
        {
        examDal = _examDal;
        }


        public void AddExam(Exam exam)
        {
            exam.ExamTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            exam.Status = true;
            examDal.Inser(exam);
        }

        public void DeleteExam(int id)
        {
            var result = examDal.GetById(id);
            result.Status = false;
            examDal.TUpdate(result);
        }

        public List<SelectListItem> ExamChooseList()
        {
            StudentManager Lm = new StudentManager(new EfStudentRepository());
            List<SelectListItem> Values = (from x in Lm.GetListAllStudent()
                                           select new SelectListItem 
                                           {
                                               Text = x.StudentName,
                                               Value = x.StudentID.ToString()
                                           }).ToList();

            return Values;
        }

        public Exam GetByIdExam(int id)
        {
            var result = examDal.GetById(id);
            return result;
        }

        public List<Exam> GetByIdExamAll(int id)
        {
            var result = examDal.GetAllIdExam(id);
            return result;
        }

        public List<string> GetListStudentNameExam(int id)
        {
            var result = examDal.GetStudentNameExam(id);
            return result;
        }

        public void UpdateExam(Exam exam )
        {
            exam.ExamTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            exam.Status = true;
            examDal.Update(exam);
        }
    }
}
