using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Concurrent;
using DataAccessLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class GroupManager : IGroupService
    {
        private readonly IGroupDal _groupDal;

        public GroupManager(IGroupDal groupDal)
        {
          _groupDal = groupDal;
        }

        public void AddGroup(GroupAbout group)
        {
            group.CreateTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            group.Status = true;
            _groupDal.Inser(group);
        }

        public void ChangeGroup(GroupAbout group)
        {
            group.Status = false;
            _groupDal.TUpdate(group);
        }

        public void DeleteGroup(int id)
        {
            _groupDal.Delete(id);
        }

        public List<GroupAbout> GetAllIdGroupList(int id)
        {
          return _groupDal.GetAllIdGroup(id);
        }

        public GroupAbout GetByIdGroup(int id)
        {
           return _groupDal.GetById(id);
        }

        public List<GroupAbout> GetListAllGroup()
        {
           return _groupDal.GetListAll();
        }

        public List<SelectListItem> GroupChooseList()
        {

            LanguageManager Lm = new LanguageManager(new EfLanguageRepository());
            List<SelectListItem> GroupValues = (from x in Lm.GetListAllLanguage()
                                                select new SelectListItem
                                                {
                                                    Text = x.LanguageName,
                                                    Value = x.LanguageAboutId.ToString()
                                                }).ToList();

            return GroupValues;
        }

        public List<SelectListItem> TeacherChooseList()
        {

            TeacherManager Lm = new TeacherManager(new EfTeacherRepository());
            List<SelectListItem> TeacherValues = (from x in Lm.GetListAllTeacher()
                                                select new SelectListItem
                                                {   
                                                    Text = x.TeacherName,
                                                    Value = x.TeacherId.ToString()
                                                }).ToList();

            return TeacherValues;
        }

        public void UpdateGroup(GroupAbout group)
        {
            group.CreateTime= DateTime.Parse(DateTime.Now.ToShortDateString());
            group.Status = true;
            _groupDal.Update(group);
/*
            using (var dbContext = new Context())
            {
                var names = dbContext.Students
                                    .Where(student => student.GroupId == id)
                                    .Select(student => student.StudentName)
                                    .ToList();
            }*/
        }
}}
