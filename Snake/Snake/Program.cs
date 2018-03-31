﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program //класс собирает 
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+'); // создаю линию, задать положение точки
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');//создаем рамочку
            upLine.Drow(); //вывести линию на экран, нарисовали рамочку
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*'); //класс Point создает точки и выводит на экран
            Snake snake = new Snake(p, 4, Direction.RIGHT); //точка задает хвост, длину 4, направление движения вправо
            snake.Drow();

            while (true) //обработка нажатия клавиш, бесконечный цикл, код внутри скобочек выполняется вечно
            {
                if(Console.KeyAvailable) //проверка была ли нажата какая-либо клавиша
                {
                    ConsoleKeyInfo key = Console.ReadKey();//получаю значение клавиши и делаю проверку чему она равна
                    snake.HandleKey(key.Key); //вызов метода из класса Змейка для обработки нажатия
                }
                Thread.Sleep(100); //задержка на 100 милисекунд
                snake.Move(); //двигаю змейку
            }           
            

        }
        
    }
}
