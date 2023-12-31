﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Inser(T t);

        void Delete(int id);

        void Update(T t);

        List<T> GetListAll();

        T GetById(int id);

        void TUpdate(T t);
    }


}
