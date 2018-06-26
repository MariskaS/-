﻿using System;
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

    public Point(Point p)
    {
      x = p.x;
      y = p.y;
      sym = p.sym;
    }

    public void Move(int offset, Direction direction)
    {
      if(direction == Direction.RIGHT)
      {
        x = x + offset;
      }
      else if(direction == Direction.LEFT)
      {
        x = x + offset;
      }
      else if (direction == Direction.UP)
      {
        y = y + offset;
      }
      else if (direction == Direction.DOWN)
      {
        y = y - offset;
      }
    }

    // Show point in console
    public void Draw() // void - ключевое слово, означает что функция ничего не возвращает
    {
      Console.SetCursorPosition(x, y);
      Console.Write(sym);
    }

    public void Clear() // void - ключевое слово, означает что функция ничего не возвращает
    {
      sym = ' ';
      Draw();
    }

    public override string ToString()
    {
      return x + ", " + y + ", " + sym;
    }
  }
}
