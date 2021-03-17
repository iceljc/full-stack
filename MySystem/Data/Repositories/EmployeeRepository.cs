using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Data.Models;

namespace MySystem.Data.Repositories
{
    class EmployeeRepository : IRepository<Employee>
    {
        List<Employee> lstEmployeeCollection = new List<Employee>();
        public bool Delete(int id)
        {
            Employee e = GetById(id);
            if (e != null)
            {
                lstEmployeeCollection.Remove(e);
                return true;
            }

            return false;
        }

        public List<Employee> GetAll()
        {
            return lstEmployeeCollection;
        }

        public Employee GetById(int id)
        {
            int length = lstEmployeeCollection.Count;
            for (int i = 0; i < length; i++)
            {
                if (lstEmployeeCollection[i].Id == id)
                {
                    return lstEmployeeCollection[i];
                }
            }
            return null;
        }

        public void Insert(Employee item)
        {
            lstEmployeeCollection.Add(item);
        }

        public bool Update(Employee item)
        {
            Employee e = GetById(item.Id);
            if (e != null)
            {
                e.FirstName = item.FirstName;
                e.LastName = item.LastName;
                e.EmailId = item.EmailId;
                e.Age = item.Age;
                return true;
            }
            return false;
        }
    }
}
