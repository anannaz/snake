using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure //Змейка - фигура из точек, есть стартовая позиция на карте, будет двигаться в конкретном направлении.
        //Абстрагирование - выделить набор значимых характеристик объекта исключая незначимые
        //Класс содержит один конструктор 
    {
        public Direction direction; //класс хранит данные в каком направлении двигается змейка

        public Snake(Point tail, int length, Direction _direction) //создаем конструктор, который принимает параметры(координаты хвоста, ее длину и направление)
        {
            direction = _direction; //заполняется направление в конструкторе

            pList = new List<Point>(); //создаем список
            for (int i = 0; i < length; i++) //в цикле несколько раз создаем точки, точные копии хвостовой точки
            {
                Point p = new Point(tail);
                p.Move( i, direction ); //точку сдвигаю на i позиций по направлению дирекшн
                pList.Add( p ); //добавить эту точку в список
            }
            //реализовать конструктор который правильным образом заполнит список точек из которых состоит змейка
        }

        internal void Move()
        {
            Point tail = pList.First();//вызываем у змейки метод ферст, возвращает первый элемент списка
            pList.Remove(tail); //удаляем хвост, минус одна точка
            Point head = GetNextPoint();//голова должна переместиться метод дай мне след точку, переменная head заполнится значением которое вернет функция
            pList.Add(head);//добавляем в точку список

            tail.Clear(); //затереть точку хвостовую
            head.Draw();//новая головная точка выводится на экран
        }
        public Point GetNextPoint() //метод возвращает данные. Результатом работы будет обьект класса Поинт
        {
            Point head = pList.Last();//текущая позиция головы змейки до того как переместилась
            Point nextPoint = new Point(head);//создаю новую точку которая является копией предыд положения головы
            nextPoint.Move(1, direction);//сдвинем точку по направлению дирекшн
            return nextPoint;//получили новую точку положения головы
        }   
        
        public void HandleKey(ConsoleKey key) //сам класс змейка отвечает за реакцию на клавиши
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
        
    }
}
