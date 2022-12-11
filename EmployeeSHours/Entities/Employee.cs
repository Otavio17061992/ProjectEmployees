using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSHours.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }

        public double ValuePerHour { get; set; }
    
        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerhour)
        {
            this.Name = name;

            this.Hours = hours;

            this.ValuePerHour = valuePerhour;
        }

        // metods of the employee

        public virtual double payment()
        {
            return this.Hours * this.ValuePerHour; 
        }
    }
}
