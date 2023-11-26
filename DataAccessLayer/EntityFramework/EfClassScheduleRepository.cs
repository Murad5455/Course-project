using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfClassScheduleRepository : GenericRepository<Schedule>, IClassScheduleDal
    {
        Context c = new Context();
        public List<Schedule> GetAllIdSchedule(int id)
        {
            var result = c.Schedules.Where(x => x.GroupId == id && x.Status == true).ToList();
          return result;
        }
    }
}
