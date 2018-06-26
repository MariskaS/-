using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1 point - create new point and show in console
      Point p1 = new Point(1, 3, '*'); // новый экземпляр класса
      p1.Draw();

      // 2 point - create new point and show in console
      Point p2 = new Point(4, 5, '#');
      p2.Draw();

      Console.ReadLine();
    }
  }
}