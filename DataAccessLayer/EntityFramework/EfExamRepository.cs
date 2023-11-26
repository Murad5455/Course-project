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
    public class EfExamRepository : GenericRepository<Exam>, IExamDal
    {
        public List<Exam> GetAllIdExam(int id)
        {
            using Context c = new Context();
            var result = c.Exams.Where(x => x.StudentID == id && x.Status == true).ToList();
            return result.ToList();
            }

        public List<string> GetStudentNameExam(int id)
        {
            using Context c = new Context();
            var result1 = c.Students.Where(x=>x.StudentID==id).Select(a=>a.StudentName).ToList();
            return result1;
        }
    }
    }
