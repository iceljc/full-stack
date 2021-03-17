using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Utility.Menus;
using MySystem.Utility.Menus.MenuOptions;
using MySystem.Data.Models;
using MySystem.Data.Repositories;

namespace MySystem.UI
{
    class ManageDepartment
    {
        IRepository<Department> departmentRepository;
        public ManageDepartment()
        {
            departmentRepository = new DepartmentRepository();
        }
        void PrintAllDepartment()
        {
            List<Department> deptCollection = departmentRepository.GetAll();
            int length = deptCollection.Count;

            Console.WriteLine();
            Console.WriteLine("Id \t Department Name \t Location");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(deptCollection[i].Id +" \t "+deptCollection[i].DepartmentName+" \t "+deptCollection[i].Location);
            }
        }

        void DeleteDepartment()
        {
            try
            {
                Console.Write("Enter Id => ");
                int id = Convert.ToInt32(Console.ReadLine());
                bool complete = departmentRepository.Delete(id);
                if (complete)
                {
                    Console.WriteLine("Department deletion Successfully");
                }
                else
                {
                    Console.WriteLine("Cannot find the department. Department deletion Failed");
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
        void UpdateDepartment()
        {
            try
            {
                Department department = new Department();
                Console.Write("Enter Id => ");
                department.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name => ");
                department.DepartmentName = Console.ReadLine();

                Console.Write("Enter Location => ");
                department.Location = Console.ReadLine();

                bool complete = departmentRepository.Update(department);
                if (complete)
                {
                    Console.WriteLine("Department Update Successfully");
                }
                else
                {
                    Console.WriteLine("Cannot find the department. Department Update Failed");
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

        void InsertDepartment()
        {
            try
            {
                Department department = new Department();
                Console.Write("Enter Id => ");
                department.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name => ");
                department.DepartmentName = Console.ReadLine();

                Console.Write("Enter Location => ");
                department.Location = Console.ReadLine();

                departmentRepository.Insert(department);
                Console.WriteLine("Department added successfully");
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

                IMenu departmentMenu = new DepartmentMenu();
                choice = departmentMenu.PrintMenu();
                switch (choice)
                {
                    case (int)DepartmentMenuOptions.Insert:
                        InsertDepartment();
                        break;
                    case (int)DepartmentMenuOptions.Delete:
                        DeleteDepartment();
                        break;
                    case (int)DepartmentMenuOptions.Print:
                        PrintAllDepartment();
                        break;
                    case (int)DepartmentMenuOptions.Update:
                        UpdateDepartment();
                        break;
                    case (int)DepartmentMenuOptions.Exit:
                        Console.WriteLine("Thanks for your visit. Please visit the Department System again !!!!");
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }

                if (choice != (int)DepartmentMenuOptions.Exit)
                {
                    Console.WriteLine("Press Enter to continue.......");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choice != (int)DepartmentMenuOptions.Exit);
        }
    }
}
