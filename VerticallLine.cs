﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fjodorovsnake23
{
    class VerticallLine
    {
        List<Class_Point> pList;

        public VerticallLine( int yUp, int yDown, int x, char sym )
        {
            pList = new List<Class_Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Class_Point p = new Class_Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Draw()
        {
            foreach (Class_Point p in pList)
            {
                p.Draw();
            }

        }

            
        }
    }

        
