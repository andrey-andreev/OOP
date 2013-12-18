using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DefiningClasses
{
    public class GSMTest
    {
        static void Main(string[] args)
        {
            GSM gsm1 = new GSM("sams", "samssss");
            GSM gsm2 = new GSM("HTC", "HTC Corporation");
            GSM gsm3 = new GSM();
            GSM gsm4 = new GSM("Huawei", "Huawei Technologies Co. Ltd.");
            GSM[] GSMArray = new GSM[4] { gsm1, gsm2, gsm3, gsm4};
            foreach (GSM gsm in GSMArray)
            {
                Console.WriteLine(gsm.ToString());
            }
            Console.WriteLine(GSM.IPhone4S);
            
            // GSMCallHistoryTest
            GSMCallHistoryTest.Test();

        }
    }
}
