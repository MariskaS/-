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
      // Установить размер окна и убрать возможность перемотки
      Console.SetBufferSize(80, 25);

      // Отрисовка рамочки
      HorisontalLine lineUp = new HorisontalLine(0, 78 , 0, '+');
      lineUp.Drow();

      HorisontalLine lineDown = new HorisontalLine(0, 78, 24, '+');
      lineDown.Drow();

      VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
      lineLeft.Drow();

      VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
      lineRight.Drow();

      // Отрисовка точек
      Point p = new Point(4, 5, '*');
      p.Draw();

      Console.ReadLine();
    }
  }
}

