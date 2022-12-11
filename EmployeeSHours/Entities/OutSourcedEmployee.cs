using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSHours.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double additionalCharge { get; set; }

        public OutSourcedEmployee()
        {

        }

        public OutSourcedEmployee( string name, int hours, double valuePerhour, double additionalCharge)
            : base(name,hours,valuePerhour)
        {
            this.additionalCharge = additionalCharge;
        }

        public override double payment()
        {
            return base.payment() + 1.1*additionalCharge;

        }
    }
}
