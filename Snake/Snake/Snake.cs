using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure //Змейка - фигура из точек, есть стартовая позиция на карте, будет двигаться в конкретном направлении.
        //Абстрагирование - выделить набор значимых характеристик объекта исключая незначимые
    {
        public Snake(Point tail, int length, Direction direction) //создаем конструктор, который принимает параметры(координаты хвоста, ее длину и направление)
        {
            pList = new List<Point>(); //создаем список
            for (int i = 0; i < length; i++) //в цикле несколько раз создаем точки, точные копии хвостовой точки
            {
                Point p = new Point(tail);
                p.Move( i, direction ); //точку сдвигаю на i позиций по направлению дирекшн
                pList.Add( p ); //добавить эту точку в список
            }
            //реализовать конструктор который правильным образом заполнит список точек из которых состоит змейка
        }

    }
}
