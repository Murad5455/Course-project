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
    public class EfTeacherRepository : GenericRepository<Teacher>, ITeacherDal
    {
        public List<Teacher> GetAllIdTeacher()
        {
            Context c = new Context();
            var result = c.Teachers.Where(x => x.Status == true).ToList();
            return result;
        }
    }
}
