using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fjodorovsnake23
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Point p1 = new Class_Point(1, 3, '*');
            p1.Draw(); //Создаем метод Draw//

            Class_Point p2 = new Class_Point(4, 5, '#');
            p2.Draw();

            HorizonLine line = new HorizonLine(5, 10, 8, '+');
            line.Drow();

            Console.ReadLine();
          }        
        }
    }
