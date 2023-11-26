using CorseEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IClassScheduleDal : IGenericDal<Schedule>
    {
        public List<Schedule> GetAllIdSchedule(int id);
    }
}
