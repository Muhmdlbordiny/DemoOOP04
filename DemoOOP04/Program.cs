using DemoOOP04.Icloneable_Interfaces;
using DemoOOP04.Interfaces;
using System.Text;
using System.Xml.Linq;

namespace DemoOOP04
{
    internal class Program
    {
        public static void PrinttenNumbersFromSeries( ISeries series)
        {
            if (series != null)
            {
                for (int i = 0;  i < 10; i++)
                {
                    Console.Write($"{ series.Current },"); //0
                    series.GetNext();
                }
                series.Reset();
            }
        }
        static void Main(string[] args)
        {
            #region Interface
            //IMYType mytype = new IMYType();//Invaild
            // you cant create an object from interface
            //IMYType mYType;
            // you can create a reference from interface
            //ClR will Allocate 4 bytes for reference 'mytype'
            //Reference mytype refer to 'Null'
            //Reference mytype can refer to an object from class or struct implmented interface
            //mYType.Id = 20; // Invaild => my type refer Null
            //mYType.Myfunc() // invaild => my type refer Null
            //mYType.print() // invaild  => my type refer Null
            //Mytype mytype1 = new Mytype();
            //mytype1.Id = 30;
            //mytype1.Myfunc(100);
            //mytype1.Print(); invaild default implemented method

            IMYType mYType = new Mytype();
            //Ref from interface  -> object From class Implement interface 
            mYType.Id = 30;
            mYType.Myfunc(40);
            mYType.print();// Vaild 

            #endregion
            #region Ex01 interface
            //0 2 4 6 8
            //0 3 6 9
            //0 4 8 12 
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //PrinttenNumbersFromSeries(seriesByTwo);
            //Console.WriteLine("\n***************************");
            //SeriesBythree seriesBythree = new SeriesBythree();
            //PrinttenNumbersFromSeries(seriesBythree);

            #endregion
            #region EX02  implement interfaces{ [implicity - Explicity]}
            Car car = new Car();
            car.Backward(); //Car Move backward in Ground
            Airplane airplane = new Airplane();
            //airplane.Forward(); // invaild
            IMoviable Movableplan = new Airplane();
            Movableplan.Forward();//AirPlane Move Forward  on Ground
            IFlyable flyableplan = new Airplane();
            flyableplan.Forward();//Airplane move forward on air
            #endregion
            #region Shallow copy And Deep Copy
            #region Array of Value type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3]; // {0,0,0}
            //Console.WriteLine($" HC of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HC of Arr02 = {Arr02.GetHashCode()}");
            #region Shallow copy [stack]
            //Arr02 = Arr01; // Shallow Copy [سطحي]
            //               //copy occurred stack
            //               //Refernces [Arr01, arr02] => same object
            //Console.WriteLine("Afte Shallow copy");
            //Console.WriteLine($" HC of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($" HC of Arr02 = {Arr02.GetHashCode()}");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//1
            //Arr02[0] = 100;
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//100 
            #endregion

            #region DeepCopy[Heap]
            //Arr02 = (int[]) Arr01.Clone();
            //Console.WriteLine("Afte Clone ............");
            /// Clone =>Deep copy
            ///Deep copy occurred at heap
            ///create New object with Different and New identity
            /// That object will be the same object state   [Data] of Caller [Arr01]
            ///Return to An object 
            //Console.WriteLine($" HC of Arr01 = {Arr01.GetHashCode()}"); //43942917
            //Console.WriteLine($" HC of Arr02 = {Arr02.GetHashCode()}");//2606490
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //1
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//1
            //Arr01[0] = 100;
            //Console.WriteLine("After arr01[0] =100");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}"); //100
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");//1
            #endregion
            #endregion
            #region Array of ref string immutable 

            #region shallow copy
            //string[] Name01 = { "Amr", "Mohamed" };
            //string[] Name02 = { "Ali", "Ahmed" };
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine("Afte shallow copy");
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");
            //Name01[0] = "Mido";
            //Console.WriteLine("Afte Name01[0] ");
            //Console.WriteLine($"HC of Name01 = {Name01[0]}"); //Mido
            //Console.WriteLine($"HC of Name02 = {Name02[0]}");//Mido
            Console.WriteLine("****************************************************");
            #endregion
            #region DeepCopy
            //Name02 = (string[]) Name01.Clone();
            //Console.WriteLine("Afte Deep copy");
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");
            //Console.WriteLine("****************************************************");
            //Console.WriteLine(Name01[0].GetHashCode()); // shallow copy of element in array-824633924
            //Console.WriteLine(Name02[0].GetHashCode()); //-824633924
            //Name02[0] = "Miso";
            //Console.WriteLine(Name01[0]);// Amr

            #endregion
            #endregion
            #region Array of string builder [Mutable]
            //StringBuilder[]Name01 = new StringBuilder[1];
            //Name01[0].Append("Mohmed");//System.NullReferenceException
            //Name01[0] = new StringBuilder("Mohamed");
            //StringBuilder[]Name02 = new StringBuilder[1];
            //Name02[0] = new StringBuilder("Eslam");
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}"); 
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");
            #region Shallowcopy [stack]
            //Name02 = Name01; //Shallow copy [stack]
            //                 //References[Name01,Name02] =>Same object 
            //Console.WriteLine("Name02 =Name01");
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}");//43942917
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");// 43942917
            //Console.WriteLine($"Name01[0] = {Name01[0]}"); //Mohamed
            //Console.WriteLine($"Name02[0] = {Name02[0]}");// Mohamed
            //Name02[0].Append("\tAshraf");
            //Console.WriteLine("After Append :::::::::::::::::::::::::::::::>>>>>");
            //Console.WriteLine($"Name01[0] = {Name01[0]}");//Mohamed Ashraf
            //Console.WriteLine( 
            #endregion$"Name02[0] = {Name02[0]}");//Mohamed Ashraf
            #region Deep Copy
            //Name02 = (StringBuilder[]) Name01.Clone(); //Deep copy 
            // 2 Refernces [Names01 , Names02] => 2 Different objects
            //Console.WriteLine("After clone ");
            //Console.WriteLine($"HC of Name01 = {Name01.GetHashCode()}");
            //Console.WriteLine($"HC of Name02 = {Name02.GetHashCode()}");
            //Console.WriteLine($"Name01[0] = {Name01[0]}");
            //Console.WriteLine($"Name02[0] = {Name02[0]}");
            //Name02[0].Append("Ali");
            //Console.WriteLine("after Name02[0].Append >>>>>>>>>");
            //Console.WriteLine($"\tName01[0] = {Name01[0]}");
            //Console.WriteLine($"\tName02[0] = {Name02[0]}");
            #endregion


