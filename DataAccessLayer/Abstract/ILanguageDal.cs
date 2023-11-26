using CorseEntity.Concrete;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ILanguageDal:IGenericDal<LanguageAbout>
    {
        public List<LanguageAbout> GetAllIdLanguage(int id);

        public List<LanguageAbout> GetListAllCheckStatus();
    }
}
