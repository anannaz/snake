using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure //наследование описать новый класс на основе существующего, 
        //частично или полностью замещающийся функциональностью
        // базовый класс Фигура для наследников, содержит один список точек и метод
    {//гориз и вертик линии это фигуры состоящие из точек
        protected List<Point> pList;   //список точек выстраиваются в одну линию, модификатор доступа, чтобы переменная pList была видна у наследников

        public void Draw()// метод отвечает за вывод на экран
        {
            foreach (Point p in pList) //цикл все точки из списка
            {
                p.Draw(); //вывод их на экран

            }

        }
        internal bool IsHit(Figure figure) //реализация метода внутри Фигуры
        {
            foreach (var p in pList) //проверка всех точек в Фигуре
            {
                if (figure.IsHit(p))                     //в качестве аргумента точка, берется нижний метод IsHit(Point point)                
                    return true;

                }
                return false;
            }


        private bool IsHit(Point point) //другая одноименная функция реализации точки
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}

