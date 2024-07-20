using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Interfaces
{
    //Default Access Modifier of Interface => Internal

     public interface IMYType
    {
        //Default Access Modifier Inside Interface => Public
        //Private Access Modifier is not allowed inside interface


        //What You Can Write Inside The Interface
        //Signature for Property [Name -Type -[Get] | [Set]]
        public int Id { get; set; }
        //Inside class or struct =>Automatic Property
        // Compiler will generate private hidden Attribute[Backing Field]
        //Inside interface =>signture for property

        //Signature for Method [Name - Return type -Parameter]
        public void Myfunc(int X);

        //Default Implemented Method [C#8.0 Feature (.NetCore 3.1 2019]
        public void print()
        {
            Console.WriteLine("Hello Default Implemented Method From Interface");
        }

    }
}
