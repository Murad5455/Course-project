using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal) 
        {
            _studentDal = studentDal;
        } 

        public void AddStudent(Student student)
        {
            student.CreateStudentTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            student.Status = true;
            _studentDal.Inser(student);
        }

        public void ChangeStatus(Student student)
        {
            student.Status=false;
           _studentDal.TUpdate(student);
        }

        public void DeleteStudent(int id)
        {
            _studentDal.Delete(id);
        }

        public List<Student> GetAllIdStudentList(int id)
        {
         return _studentDal.GetAllIdStudent(id);
        }

        public Student GetByIdStudent(int id)
        {
          return _studentDal.GetById(id);
        }

        public List<Student> GetListAllStudent()
        {
           
           return _studentDal.GetListAll();
        }

        public List<SelectListItem> StudentChooseList()
        {
            GroupManager Lm = new GroupManager(new EfGroupRepository());
            List<SelectListItem> Values = (from x in Lm.GetListAllGroup()
                                           select new SelectListItem
                                           {
                                               Text = x.GroupName,
                                               Value = x.GroupId.ToString()
                                           }).ToList();

            return Values;
        }

        public void UpdateStudent(Student student)
        {
            student.Status = true;
            student.CreateStudentTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            _studentDal.Update(student);
        }
    }
}
