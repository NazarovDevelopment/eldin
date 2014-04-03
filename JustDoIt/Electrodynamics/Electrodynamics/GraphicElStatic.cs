using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Electrodynamics
{
    class GraphicElStatic
    {
        public ArrayList AllElements;
        public String name;
        public GraphicElStatic()
        {
            AllElements = new ArrayList();
        }
        public void AddPoint(PointXY point)
        {
            AllElements.Add(point);
        }

        public int GetCount()
        {
            return AllElements.Count;
        }

        public void SetName(string str)
        {
            name = str;
        }

        public double Potential(double _x, double _y)
        {
            double pot = 0;
            for (int i = 0; i < AllElements.Count; i++)
            {
                pot = pot + ((Charge)AllElements[i]).Potential(_x,_y);
            }
            return pot;
        }
        
    }
}
