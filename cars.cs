using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  public string fuelEconomy;

  public void SetMakeModel(string newMakeModel)
  {
    _makeModel = newMakeModel;
  }
  public string GetMakeModel()
  {
    return _makeModel;
  }

  public void SetPrice(int newPrice)
  {
    _price = newPrice;
  }
  public int GetPrice()
  {
    return _price;
  }

  public void SetMiles(int newMiles)
  {
    _miles = newMiles;
  }
  public int GetMiles()
  {
    return _miles;
  }

  public Car(string vehicle, int cost, int mileage, string message)
  {
    SetMakeModel(vehicle);
    SetPrice(cost);
    SetMiles(mileage);
    fuelEconomy = message;
  }

  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (GetPrice() < (maxPrice + 100) && GetMiles() < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car("2014 Porsche 911", 114991, 7864, "Excellent");

    Car ford = new Car("2011 Ford F450", 55995, 14241, "Meh");

    Car lexus = new Car("2013 Lexus RX 350", 44700, 20000, "Radical");

    Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979, "The WORST!");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel() + ", The Fuel Economy is " + automobile.fuelEconomy);
    }
  }
}
