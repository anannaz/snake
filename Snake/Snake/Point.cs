using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point //класс, описывает как выглядит точка,  оперирует тремя переменными, состоит из
    {
        public int x; //данные, координаты по оси х у и символ, поля класса
        public int y;
        public char sym;

        public Point() //начало конструктора
        {            
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym; //конец конструктора
        }

        public Point(Point p) //добавляем новый конструктор для создания точек с помощью другой точки
        {
            x = p.x;
            y = p.y;
            sym = p.sym;

        }

        public void Move (int offset, Direction direction)//создаем метод move который будет сдвигать данную точку на расстояние по направлению
        {
            if(direction==Direction.RIGHT)
            {
                x = x + offset;

            }
            else if(direction==Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction==Direction.UP)
            {
                y = y - offset;
            }
            else if(direction==Direction.DOWN)
            {
                y = y + offset;
            }

        }

        public bool IsHit(Point p) // метод проверяет на равенство координат текущей точки и точки переданной в качестве аргмента
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw() //методы оперируют переменными принадлежащими данному классу
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()//метод который затрет точку
        {
            sym = ' ';
            Draw();//отрисовать точку с новым значением
        }

        public override string ToString() //метод
        {
            return x + " , " + y + " , " + sym;
        }
    }
}
