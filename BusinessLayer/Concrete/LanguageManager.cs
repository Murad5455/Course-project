using BusinessLayer.Abstract;
using CorseEntity.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LanguageManager : ILanguageSevice
    {

        private readonly ILanguageDal _languageDAl;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDAl = languageDal;
        }

        public void AddLanguage(LanguageAbout language)
        {
            language.CreateLanguageTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            language.Status = true;
            _languageDAl.Inser(language);
        }

        public void DeleteLanguage(int id)
        {
            var result = _languageDAl.GetById(id);
            result.Status = false;
            _languageDAl.TUpdate(result);
        }

        public List<LanguageAbout> GetAllIdLanguageList(int id)
        {
           return _languageDAl.GetAllIdLanguage(id);
        }

        public LanguageAbout GetByIdLanguage(int id)
        {
          return _languageDAl.GetById(id);
        }

        public List<LanguageAbout> GetListAllCheckStatusLanguage()
        {
            return _languageDAl.GetListAllCheckStatus();
        }

        public List<LanguageAbout> GetListAllLanguage()
        {
                return _languageDAl.GetListAll();
         
        }

        public void UpdateLanguage(LanguageAbout language)
        {
            language.CreateLanguageTime = DateTime.Parse(DateTime.Now.ToShortDateString());
            language.Status = true;
            _languageDAl.Update(language);
        }
    }
}
