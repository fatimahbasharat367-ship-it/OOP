using System.Collections.Generic;

namespace TourismManagementSystem.Customer;
public class CustomerService
{
    private readonly TouristRepository _touristRepository;
    private readonly PackageRepository _packageRepository;
    private string _lastError;   // the reason the last BookTrip failed

    public CustomerService()
    {
        _touristRepository = new TouristRepository();
        _packageRepository = new PackageRepository();
        _lastError = "";
    }

    public string getLastError()
    {
        return _lastError;
    }

    public List<Package> GetPackages()
    {
        return _packageRepository.GetAll();
    }

    public Package FindPackage(string spot)
    {
        List<Package> packages = _packageRepository.GetAll();
        for (int i = 0; i < packages.Count; i++)
        {
            if (packages[i].getSpot() == spot)
            {
                return packages[i];
            }
        }
        return null;
    }

    public Tourist BookTrip(string name, int age, string spotName, int persons)
    {
        _lastError = "";
        Package package = FindPackage(spotName);
        if (package == null)
        {
            _lastError = "Spot not available.";
            return null;
        }

        Tourist tourist = new Tourist();
        if (!tourist.setName(name))
        {
            _lastError = "The name must have 1 to 30 characters and must not contain '|'.";
            return null;
        }
        if (!tourist.setAge(age))
        {
            _lastError = "The age must be between 1 and 120.";
            return null;
        }
        if (!tourist.setPersons(persons))
        {
            _lastError = "At least one person must join the trip.";
            return null;
        }
        tourist.setSpot(package.getSpot());
        tourist.setPrice(package.getPrice() * persons);
        tourist.setDuration(package.getDuration());
        tourist.setRating(package.getRating());

        List<Tourist> tourists = _touristRepository.GetAll();
        tourists.Add(tourist);
        _touristRepository.SaveAll(tourists);
        return tourist;
    }
}
