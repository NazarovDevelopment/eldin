using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Electrodynamics
{
    class ChargedLine
    {
        public PointXY FirstPoint;
        public PointXY SecondPoint;
        public Double charge;
        
        public ChargedLine(PointXY _FPoint, PointXY _SPoint, double _charge)
        {
            FirstPoint = _FPoint;
            SecondPoint = _SPoint;
            charge = _charge;
        }

        public ChargedLine()
        {
            FirstPoint = new PointXY();
            SecondPoint = new PointXY();
            charge = 0;
        }
    }
}
