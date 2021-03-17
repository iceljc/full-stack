using System;
using System.Collections.Generic;
using System.Text;
using MySystem.Utility.Menus;
using MySystem.Utility.Menus.MenuOptions;

namespace MySystem.UI
{
    class Dashboard
    {
        public virtual void ShowDashboard()
        {
            int choice = 0;
            Dashboard dashboard;
            IMenu mainMenu = new MainMenu();

            do
            {
                choice = mainMenu.PrintMenu();

                switch (choice)
                {
                    case (int)TopMenuOptions.DepartmentSystem:
                        Console.Clear();
                        dashboard = new DepartmentDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)TopMenuOptions.EmployeeSystem:
                        Console.Clear();
                        dashboard = new EmployeeDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)TopMenuOptions.CustomerSystem:
                        Console.Clear();
                        dashboard = new CustomerDashboard();
                        dashboard.ShowDashboard();
                        break;
                    case (int)TopMenuOptions.Exit:
                        Console.WriteLine("Thanks for your visit. Please visit again !!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        break;
                }

                if (choice != (int)TopMenuOptions.Exit)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (choice != (int)TopMenuOptions.Exit);
        }

        
    }

    class DepartmentDashboard : Dashboard
    {
        public override void ShowDashboard()
        {
            ManageDepartment manageDepartment = new ManageDepartment();
            manageDepartment.Run();
        }
    }

    class EmployeeDashboard : Dashboard
    {
        public override void ShowDashboard()
        {
            ManageEmployee manageEmployee = new ManageEmployee();
            manageEmployee.Run();
        }
    }

    class CustomerDashboard : Dashboard
    {
        public override void ShowDashboard()
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.Run();
        }
    }
}
