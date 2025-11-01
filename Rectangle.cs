using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Rectangle:Geometry
    {
       protected override string Type { get; } = "Rectangle";
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle()
        {
            SideA = 4;
            SideB = 5;
        }
        public override double Area()
        {
            base.Area();
            double arearesult = SideA * SideB;

            return arearesult;
        }

    }
}
