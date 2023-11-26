using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfEvaluationRepository:GenericRepository<Evaluation>,IEvaluationDal
    {
        public List<Evaluation> GetAllIdEvaluation(int id)
        {
            using Context c = new Context();
            var result = c.Evaluations.Where(x => x.EvaluationId == id && x.Status ==true ).ToList();
            return result;
        }
        public List<string> GetStudentNameEvaluation(int id)
        {
            using Context c = new Context();
            var result1 = c.Students.Where(x => x.StudentID == id).Select(a => a.StudentName).ToList();
            return result1;
        }

    }
}
