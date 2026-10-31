using System.Collections.Generic;

namespace TourismManagementSystem.Customer;

public class Tourist
{

    private string name;
    private int age;
    private string spot;
    private int price;       
    private int persons;
    private string duration;
    private int rating;

    public Tourist()
    {
        name = "";
        age = 0;
        spot = "";
        price = 0;
        persons = 0;
        duration = "";
        rating = 0;
    }

    public Tourist(string name, int age, string spot, int price, int persons, string duration, int rating)
    {
        this.name = name;
        this.age = age;
        this.spot = spot;
        this.price = price;
        this.persons = persons;
        this.duration = duration;
        this.rating = rating;
    }


    public static List<Tourist> getDefaultTourists()
    {
        List<Tourist> list = new List<Tourist>();
        list.Add(new Tourist("Ayesha", 25, "Chitral", 15000, 3, "4days", 5));
        list.Add(new Tourist("Fatimah", 27, "Hunza", 20000, 5, "5days", 4));
        list.Add(new Tourist("Dua", 19, "Kartarpur", 12000, 2, "2days", 3));
        list.Add(new Tourist("Alishba", 23, "Sawat", 10000, 1, "3days", 4));
        list.Add(new Tourist("Zainab", 32, "Kashmir", 17000, 4, "7days", 5));
        return list;
    }

    public static bool isValidText(string text, int maxLength)
    {
        if (text == null)
        {
            return false;
        }
        string cleaned = text.Trim();
        if (cleaned.Length < 1 || cleaned.Length > maxLength)
        {
            return false;
        }
        if (cleaned.Contains("|"))
        {
            return false;
        }
        return true;
    }

    public string getName()
    {
        return name;
    }
    public bool setName(string name)
    {
        if (!isValidText(name, 30))
        {
            return false;
        }
        this.name = name.Trim();
        return true;
    }

    public int getAge()
    {
        return age;
    }

    public bool setAge(int age)
    {
        if (age < 1 || age > 120)
        {
            return false;
        }
        this.age = age;
        return true;
    }

    public string getSpot()
    {
        return spot;
    }

    public bool setSpot(string spot)
    {
        if (!isValidText(spot, 30))
        {
            return false;
        }
        this.spot = spot.Trim();
        return true;
    }

    public int getPrice()
    {
        return price;
    }

    public bool setPrice(int price)
    {
        if (price < 0)
        {
            return false;
        }
        this.price = price;
        return true;
    }

    public int getPersons()
    {
        return persons;
    }
    public bool setPersons(int persons)
    {
        if (persons < 1)
        {
            return false;
        }
        this.persons = persons;
        return true;
    }

    public string getDuration()
    {
        return duration;
    }

    public bool setDuration(string duration)
    {
        if (!isValidText(duration, 30))
        {
            return false;
        }
        this.duration = duration.Trim();
        return true;
    }

    public int getRating()
    {
        return rating;
    }

    public bool setRating(int rating)
    {
        if (rating < 1 || rating > 5)
        {
            return false;
        }
        this.rating = rating;
        return true;
    }

   
    public override string ToString()
    {
        return name + "|" + age + "|" + spot + "|" + price + "|" + persons + "|" + duration + "|" + rating;
    }
}
