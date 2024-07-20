using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssighmentOOP04.Interfaces
{
    public class Circle : ICircle,IShape
    {
        public double Area { get ; set ; }
       
        public void DisplayShapeInfo()
        {
            Console.WriteLine("Shape is Circle");
        }
    }
}
