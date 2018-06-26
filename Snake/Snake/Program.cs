﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
  class Program
  {
    static void Main(string[] args)
    {
      // Установить размер окна и убрать возможность перемотки
      Console.SetBufferSize(80, 25);

      // Отрисовка рамочки
      HorizontalLine lineUp = new HorizontalLine(0, 78 , 0, '+');
      lineUp.Drow();

      HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
      lineDown.Drow();

      VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
      lineLeft.Drow();

      VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
      lineRight.Drow();

      // Отрисовка точек
      Point p = new Point(4, 5, '*');

      Snake snake = new Snake(p, 4, Direction.RIGHT);
      snake.Drow();
      snake.Move();
      Thread.Sleep(300);
      snake.Move();
      Thread.Sleep(300);
      snake.Move();
      Thread.Sleep(300);
      snake.Move();
      Thread.Sleep(300);
      snake.Move();
      Thread.Sleep(300);

      Console.ReadLine();
    }
  }
}

