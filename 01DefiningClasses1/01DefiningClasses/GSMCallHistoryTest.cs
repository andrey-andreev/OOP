using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class GSMCallHistoryTest
    {
        public static void Test()
        {
            GSM gsm = new GSM();
            //*Create an instance of the GSM class.
            gsm.AddCall(new Call(new DateTime(2013, 11, 12), "0888888888", 111));
            gsm.AddCall(new Call(new DateTime(2013, 11, 13), "0888888881", 333));
            gsm.AddCall(new Call(new DateTime(2013, 11, 14), "0888888882", 222));
            foreach (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }
            Console.WriteLine("The price is : " + gsm.CalculatePrice(0.37));
            
            int biggestDurationCallIndex = 0;
            for (int index = 0; index < gsm.CallHistory.Count; index++)
            {
                int temporaryDuration = 0;
                if (temporaryDuration < gsm.CallHistory[index].Duration)
                {
                    biggestDurationCallIndex = index;
                }
            }

            gsm.RemoveCallByIndex(biggestDurationCallIndex);
            Console.WriteLine("The price is : " + gsm.CalculatePrice(0.37));

            gsm.CallHistory.Clear();
            Console.WriteLine("The price is : " + gsm.CalculatePrice(0.37));
        }
    }
}
