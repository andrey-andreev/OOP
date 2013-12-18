using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class Battery
    {
        //fields
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        public enum BatteryType { LiIon, NiMH, NiCd };
        //properties
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (this.hoursIdle < 0)
                {
                    throw new ArgumentOutOfRangeException("The hours idle cannot be negative number");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (this.hoursTalk < 0)
                {
                    throw new ArgumentOutOfRangeException("The hours talk cannot be negative number.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }
    
        //c-tors
        public Battery()
        {
            this.Model = null;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(string model,int? hoursIdle, int? hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
    }
}
