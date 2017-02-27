using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape2D shape = new Circle(10);
            var circleArea =  shape.CalculateArea();

            shape = new Rectangle(5, 10);
            circleArea = shape.CalculateArea(); 
        }
    }
}
