using DemoOOP04.Icloneable_Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04
{
    internal class EmployeeIdComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? EmployeeX = (Employee?)x;//unSafe
            Employee? EmployeeY = (Employee?)y;//unSafe
            //employeex.id >employeey.id =>+ve 
            //employeex.id <employeey.id =>-ve
            //employeex.id =employeey.id => 0
            //if (EmployeeX.Id > EmployeeY.Id)
            //    return 1;
            //else if (EmployeeX.Id < EmployeeY.Id)
            //    return -1;
            //else 
            //    return 0;
            //employeex = null                    =>-ve
            //employeey = null                    =>+ve
            //employeex = null & employeey = null => 0
            return EmployeeX?.Id.CompareTo(EmployeeY?.Id)??(EmployeeY is null ?0:-1);

            


        }
        //public int Compare(Employee? x, Employee? y)
        //{
        //    if (x.Id>y.Id)
        //    {

        //    }
        //}
    }
}
