using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    public class Car : Vechile, IMoviable
    {

        //forward();
        //backward();
        //Right();
        //Left();
        public void Backward()
        {
            Console.WriteLine("Car Move backward in Ground");
        }

        public void Forward()
        {
            throw new NotImplementedException();
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
