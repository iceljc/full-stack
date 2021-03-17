using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Utility.Menus;
using MySystem.Utility.Menus.MenuOptions;
using MySystem.Utility.Exceptions;
using MySystem.Data.Models;
using MySystem.Data.Repositories;

namespace MySystem.UI
{
    class ManageEmployee
    {
        IRepository<Employee> employeeRepository;

        public ManageEmployee()
        {
            employeeRepository = new EmployeeRepository();
        }

        void PrintAllEmployee()
        {
            List<Employee> employeeCollection = employeeRepository.GetAll();
            int length = employeeCollection.Count;

            Console.WriteLine();
            Console.WriteLine("Id \t First Name \t Last Name \t Email \t Age");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(employeeCollection[i].Id + " \t " + employeeCollection[i].FirstName + " \t " + employeeCollection[i].LastName + " \t " + employeeCollection[i].EmailId + " \t " + employeeCollection[i].Age);
            }
        }

        void DeleteEmployee()
        {
            try
            {
                Console.Write("Enter Id => ");
                int id = Convert.ToInt32(Console.ReadLine());
                bool complete = employeeRepository.Delete(id);
                if (complete)
                {
                    Console.WriteLine("Employee deletion Successfully");
                }
                else
                {
                    Console.WriteLine("Cannot find the employee. Employee deletion Failed");
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

        void UpdateEmployee()
        {
            try
            {
                Employee employee = new Employee();

                Console.Write("Enter Id => ");
                employee.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter First Name => ");
                employee.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name => ");
                employee.LastName = Console.ReadLine();

                Console.Write("Enter Email => ");
                employee.EmailId = Console.ReadLine();

                Console.Write("Enter Age => ");
                employee.Age = Convert.ToInt32(Console.ReadLine());

                bool complete = employeeRepository.Update(employee);
                if (complete)
                {
                    Console.WriteLine("Employee Update Successfully.");
                } 
                else
                {
                    Console.WriteLine("Cannot find the employee. Employee Update Failed.");
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
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error has been occured. Contact the admin department");
            }
        }

        void InsertEmployee()
        {
            try
            {
                Employee employee = new Employee();
                Console.Write("Enter Id => ");
                employee.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter First Name => ");
                employee.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name => ");
                employee.LastName = Console.ReadLine();

                Console.Write("Enter Email => ");
                employee.EmailId = Console.ReadLine();

                Console.Write("Enter Age => ");
                employee.Age = Convert.ToInt32(Console.ReadLine());

                employeeRepository.Insert(employee);
                Console.WriteLine("Employee Updated successfully");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("value must be in between 1 to " + int.MaxValue);
            }
            catch (AgeException ae)
            {
                Console.WriteLine(ae.Message);
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

                IMenu employeeMenu = new EmployeeMenu();
                choice = employeeMenu.PrintMenu();
                switch (choice)
                {
                    case (int)EmployeeMenuOptions.Insert:
                        InsertEmployee();
                        break;
                    case (int)EmployeeMenuOptions.Delete:
                        DeleteEmployee();
                        break;
                    case (int)EmployeeMenuOptions.Print:
                        PrintAllEmployee();
                        break;
                    case (int)EmployeeMenuOptions.Update:
                        UpdateEmployee();
                        break;
                    case (int)EmployeeMenuOptions.Exit:
                        Console.WriteLine("Thanks for your visit. Please visit the Employee System again !!!!");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }

                if (choice != (int)EmployeeMenuOptions.Exit)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choice != (int)EmployeeMenuOptions.Exit);
        }
    }
}
