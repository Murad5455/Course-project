using CorseEntity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILanguageSevice
    {
        public List<LanguageAbout> GetListAllLanguage();

        public LanguageAbout GetByIdLanguage(int id);

        public void DeleteLanguage(int id);

        public void AddLanguage(LanguageAbout language);

        public void UpdateLanguage(LanguageAbout language);

        public List<LanguageAbout> GetAllIdLanguageList(int id);
      
        public List<LanguageAbout> GetListAllCheckStatusLanguage();


    }
}
