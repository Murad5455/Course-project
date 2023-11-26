using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ClassScheduleManager : IClassScheduleService
    {
        private readonly IClassScheduleDal classScheduleDal;

        public ClassScheduleManager(IClassScheduleDal _classScheduleDal)
        {
            classScheduleDal = _classScheduleDal;
        }

        public void AddSchedule(Schedule schedule)
        {
            schedule.CreateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            schedule.Status = true;
            classScheduleDal.Inser(schedule);
           
        }

      
        public void DeleteSchedule(int id)
        {
            var result = classScheduleDal.GetById(id);
            result.Status = false;
            classScheduleDal.TUpdate(result);
        }

        public void UpdateSchedule(Schedule schedule)
        {
            schedule.CreateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            schedule.Status = true;
            classScheduleDal.Update(schedule);        
        }

        public List<Schedule> GetAllIdScheduleList(int id)
        {
            var result = classScheduleDal.GetAllIdSchedule(id);
            return result; 
        }

        public Schedule GetByIdSchedule(int id)
        {
          var result = classScheduleDal.GetById(id);
            return result;
        }

        public List<SelectListItem> ScheduleChooseList()
        {
          GroupManager Gm = new GroupManager(new EfGroupRepository());
            List<SelectListItem> StudentValues = (from x in Gm.GetListAllGroup()
                                                select new SelectListItem
                                                {
                                                    Text = x.GroupName,
                                                    Value = x.GroupId.ToString()
                                                }).ToList();

            return StudentValues;
        }
    }
}
