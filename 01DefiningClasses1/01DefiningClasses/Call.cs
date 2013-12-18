using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class Call
    {
        //fields
        public DateTime dateAndTime;
        private string dialedPhoneNumber;
        private uint duration;

        //c-tors
        public Call(DateTime dateAndTime, string dialedPhoneNumber, uint duration)
        {
            this.DateAndTime = dateAndTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        //props
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndTime;
            }
            set
            {
                this.dateAndTime = value;
            }
        }
        
        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }

        }

        //methods
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Call info: ");
            result.AppendLine("Date and time: " + this.DateAndTime);
            result.AppendLine("Dialed phone number: " + this.DialedPhoneNumber);
            result.AppendLine("Duration: " + this.Duration);
            string printInfo = result.ToString();

            return printInfo;
        }
    }
}
