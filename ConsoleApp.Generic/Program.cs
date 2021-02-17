using System;

namespace ConsoleApp.Generic
{
  class Program
  {
    static void Main(string[] args)
    {
      //var p1 = new Product<int>("Яблоко", 100, 100);
      //var p2 = new Product<double>("Банан", 100.0, 100.5);
      //var p3 = new Product<decimal>("Груша", 10.1M, 110);
      //var p = new Product<int, decimal>("Апельсин", 200, 100.1M);

      var eating = new Eating<Apple>();

      Console.WriteLine();
      Console.ReadLine();
    }
  }
}
