using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_4.IClonable
{
    class Department : ICloneable
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public object Clone()
        {
            return new Department(this);
            
        }
        public Department(Department department)
        {
            this.Name = department.Name;
            this.Id = department.Id;
        }

        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} ";
        }
    }
        internal class Employee : ICloneable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Department Department { get; set; }

        public object Clone()
        {
            return new Employee(this);
            
        }
        public Employee(Employee employee)
        {
            this.Id = employee.Id;
            this.Name = employee.Name;
            this.Salary = employee.Salary;
            this.Department = (Department)employee.Department.Clone();
        }
        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name} , Salary : {Salary} , Department : {Department}";
        }
    }
}
