using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight) //принимает габариты карты и на их основе создает горизонтальные и вертикальные линии
        {
            wallList = new List<Figure>();


            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+'); // создаю линию, задать положение точки
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');//создаем рамочку

            wallList.Add(upLine); //создав линии добавляем в список фигур, который хранится в данном классе
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit(Figure figure) //функция в качестве аргумента принимает любую фигуру и возвращает результат булеан
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
                return false;
            
        }            
       
    
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }          
            
}
