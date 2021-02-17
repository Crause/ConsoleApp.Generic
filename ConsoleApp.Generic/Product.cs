using System;

namespace ConsoleApp.Generic
{
  public class Product
  {
    public string Name { get; set; }
    public int Volume { get; set; }
    public int Energy { get; set; }
    public Product(string name, int volume, int energy)
    {
      // TODO: проверить входные параметры

      Name = name;
      Volume = volume;
      Energy = energy;
    }
  }
}