            #endregion
            #endregion

            #region Shallow Copy and Deep Copy core using Defined 
            //Employee employee1 = new Employee() { Id = 10, Name = "Mohamed", Salary = 9000 };
            //Employee employee2 = new Employee() { Id = 20, Name = "Ahmed", Salary = 1000 };
            //Employee employee1 = new Employee() { Id = 10, Name = new StringBuilder("Mohamed"), Salary = 9000 };
            //Employee employee2 = new Employee() { Id = 20, Name = new StringBuilder("Ahmed"), Salary = 1000 };
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");

            //HC  of Employee1 = 43942917
            //Employee01 = Id = 10, Name = Mohamed ,Salary  = 9000
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            //HC  of Employee2 = 59941933
            //Employee02 = Id = 20, Name = Ahmed ,Salary  = 1000
            #region Shallow Copy [stack]
            //employee2 = employee1;// Shallow copy 
            //                      // 2refernces [employee1 , employee2]=>same object
            //                      //Employee01 = Id = 10, Name = Mohamed ,Salary  = 9000 =>Has 2 references
            //                      //Employee02 = Id = 20, Name = Ahmed ,Salary  = 1000 => unreachable object
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            //employee1.Id = 100;
            //employee1.Name = "Aya";
            //employee1.Salary = 20000;
            //Console.WriteLine("================================");
            //Console.WriteLine($"employee1 = {employee1}");
            //Console.WriteLine($"employee2 = {employee2}");

            #region shallow copy - Name is stringBuilder
            //employee2 = employee1;// Shallow copy 
            //                      // 2refernces [employee1 , employee2]=>same object
            //                      //Employee01 = Id = 10, Name = Mohamed ,Salary  = 9000 =>Has 2 references
            //                      //Employee02 = Id = 20, Name = Ahmed ,Salary  = 1000 => unreachable object
            //Console.WriteLine("After Shallow Copy");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");

            //employee1.Id = 100;
            //employee1.Name.Append("Aya"); 
            //employee1.Salary = 20000;
            //Console.WriteLine("================================");
            //Console.WriteLine($"employee1 = {employee1}");
            //Console.WriteLine($"employee2 = {employee2}");
            #endregion



