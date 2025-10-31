using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Circle : Geometry
    {
        private double Pi = 3.14;
        public double Radius { get; set; }

        public Circle(double radius)
        {

            Radius = radius;

        }
        public override double Area()
        {
            double arearesult = (Radius * Radius) * Pi;
            return arearesult;
        }
    }
}
