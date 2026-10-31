using System.Collections.Generic;
using System.IO;

namespace TourismManagementSystem.Customer;

public class TouristRepository
{
    private readonly string _filePath = "data.txt";

    public void SaveAll(List<Tourist> tourists)
    {
        using (StreamWriter writer = new StreamWriter(_filePath, false))
        {
            foreach (Tourist tourist in tourists)
            {
                writer.WriteLine(tourist.ToString());
            }
        }
    }

    public List<Tourist> GetAll()
    {
        if (!File.Exists(_filePath))
        {
            return Tourist.getDefaultTourists();
        }

        List<Tourist> tourists = new List<Tourist>();
        string[] lines = File.ReadAllLines(_filePath);
        foreach (string line in lines)
        {
            if (line.Trim().Length == 0)
            {
                continue;
            }
            string[] parts = line.Split('|');
            if (parts.Length != 7)
            {
                continue;
            }
            Tourist tourist = new Tourist(parts[0], int.Parse(parts[1]), parts[2], int.Parse(parts[3]),
                int.Parse(parts[4]), parts[5], int.Parse(parts[6]));
            tourists.Add(tourist);
        }
        return tourists;
    }
}
