using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IStudentDal:IGenericDal<Student>
    {
        public List<Student> GetAllIdStudent(int id);
      
    }
}
