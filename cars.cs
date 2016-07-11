using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;

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


  public bool WorthBuying(int maxPrice, int maxMiles)
  {
    return (GetPrice() < (maxPrice + 100) && GetMiles() < maxMiles);
  }
}

public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    Console.WriteLine(porsche.GetMakeModel());
    Console.WriteLine(porsche.GetPrice());
    Console.WriteLine(porsche.GetMiles());

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);

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
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
