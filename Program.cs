﻿using System;
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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
          }        
        }
    }