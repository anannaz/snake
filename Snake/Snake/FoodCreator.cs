using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth; //переменные хранит обьект класса, являются полями класса, две переменных одноименных, значение по умолчанию 0
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym) //передаю в конструкторе габариты карты (ширина, высота и символ еды)
        {
            this.mapWidth = mapWidth; //эта переменная поле класса 0 равна переменной из аргумента конструктора 80
            this.mapHeight = mapHeight; //0=25
            this.sym = sym; //0=36'$'
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2); //генерирую произвольные координаты в пределах карты
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        } 


    }
}
