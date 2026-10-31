using System.Collections.Generic;
using TourismManagementSystem.Customer;

namespace TourismManagementSystem.Admin;

public class AdminService
{
    private readonly AdminRepository _adminRepository;
    private readonly TouristRepository _touristRepository;
    private readonly PackageRepository _packageRepository;

    public AdminService()
    {
        _adminRepository = new AdminRepository();
        _touristRepository = new TouristRepository();
        _packageRepository = new PackageRepository();
    }

    // true = the username and the password are both right.
    public bool AdminLogin(string username, string password)
    {
        AdminAccount admin = _adminRepository.GetAdmin();
        return admin.checkLogin(username, password);
    }

    // All tourists in the saved order.
    public List<Tourist> GetTourists()
    {
        return _touristRepository.GetAll();
    }

    // The five fixed packages.
    public List<Package> GetPackages()
    {
        return _packageRepository.GetAll();
    }

    // Finds the first tourist with exactly this name, or null.
    public Tourist SearchTourist(string name)
    {
        List<Tourist> tourists = _touristRepository.GetAll();
        return FindTourist(tourists, name);
    }
    public string UpdateTourist(string oldName, string newName, int newAge, string newSpot, int newPrice, string newDuration)
    {
        List<Tourist> tourists = _touristRepository.GetAll();
        Tourist tourist = FindTourist(tourists, oldName);
        if (tourist == null)
        {
            return "Record not found.";
        }

        // First check all new values on a temporary tourist, so a bad value cannot leave a half-changed record.
        Tourist check = new Tourist();
        if (!check.setName(newName))
        {
            return "The name must have 1 to 30 characters and must not contain '|'.";
        }
        if (!check.setAge(newAge))
        {
            return "The age must be between 1 and 120.";
        }
        if (!check.setSpot(newSpot))
        {
            return "The spot must have 1 to 30 characters and must not contain '|'.";
        }
        if (!check.setPrice(newPrice))
        {
            return "The price cannot be negative.";
        }
        if (!check.setDuration(newDuration))
        {
            return "The duration must have 1 to 30 characters and must not contain '|'.";
        }

        tourist.setName(newName);
        tourist.setAge(newAge);
        tourist.setSpot(newSpot);
        tourist.setPrice(newPrice);
        tourist.setDuration(newDuration);
        _touristRepository.SaveAll(tourists);
        return "";
    }

    // Deletes the first tourist with this name and saves. Returns false when nobody has this name.
    public bool DeleteTourist(string name)
    {
        List<Tourist> tourists = _touristRepository.GetAll();
        Tourist tourist = FindTourist(tourists, name);
        if (tourist == null)
        {
            return false;
        }
        tourists.Remove(tourist);
        _touristRepository.SaveAll(tourists);
        return true;
    }
    public List<Tourist> SortByRating()
    {
        List<Tourist> tourists = _touristRepository.GetAll();
        for (int i = 0; i < tourists.Count - 1; i++)
        {
            for (int j = 0; j < tourists.Count - i - 1; j++)
            {
                if (tourists[j].getRating() < tourists[j + 1].getRating())
                {
                    Tourist temp = tourists[j];
                    tourists[j] = tourists[j + 1];
                    tourists[j + 1] = temp;
                }
            }
        }
        _touristRepository.SaveAll(tourists);
        return tourists;
    }

    private Tourist FindTourist(List<Tourist> tourists, string name)
    {
        for (int i = 0; i < tourists.Count; i++)
        {
            if (tourists[i].getName() == name)
            {
                return tourists[i];
            }
        }
        return null;
    }
}
