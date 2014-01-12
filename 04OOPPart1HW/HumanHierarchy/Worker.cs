using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HumanHierarchy
{
    public class Worker : Human
    {
        public double WeekSalary { get; set; }
        public double WorkHourPerDay { get; set; }

        public Worker(string firstName, string lastName, double weekSalaty, double workHourPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalaty;
            this.WorkHourPerDay = workHourPerDay;
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = 0;
            moneyPerHour = this.WeekSalary / (this.WorkHourPerDay * 5);

            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString() + "; ");
            sb.Append("Salary = " + this.WeekSalary + "; ");
            sb.Append("Work hours " + this.WorkHourPerDay);
            sb.Append("; $ per hour + " + this.MoneyPerHour());

            return sb.ToString();
        }
    }
}
