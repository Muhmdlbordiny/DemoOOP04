using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    public class Airplane : Vechile, IMoviable, IFlyable
    {
        ///Airplane inherit from Vechile and Implement Interfaces (IMovable,IFlyable)
        //forward();
        //backward();
        //Right();
        //Left();


        //forward();
        //backward();
        //Right();
        //Left();
        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane Move Backward on Air");
        }

        void IMoviable.Backward()
        {
            Console.WriteLine("AirPlane Move Backward on Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("Airplane move forward on air ");
        }

        void IMoviable.Forward()
        {
            Console.WriteLine("AirPlane Move Forward  on Ground");
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoviable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }

        void IMoviable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
