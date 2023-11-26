using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITeacherService
    {
        public List<Teacher> GetListAllTeacher();

        public Teacher GetByIdTeacher(int id);

        public void DeleteTeacher(int id);

        public void UpdateTeacher(Teacher teacher);

        public void AddTeacher(Teacher teacher);

        public void ChangeStatusTeacher(Teacher teacher);

        public List<Teacher> GetAllIdTeacherList();

    }
}
