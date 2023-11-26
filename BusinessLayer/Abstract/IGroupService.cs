using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGroupService
    {

        public List<GroupAbout> GetListAllGroup();

        public GroupAbout GetByIdGroup(int id);

        public void DeleteGroup(int id);

        public void UpdateGroup(GroupAbout group);

        public void AddGroup(GroupAbout group);

        public void ChangeGroup(GroupAbout group);

        public List<GroupAbout> GetAllIdGroupList(int id);

        public List<SelectListItem> GroupChooseList();
       
        public List<SelectListItem> TeacherChooseList();
    }
}
