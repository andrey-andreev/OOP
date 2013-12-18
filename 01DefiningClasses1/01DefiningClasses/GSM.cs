using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class GSM
    {
        //declare fields
        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private List<Call> callHistory;
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        private static GSM iPhone4S = new GSM("IPhone4S", "Apple", 499.99, "AAA");

        //properties
        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set 
            {
                if (this.model == null)
                {
                    throw new NullReferenceException("The model is mandatory.");
                }
                else
                {
                    this.model = value; 
                }
            }
        }

        public string Manufacturer
        {
            get 
            { 
                return this.manufacturer; 
            }
            set 
            {
                if (this.manufacturer == null)
                {
                    throw new NullReferenceException("The mandatory is mandatory.");
                }
                else
                {
                    this.manufacturer = value;
                }
                this.manufacturer = value; 
            }
        }

        public double? Price
        {
            get 
            { 
                return this.price; 
            }
            set 
            {
                if (this.price < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative number.");
                }
                else
                {
                    this.price = value; 
                }
            }
        }

        public string Owner
        {
            get 
            { 
                return this.owner;
            }
            set 
            {
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        //c-tors
        public GSM(string model, string manufacturer)
        {
            this.Model =  model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.CallHistory = new List<Call>();
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM()
        {
            this.Model = null;
            this.Manufacturer = null;
            this.Price = null;
            this.Owner = null;
            this.CallHistory = new List<Call>();
            this.Battery = new Battery();
            this.Display = new Display();
        }

        public GSM(string model, string manufacturer, double? price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.CallHistory = new List<Call>();
            this.Battery = new Battery();
            this.Display = new Display();
        }
    
        //methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("GSM characteristics: ");
            result.AppendLine("Model: " + this.Model);
            result.AppendLine("Manufacturer: " + this.Manufacturer);
            result.AppendLine("Price: " + this.Price);
            result.AppendLine("Owner: " + this.Owner);
            result.AppendLine("Hours idle: " + this.Battery.HoursIdle);
            result.AppendLine("Hours talk: " + this.Battery.HoursTalk);
            result.AppendLine("Display size: " + this.Display.Size);
            result.AppendLine("Number of colors: " + this.Display.ColorsNumber);
            string printInfo = result.ToString();
        
            return printInfo;
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCallByIndex(int index)
        {
            this.CallHistory.RemoveAt(index);
        }

        public void ClearAllHistory()
        {
            this.callHistory.Clear();
        }

        public void ClearCallHistory()
        {
            this.CallHistory.RemoveRange(0, CallHistory.Count);
        }

        public double CalculatePrice(double unitPrice)
        {
            double finalPrice = 0;
            double duration = 0;
            foreach (var call in this.CallHistory)
            {
                duration += call.Duration;
            }

            finalPrice = unitPrice * duration / 60;

            return finalPrice;
        }
    }
}
