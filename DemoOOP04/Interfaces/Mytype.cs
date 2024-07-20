using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    // Developer02
    //interface  is a code contract between 2 developer
    //Class : Class > inherit 
    //class :interface > implement
    //struct:interface >implement 
    // interface :interface >inherit
    // interface can be Implemented through Class  or Struct
    internal class Mytype : IMYType
    {
        public int Id { get ; set ; } // Automatic Property
                                      //Compiler will generate private attribute hidden [Backing field]

        //[Non Static Function (Object Member Function)]
        public void Myfunc(int X)
        {
            Console.WriteLine($"Hello Route X =  {X}  , Id = {Id}");
        }
    }
}
