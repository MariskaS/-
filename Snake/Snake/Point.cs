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

    public Point(int _x, int _y, char _sym) // конструктор - никогда ничего не возвращает
    {
      x = _x;
      y = _y;
      sym = _sym;
    }

    // Show point in console
    public void Draw() // void - ключевое слово, означает что функция ничего не возвращает
    {
      Console.SetCursorPosition(x, y);
      Console.Write(sym);
    }
  }
}
