using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fjodorovsnake23
{
    class HorizonLine : Figure
    {
        List<Class_Point> pList;

        public HorizonLine(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Class_Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Class_Point p = new Class_Point(x, y, sym);
                pList.Add(p);
            }

        }
                  }
                
            }

        
    

