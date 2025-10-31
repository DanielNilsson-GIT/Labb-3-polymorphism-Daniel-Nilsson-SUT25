using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Rectangle:Geometry
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle(double sidea, double sideb )
        {
            SideA = sidea;
            SideB = sideb;
        }
        public override double Area()
        {
            base.Area();
            double arearesult = SideA * SideB;

            return arearesult;
        }

    }
}
