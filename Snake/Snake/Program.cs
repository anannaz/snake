using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake //Kartavec (c)
{
    class Program //класс собирает 
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*'); //класс Point создает точки и выводит на экран
            Snake snake = new Snake(p, 4, Direction.RIGHT); //точка задает хвост, длину 4, направление движения вправо
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true) //обработка нажатия клавиш, бесконечный цикл, код внутри скобочек выполняется вечно
            {
                if(walls.IsHit(snake) || snake.IsHitTail()) //проверка столкнулась ли Змейка со стеной ИЛИ с хвостом
                {
                    break; //выйти из цикла
                }

                if (snake.Eat(food)) //метод возвращает или правду или ложь, будет змейка кушать или нет
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move(); //двигаю змейку
                }
                Thread.Sleep(100); //задержка на 100 милисекунд  
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key );
                }
            }
        }
    }
}

