using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrodynamics
{
    class Charge
    {
        public PointXY point;
        public double q;

        public Charge(double _x = 0, double _y = 0, double _charge = 0)
        {
            point = new PointXY(_x, _y);
        }
        public double Potential(double _x, double _y)
        {
            double pot = 0;

            pot = q / (Math.Sqrt(Math.Pow(point.x/40 -_x/40,2) + Math.Pow(point.y/40 -_y/40,2)));
            return pot;
        }
    }
}
