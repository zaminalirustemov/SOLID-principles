using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    internal class Rectangle:Figure
    {
        public double Height;
        public double Width;

        public override double Area()
        {
            return Height* Width;
        }
    }
}
