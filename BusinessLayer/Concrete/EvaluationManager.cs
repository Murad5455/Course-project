using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EvaluationManager : IEvaluationService
    {
        private readonly IEvaluationDal evaluationDal;

        Context c = new Context();

        public EvaluationManager(IEvaluationDal _evaluationDal)
        {
            evaluationDal = _evaluationDal;
        }

        public void AddEvaluation(Evaluation evaluation,int id)
        {
            evaluation.PriceGiveDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            evaluation.Status = true;
            evaluationDal.Inser(evaluation);
        }

        public void ChangeEvaluation(int id)
        {
            var result = evaluationDal.GetById(id);
            result.Status = false;
            evaluationDal.TUpdate(result);
           
        }

        public List<SelectListItem> EvaluationChooseList()
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

        public List<Evaluation> GetAllIdEvaluationList(int id)
        {
            return evaluationDal.GetAllIdEvaluation(id);
        }

        public Evaluation GetByIdSEvaluation(int id)
        {
            return evaluationDal.GetById(id);
        }

        public List<Evaluation> GetIdEvaluationList(int id)
        {
            var result = c.Evaluations.Where(x => x.StudentID == id && x.Status == true).ToList();        
                return result;
        }

        public List<string> GetListStudentNameEvaluation(int id)
        {
            var result = evaluationDal.GetStudentNameEvaluation(id);
            return result;
        }

        public void UpdateEvaluation(Evaluation evaluation,int id)
        {
            evaluation.PriceGiveDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            evaluation.Status = true;
         //   evaluation.StudentID = id;
            evaluationDal.Update(evaluation);
        }
    }
}
