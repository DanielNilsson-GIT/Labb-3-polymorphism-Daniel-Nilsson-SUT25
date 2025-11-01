using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Rectangle:Geometry
    {
       protected override string Type { get; } = "Rectangle"; //Here, the same prop "Type" get's changed to "Rectangle". Type get's polymorphed into a diffrent value.
        public double SideA { get; set; }
        public double SideB { get; set; }

        public Rectangle()
        {
            SideA = 4;
            SideB = 5;
        }
        public override double Area() //Here we have the method override for "Area()". This means that "Area()" changes behaviour for each subclass. This is polymotphism.
        {
            base.Area();//Using the same base as in Geometry, but adapting a diffrent behaviour (diffrent calculation) depending on geometry type. 
            double arearesult = SideA * SideB;

            return arearesult;
        }

    }
}
