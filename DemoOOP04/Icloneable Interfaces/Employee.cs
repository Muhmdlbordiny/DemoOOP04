using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP04.Icloneable_Interfaces
{
    internal class Employee:ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary {  get; set; }
        //Deep Copy
        public object Clone()
        {
            //return new Employee() { Id = this.Id , Name = this.Name, Salary = this.Salary};
            return new Employee(this); // this refer to Caller 
        }
        //Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        public Employee()
        {
            
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name} ,Salary  = {Salary}";
        }

        public int CompareTo(object? obj)
        {
            //employee[K].CompareTo(employee[K + 1]) == 1
            //this.CompareTo(obj)
            //0=> this.salary ==     obj.salary
            //+ve  => this.salary > obj.salary
            //-ve =>this.salary < obj.salary
            
            Employee pass = obj as Employee; // UnSafe
            if (this.Salary > pass.Salary)
                return 1;
            else if (this.Salary < pass.Salary)
                return -1;
            else 
                return 0;
            

            

        }
    }
}
