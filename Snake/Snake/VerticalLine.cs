using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure //куски кода переиспользовать из класса Фигура
    {

        public VerticalLine(int yUp, int yDown, int x, char sym) //конструктор, метод вызывается при создании линии
        {//при создании верхней линии передаем параметры (длина и положение линии)

            pList = new List<Point>(); //создаем пустой список
            for (int y = yUp; y <= yDown; y++) //на каждой итерации переменная у будет получать значение от верхней точки до нижней
            {
                Point p = new Point(x, y, sym); //создаем точки с нужными координатами
                pList.Add(p); //добавляем их в список точек - конец конструктора
            }

        }

    }
}

