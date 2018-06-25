using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  class Point
  {
    public int x;
    public int y; // int - переменная / тип данных - целые числа(целочисленная переменная)
    public char sym; // char - переменная / тип данных - символ

    // Show point in console
    public void Draw()
    {
      Console.SetCursorPosition(x, y);
      Console.Write(sym);
    }
  }
}
