using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Data.Models;

namespace MySystem.Data.Repositories
{
    class CustomerRepository : IRepository<Customer>
    {
        List<Customer> lstCustomerCollection = new List<Customer>();
        public bool Delete(int id)
        {
            Customer c = GetById(id);
            if (c != null)
            {
                lstCustomerCollection.Remove(c);
                return true;
            }
            return false;
        }

        public List<Customer> GetAll()
        {
            return lstCustomerCollection;
        }

        public Customer GetById(int id)
        {
            int length = lstCustomerCollection.Count;
            for (int i = 0; i < length; i++)
            {
                if (lstCustomerCollection[i].Id == id)
                {
                    return lstCustomerCollection[i];
                }
            }
            return null;
        }

        public void Insert(Customer item)
        {
            lstCustomerCollection.Add(item);
        }

        public bool Update(Customer item)
        {
            Customer c = GetById(item.Id);
            if (c != null)
            {
                c.FirstName = item.FirstName;
                c.LastName = item.LastName;
                c.City = item.City;
                c.Country = item.Country;
                return true;
            }
            return false;
        }
    }
}
