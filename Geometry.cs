using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Geometry
    {
        protected virtual string Type { get; }//Experimented with accesmodifiers to see what they do. 

        public virtual double Area()
        {
            Console.WriteLine("Area for " +Type + ": ");
            double answer = 0;
            return answer;
        }
    }
}
