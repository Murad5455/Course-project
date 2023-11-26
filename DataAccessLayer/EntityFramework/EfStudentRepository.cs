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
    public class EfStudentRepository : GenericRepository<Student>, IStudentDal
    {
        public List<Student> GetAllIdStudent(int id)
        {
            using Context c =new Context();

            var result = c.Students.Where(x=>x.GroupId==id && x.Status==true).ToList();
            return result;
        }
    }
}
