using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfGroupRepository : GenericRepository<GroupAbout>, IGroupDal
    {
      /*  private readonly Context _context;

        public EfGroupRepository(Context context)
        {
            _context = context;
        }*/


        /* public List<GroupAbout> GetAllIdGroup(int id)
         {
            *//* using Context c = new Context();
             var result1 = c.GroupsAbout.Where(x => x.LanguageAboutId == id && x.Status ==true).ToList();
             return result1;*//*
         }*/


        public List<GroupAbout> GetAllIdGroup(int id)
        {
            using Context _context = new Context();
               var result1 = _context.GroupAbouts.Where(x => x.LanguageAboutId == id && x.Status == true).ToList();
            return result1; 
        }
    }
}
