using System;
using System.Collections.Generic;
using System.Text;

namespace MySystem.Data.Repositories
{
    interface IRepository<T> where T:class
    {
        void Insert(T item);
        bool Update(T item);
        T GetById(int id);

        List<T> GetAll();
        bool Delete(int id);
    }
}
