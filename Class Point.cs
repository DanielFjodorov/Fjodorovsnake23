using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fjodorovsnake23
{
    class Class_Point //Создание Класс point// 
    {
        public int x;
        public int y;
        public char sym;

        public Class_Point()
        {
        }

        public Class_Point(int _x, int _y, char _sym)
        {
            x = x;
            y = y;
            sym = _sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
