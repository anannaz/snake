using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point //класс, описывает как выглядит точка,  состоит из
    {
        public int x; //данные, координаты по оси х у и символ
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

        public void Draw() //методы
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
