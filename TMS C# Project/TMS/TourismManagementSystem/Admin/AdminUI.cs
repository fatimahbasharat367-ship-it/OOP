using System;
using System.Collections.Generic;
using TourismManagementSystem.Customer;

namespace TourismManagementSystem.Admin;

public class AdminUI
{
    private readonly AdminService _adminService;

    public AdminUI()
    {
        _adminService = new AdminService();
    }
    public void ShowAdminLogin()
    {
        int countAttempt = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.Clear();
            Console.WriteLine("------ Admin Login ------");
            Console.WriteLine("Login Attempt : " + (i + 1));

            Console.Write("Enter username: ");
            string username = ConsoleHelper.ReadText();
            Console.Write("Enter password: ");
            string password = ConsoleHelper.ReadText();

            if (_adminService.AdminLogin(username, password))
            {
                AdminMenuUI();
                break;
            }
            else
            {
                Console.WriteLine("Invalid Username or Password.");
                countAttempt++;
                if (countAttempt == 3)
                {
                    Console.WriteLine("Maximum Attempts Reached.");
                }
                ConsoleHelper.WaitForKey();
            }
        }
    }
    private void AdminMenuUI()
    {
        bool keepRunning = true;
        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("------ Admin Menu ------");
            Console.WriteLine("1- Show Tourists");
            Console.WriteLine("2- View Bookings");
            Console.WriteLine("3- View Packages");
            Console.WriteLine("4- Search Tourist");
            Console.WriteLine("5- Update Tourist");
            Console.WriteLine("6- Delete Tourist");
            Console.WriteLine("7- Sort By Rating");
            Console.WriteLine("8- Logout");
            Console.Write("Choose option: ");
            string adminOption = ConsoleHelper.ReadText();

            if (adminOption == "8")
            {
                keepRunning = false;
            }
            else
            {
                if (adminOption == "1")
                {
                    ShowTouristsUI();
                }
                else if (adminOption == "2")
                {
                    ShowBookingsUI();
                }
                else if (adminOption == "3")
                {
                    ShowPackagesUI();
                }
                else if (adminOption == "4")
                {
                    SearchTouristUI();
                }
                else if (adminOption == "5")
                {
                    UpdateTouristUI();
                }
                else if (adminOption == "6")
                {
                    DeleteTouristUI();
                }
                else if (adminOption == "7")
                {
                    SortRatingUI();
                }
                else
                {
                    Console.WriteLine("Wrong Option.");
                }
                ConsoleHelper.WaitForKey();
            }
        }
    }

    private void ShowTouristsUI()
    {
        List<Tourist> tourists = _adminService.GetTourists();
        Console.WriteLine("Name\tAge\tSpot");
        foreach (Tourist tourist in tourists)
        {
            Console.WriteLine(tourist.getName() + "\t" + tourist.getAge() + "\t" + tourist.getSpot());
        }
    }

    private void ShowBookingsUI()
    {
        List<Tourist> tourists = _adminService.GetTourists();
        Console.WriteLine("Name\tAge\tSpot\tPrice\tPersons\tDuration");
        foreach (Tourist tourist in tourists)
        {
            Console.WriteLine(tourist.getName() + "\t" + tourist.getAge() + "\t" + tourist.getSpot() + "\t"
                + tourist.getPrice() + "\t" + tourist.getPersons() + "\t" + tourist.getDuration());
        }
    }

    private void ShowPackagesUI()
    {
        List<Package> packages = _adminService.GetPackages();
        Console.WriteLine("Spot\tPrice\tDuration\tRating");
        foreach (Package package in packages)
        {
            Console.WriteLine(package.getSpot() + "\t" + package.getPrice() + "\t"
                + package.getDuration() + "\t" + package.getRating() + "/5");
        }
    }

    private void SearchTouristUI()
    {
        Console.Write("Enter name to search: ");
        string name = ConsoleHelper.ReadText();

        Tourist tourist = _adminService.SearchTourist(name);
        if (tourist == null)
        {
            Console.WriteLine("Record not found.");
        }
        else
        {
            Console.WriteLine("Name\tAge\tSpot\tPrice\tDuration");
            Console.WriteLine(tourist.getName() + "\t" + tourist.getAge() + "\t" + tourist.getSpot()
                + "\t" + tourist.getPrice() + "\t" + tourist.getDuration());
        }
    }

    private void UpdateTouristUI()
    {
        Console.Write("Enter name to update: ");
        string name = ConsoleHelper.ReadText();

        if (_adminService.SearchTourist(name) == null)
        {
            Console.WriteLine("Record not found.");
            return;
        }

        Console.Write("Enter new name: ");
        string newName = ConsoleHelper.ReadText();
        int newAge = ConsoleHelper.ReadNumber("Enter new age: ");
        Console.Write("Enter new spot: ");
        string newSpot = ConsoleHelper.ReadText();
        int newPrice = ConsoleHelper.ReadNumber("Enter new price: ");
        Console.Write("Enter new duration: ");
        string newDuration = ConsoleHelper.ReadText();

        string error = _adminService.UpdateTourist(name, newName, newAge, newSpot, newPrice, newDuration);
        if (error == "")
        {
            Console.WriteLine("Record Updated Successfully.");
        }
        else
        {
            Console.WriteLine("Error: " + error);
        }
    }

    private void DeleteTouristUI()
    {
        Console.Write("Enter the name you want to delete: ");
        string name = ConsoleHelper.ReadText();

        if (_adminService.DeleteTourist(name))
        {
            Console.WriteLine("Record Deleted Successfully.");
        }
        else
        {
            Console.WriteLine("Record not found.");
        }
    }

    private void SortRatingUI()
    {
        List<Tourist> tourists = _adminService.SortByRating();
        Console.WriteLine("Sorted By Rating");
        Console.WriteLine("Name\tRating\tSpot\tPrice");
        foreach (Tourist tourist in tourists)
        {
            Console.WriteLine(tourist.getName() + "\t" + tourist.getRating() + "\t" + tourist.getSpot() + "\t" + tourist.getPrice());
        }
    }
}
