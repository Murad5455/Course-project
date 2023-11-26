using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IExamDal:IGenericDal<Exam>
    {
        public List<Exam> GetAllIdExam(int id);
        public List<string> GetStudentNameExam(int id);
    }
}
