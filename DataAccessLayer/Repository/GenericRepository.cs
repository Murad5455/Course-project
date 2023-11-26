using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(int id)
        {
           using Context c = new Context();

            c.Set<T>().Find(id);
            
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using Context c = new Context();
           return c.Set<T>().Find(id);
        }

        public T GetById(T t)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListAll()
        {
            
            using Context c = new Context();
           
          
            return c.Set<T>().ToList();
        }

        public void Inser(T t)
        {
            using Context c = new Context();
            c.Add(t);
            c.SaveChanges();

        }

        public void Update(T t)
        {
            using Context c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

        public void TUpdate(T t)
        {
            using Context c = new Context();
            c.Set<T>().Update(t);
            c.SaveChanges();
        }




    }
}
