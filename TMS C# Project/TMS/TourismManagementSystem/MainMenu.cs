using System;
using TourismManagementSystem.Admin;
using TourismManagementSystem.Customer;

namespace TourismManagementSystem;

// The main menu (the first screen of main() in the C++ version). It only decides which side opens:
// the Admin folder or the Customer folder.
public class MainMenu
{
    private readonly AdminUI _adminUI;
    private readonly CustomerUI _customerUI;

    public MainMenu()
    {
        _adminUI = new AdminUI();
        _customerUI = new CustomerUI();
    }

   
    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;   

        bool keepRunning = true;
        while (keepRunning)
        {
            Header();
            Console.WriteLine("~ User Menu ~");
            Console.WriteLine("1- Admin");
            Console.WriteLine("2- Tourist");
            Console.WriteLine("3- Exit");
            Console.Write("Choose option: ");
            string userOption = ConsoleHelper.ReadText();

            if (userOption == "1")
            {
                _adminUI.ShowAdminLogin();
            }
            else if (userOption == "2")
            {
                _customerUI.ShowTouristPortal();
            }
            else if (userOption == "3")
            {
                keepRunning = false;
            }
            else
            {
                Console.WriteLine("Wrong Option.");
                ConsoleHelper.WaitForKey();
            }
        }
        Console.WriteLine("Thanks for visiting TMS");
    }

    // Clears the screen and prints the banner (header() of the C++ version).
    private void Header()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("================================================================");
        Console.WriteLine("||                THE ADVENTURER'S COMPASS                    ||");
        Console.WriteLine("||          - Life is  all  about  the adventures -           ||");
        Console.WriteLine("================================================================");
    }
}