            #endregion
            #region Deep Copy Name is string 
            //employee2 =(Employee) employee1.Clone();
            ////Create New Object with New And Different Identity 
            ////Object Has Same Object state of Caller
            //Console.WriteLine("After Deep Copy ");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            ////HC  of Employee1 = 43942917
            ////Employee01 = Id = 10, Name = Mohamed ,Salary = 9000

            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            ////HC  of Employee2 = 2606490
            ////Employee02 = Id = 10, Name = Mohamed ,Salary = 9000
            //employee2.Id = 25;
            //employee2.Name = "Khamis";
            //employee2.Salary = 150000;
            //Console.WriteLine("After Changing Emloyee02 Values");
            //Console.WriteLine(employee1);//Id = 10, Name = Mohamed ,Salary  = 9000
            //Console.WriteLine(employee2);//Id = 25, Name = Khamis ,Salary  = 150000
            #endregion
            #region Deep Copy  Name is stringBuilder
            //employee2 =(Employee) employee1.Clone();
            //Console.WriteLine("After Deep Copy ");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            ////HC  of Employee1 = 43942917
            ////Employee01 = Id = 10, Name = Mohamed ,Salary  = 9000
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            ////HC  of Employee2 = 2606490

            ////Employee02 = Id = 10, Name = Mohamed ,Salary  = 9000
            //employee2.Id = 100;
            //employee2.Name.Append("Elbordiny");
            //employee2.Salary = 6000;
            //Console.WriteLine("After Changing employee02  ");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            #endregion
            //we have 2 ways Deep Copy User Defined DataTypes
            ///1. Clone
            ///2.Copy Constructor 
            //employee2 = new Employee(employee1);
            //Console.WriteLine("After Deep copy using Copy Constructor");
            //Console.WriteLine("After Changing employee02  ");
            //Console.WriteLine($"HC  of Employee1 = {employee1.GetHashCode()}");
            //Console.WriteLine($"Employee01 = {employee1}");
            //Console.WriteLine($"HC  of Employee2 = {employee2.GetHashCode()}");
            //Console.WriteLine($"Employee02 = {employee2}");
            #endregion
            #region Interface Icompareable
            //int[] Numbers = { 9, 6, 4, 3, 8, 2, 1, 5, 10, 7 };
            //Array.Sort(Numbers);
            //foreach(int Num  in Numbers)
            //{
            //    Console.WriteLine(Num);
            //}
            //Employee[] employee = new Employee[4]
            //{
            //    //0 => new Employee
            //    new Employee(){ Id =10, Name ="aya", Salary =10000},
            //    new Employee(){ Id =20, Name ="Ahmed", Salary =100000},
            //    new Employee(){ Id =23, Name ="Eslam", Salary =50000},
            //    new Employee(){ Id =20, Name ="Koko", Salary =20000},

            //};
            //Array.Sort(employee);
            //System.InvalidOperationException
            //At least one object must implement IComparable
            //Sort
            //for (int i = 0; i < employee.Length; i++)
            //{
            //    for (int K = 0; K < employee.Length - i -1; K++)
            //    {
            //        if (employee[K].CompareTo(employee[K + 1]) == 1)
            //            Swap(employee[K], employee[K + 1]);
            //    }
            //}

            //foreach (Employee emp in employee)
            //{
            //    Console.WriteLine(emp);
            //    //Id = 10, Name = aya ,Salary  = 10000
            //    //Id = 20, Name = Koko ,Salary  = 20000
            //    //Id = 23, Name = Eslam ,Salary  = 50000
            //    //Id = 20, Name = Ahmed ,Salary  = 100000
            //}
            //Console.WriteLine(employee[0].CompareTo(employee[1]));
            //Console.WriteLine(employee[0].Id.CompareTo(employee[1].Id));
            #endregion
            #region Built in interface I Comparere 
            Employee[] employee = new Employee[4]
              {
                //0 => new Employee
                new Employee(){ Id =10, Name ="aya", Salary =10000},
                new Employee(){ Id =20, Name ="Ahmed", Salary =100000},
                new Employee(){ Id =30, Name ="Eslam", Salary =50000},
                new Employee(){ Id =40, Name ="Koko", Salary =20000},

            };
            Array.Sort(employee,new EmployeeIdComparer());
            foreach (Employee emp in employee)
            {
                Console.WriteLine(emp);
                //Id = 10, Name = aya ,Salary  = 10000
                //Id = 20, Name = Koko ,Salary  = 20000
                //Id = 30, Name = Eslam ,Salary  = 50000
                //Id = 40, Name = Ahmed ,Salary  = 100000
            }
            Console.WriteLine(employee[0].CompareTo(employee[1]));
            Console.WriteLine(employee[0].Id.CompareTo(employee[1].Id));
            #endregion
        }
    }
}
