using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEvaluationDal:IGenericDal<Evaluation>
    {
        public List<Evaluation> GetAllIdEvaluation(int id);
        
        public List<string> GetStudentNameEvaluation(int id);
    }
}
