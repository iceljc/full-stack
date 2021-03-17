using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Utility.Menus;
using MySystem.Utility.Menus.MenuOptions;
using MySystem.Data.Models;
using MySystem.Data.Repositories;

namespace MySystem.UI
{
    class ManageCustomer
    {
        IRepository<Customer> customerRepository;

        public ManageCustomer()
        {
            customerRepository = new CustomerRepository();
        }

        void PrintAllCustomer()
        {
            List<Customer> customerCollection = customerRepository.GetAll();
            int length = customerCollection.Count;

            Console.WriteLine();
            Console.WriteLine("Id \t First Name \t Last Name \t City \t Country");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(customerCollection[i].Id + " \t " + customerCollection[i].FirstName + " \t " + customerCollection[i].LastName + " \t " + customerCollection[i].City + " \t " + customerCollection[i].Country);
            }
        }

        void DeleteCustomer()
        {
            try
            {
                Console.Write("Enter Id => ");
                int id = Convert.ToInt32(Console.ReadLine());
                bool complete = customerRepository.Delete(id);
                if (complete)
                {
                    Console.WriteLine("Customer deletion Successfully");
                }
                else
                {
                    Console.WriteLine("Cannot find the customer. Customer deletion Failed");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("value must be in between 1 to " + int.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error has been occured. Contact the admin department");
            }


        }
        void UpdateCustomer()
        {
            try
            {
                Customer customer = new Customer();
                Console.Write("Enter Id => ");
                customer.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter First Name => ");
                customer.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name => ");
                customer.LastName = Console.ReadLine();

                Console.Write("Enter City => ");
                customer.City = Console.ReadLine();

                Console.Write("Enter Country => ");
                customer.Country = Console.ReadLine();

                bool complete = customerRepository.Update(customer);
                if (complete)
                {
                    Console.WriteLine("Customer Update Successfully");
                }
                else
                {
                    Console.WriteLine("Cannot find the customer. Customer Update Failed");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("value must be in between 1 to " + int.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error has been occured. Contact the admin department");
            }


        }

        void InsertCustomer()
        {
            try
            {
                Customer customer = new Customer();
                Console.Write("Enter Id => ");
                customer.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter First Name => ");
                customer.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name => ");
                customer.LastName = Console.ReadLine();

                Console.Write("Enter City => ");
                customer.City = Console.ReadLine();

                Console.Write("Enter Country => ");
                customer.Country = Console.ReadLine();

                customerRepository.Insert(customer);
                Console.WriteLine("Customer added successfully");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("value must be in between 1 to " + int.MaxValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error has been occured. Contact the admin department");
            }
        }

        public void Run()
        {
            int choice = 0;

            do
            {

                IMenu customerMenu = new DepartmentMenu();
                choice = customerMenu.PrintMenu();
                switch (choice)
                {
                    case (int)CustomerMenuOptions.Insert:
                        InsertCustomer();
                        break;
                    case (int)CustomerMenuOptions.Delete:
                        DeleteCustomer();
                        break;
                    case (int)CustomerMenuOptions.Print:
                        PrintAllCustomer();
                        break;
                    case (int)CustomerMenuOptions.Update:
                        UpdateCustomer();
                        break;
                    case (int)CustomerMenuOptions.Exit:
                        Console.WriteLine("Thanks for your visit. Please visit the Customer System again !!!!");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }

                if (choice != (int)CustomerMenuOptions.Exit)
                {
                    Console.WriteLine("Press Enter to continue.......");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choice != (int)CustomerMenuOptions.Exit);
        }
    }
}
