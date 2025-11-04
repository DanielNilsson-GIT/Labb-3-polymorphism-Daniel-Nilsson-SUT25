using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal abstract class Geometry //Making it abstract so a "geometry"-object cant be created
    {
        protected virtual string Type { get; }//Experimented with acces-modifiers to see what they do.
                                              //By making it virtual however, "Type" also gets polymorphed between the classes

        public virtual double Area()//By making this method "virtual" it is possible to override it in subclasses, thus enabling polymorphism.
        {
            double answer = 0;
            Console.Write("Area for " +Type + ": ");
            return answer;
        }
    }
}
