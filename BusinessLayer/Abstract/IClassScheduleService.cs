using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IClassScheduleService
    {

        public Schedule GetByIdSchedule(int id);

        public void DeleteSchedule(int id);

        public void UpdateSchedule(Schedule schedule);

        public void AddSchedule(Schedule schedule);

        public List<SelectListItem> ScheduleChooseList();
    }
}
