using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEvaluationService
    {

        public void UpdateEvaluation(Evaluation evaluation,int id);

        public void AddEvaluation(Evaluation evaluation,int id);

        public void ChangeEvaluation(int id);

        public Evaluation GetByIdSEvaluation(int id);

        public List<Evaluation> GetAllIdEvaluationList(int id);

        public List<Evaluation> GetIdEvaluationList(int id);

        public List<SelectListItem> EvaluationChooseList();

        public List<string> GetListStudentNameEvaluation(int id);
    }
}
