using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Circle:Figure
    {
        public double Radius;

        public override double Area()
        {
            return Radius*Radius*Math.PI;
        }
    }
}
