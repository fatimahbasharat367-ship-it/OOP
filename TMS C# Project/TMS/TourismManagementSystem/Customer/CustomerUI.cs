using System;
using System.Collections.Generic;

namespace TourismManagementSystem.Customer;

public class CustomerUI
{
    private readonly CustomerService _customerService;

    public CustomerUI()
    {
        _customerService = new CustomerService();
    }
    public void ShowTouristPortal()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Tourist Portal");

        Console.Write("Enter your name: ");
        string name = ConsoleHelper.ReadText();
        int age = ConsoleHelper.ReadNumber("Enter your age: ");
        Console.WriteLine();

        Console.WriteLine("------ Available Spots ------");
        List<Package> packages = _customerService.GetPackages();
        for (int i = 0; i < packages.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + packages[i].getSpot() + " (Rs." + packages[i].getPrice()
                + ") Rating: " + packages[i].getRating() + "/5");
        }

        Console.Write("Enter spot name from list: ");
        string spot = ConsoleHelper.ReadText();

        Package package = _customerService.FindPackage(spot);
        if (package == null)
        {
            Console.WriteLine("Spot not available.");
        }
        else
        {
            int persons = ConsoleHelper.ReadNumber("How many individuals are joining you in this trip ? ");

            Tourist tourist = _customerService.BookTrip(name, age, spot, persons);
            if (tourist == null)
            {
                Console.WriteLine("Booking failed: " + _customerService.getLastError());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Booking Successful!");
                Console.WriteLine("------------ Receipt ------------");
                Console.WriteLine("Name: " + tourist.getName());
                Console.WriteLine("Destination: " + tourist.getSpot());
                Console.WriteLine("Persons: " + tourist.getPersons());
                Console.WriteLine("Duration: " + tourist.getDuration());
                Console.WriteLine("Total Bill: Rs." + tourist.getPrice());
                Console.WriteLine("Activity: " + package.getActivity());
                Console.WriteLine("---------------------------------");
            }
        }
        ConsoleHelper.WaitForKey();
    }
}
