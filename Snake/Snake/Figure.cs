using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure //наследование описать новый класс на основе существующего, 
        //частично или полностью замещающийся функциональностью
        // базовый класс для наследников
    {//гориз и вертик линии это фигуры состоящие из точек
        protected List<Point> pList;   //список точек выстраиваются в одну линию, модификатор доступа, чтобы переменная pList была видна у наследников

        public void Drow()// метод отвечает за вывод на экран
        {
            foreach (Point p in pList) //цикл все точки из списка
            {
                p.Draw(); //вывод их на экран

            }

        }

    }
}
