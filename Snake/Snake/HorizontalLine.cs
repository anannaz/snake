using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine //список точек
    {
        List<Point> pList;   //список точек выстраиваются в одну линию
        public HorizontalLine(int xLeft, int xRight,int y, char sym) //конструктор, метод вызывается при создании линии
        {//при создании гориз линии передаем параметры (длина и положение линии)
            pList = new List<Point>(); //создаем пустой список
            for(int x = xLeft; x<=xRight; x++) //на каждой итерации переменная х будет получать значение от хлевой до хправой
            {
                Point p = new Point(x, y, sym); //создаем точки с нужными координатами
                pList.Add(p); //добавляем их в список точек - конец конструктора
            }
           
        }
        public void Drow()// метод отвечает за вывод на экран
        {
            foreach(Point p in pList) //цикл все точки из списка
            {
                p.Draw(); //вывод их на экран

            }

        } 
    }
}
