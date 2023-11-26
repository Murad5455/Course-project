using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherDal teacherDal;
            
        public TeacherManager(ITeacherDal _teacherDal)
        {
            teacherDal = _teacherDal;
        }

        public void AddTeacher(Teacher teacher)
        {
            teacherDal.Inser(teacher);
        }

        public void ChangeStatusTeacher(Teacher teacher)
        {
            teacher.Status = false;
          teacherDal.TUpdate(teacher);
        }

      

        public void DeleteTeacher(int id)
        {
            teacherDal.Delete(id);
        }

        public List<Teacher> GetAllIdTeacherList()
        {
           var result = teacherDal.GetAllIdTeacher();
            return result;
        }

        public Teacher GetByIdTeacher(int id)
        {
          return  teacherDal.GetById(id);
        }

        public List<Teacher> GetListAllTeacher()
        {
          return  teacherDal.GetListAll();
        }

        public void UpdateTeacher(Teacher teacher)
        {
           
            teacher.Status = true;
            teacherDal.Update(teacher); 
        }
    }
}
