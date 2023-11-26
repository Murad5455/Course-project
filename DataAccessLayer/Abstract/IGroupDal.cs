using CorseEntity.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGroupDal:IGenericDal<GroupAbout>
    {
        public List<GroupAbout>GetAllIdGroup(int id);
        
    }
}
