using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Data.Models;

namespace MySystem.Data.Repositories
{
    class DepartmentRepository : IRepository<Department>
    {
        List<Department> lstDepartmentCollection = new List<Department>();
        public bool Delete(int id)
        {
            Department d = GetById(id);
            if (d != null)
            {
                lstDepartmentCollection.Remove(d);
                return true;
            }
            return false;
        }

        public List<Department> GetAll()
        {
            return lstDepartmentCollection;
        }

        public Department GetById(int id)
        {
            int length = lstDepartmentCollection.Count;
            for (int i = 0; i < length; i++)
            {
                if (lstDepartmentCollection[i].Id == id)
                    return lstDepartmentCollection[i];
            }
            return null;
        }

        public void Insert(Department item)
        {
            lstDepartmentCollection.Add(item);
        }

        public bool Update(Department item)
        {
           Department d = GetById(item.Id);
            if (d != null)
            {
                d.DepartmentName = item.DepartmentName;
                d.Location = item.Location;
                return true;
            }
            return false;
        }
    }
}
