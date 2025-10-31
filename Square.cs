using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Square:Geometry
    {
        public double Side { get; set; }
        
        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            base.Area();
            double arearesult = Side * Side;

            return arearesult;
        }
    }
}
