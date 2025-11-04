using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Circle : Geometry
    {
        protected override string Type { get; } = "Circle";
        public double Radius { get; set; }

        private double Pi = 3.14;

       

        public Circle()
        {

            Radius = 2;

        }
        public override double Area()//here we polymorph the method by using the base from geometry and changing the behaviour of the method for each shape.
        {base.Area();
            
            double arearesult = (Radius * Radius) * Pi;
            return arearesult;
        }
    }
}
