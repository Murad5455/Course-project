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
    public class EfLanguageRepository:GenericRepository<LanguageAbout>,ILanguageDal
    {
        public List<LanguageAbout> GetAllIdLanguage(int id)
        {
            using Context c = new Context();

            var result = c.LanguageAbout.Where(x => x.LanguageAboutId == id && x.Status == true).ToList();
            return result;
        }

        public List<LanguageAbout> GetListAllCheckStatus()
        {
            using Context c = new Context();
            var result = c.LanguageAbout.Where(x => x.Status == true).ToList();
            return result;
        }
    }
}
