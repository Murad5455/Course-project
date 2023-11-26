using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface IStudentService
    {
        public List<Student> GetListAllStudent();

        public Student GetByIdStudent(int id);
        
        public void DeleteStudent(int id);

        public void UpdateStudent(Student student);

        public void AddStudent(Student student);

        public void ChangeStatus(Student student);

        public List<Student> GetAllIdStudentList(int id);

        public List<SelectListItem> StudentChooseList();
    }
}
