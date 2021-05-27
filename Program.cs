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
            Console.SetWindowSize(80, 16);
            Console.SetBufferSize( 80, 16 );

            //Отрисовка рамок
            HorizonLine upLine = new HorizonLine(0, 78, 0, '+');
            HorizonLine downLine = new HorizonLine(0, 78, 24, '+');
            VerticallLine leftLine = new VerticallLine(0, 24, 0, '+');
            VerticallLine rightLine = new VerticallLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            //Отрисовка точек 
            Class_Point p = new Class_Point(4, 5, '*');
            p.Draw();

            
            Console.ReadLine();
          }        
        }
    }
