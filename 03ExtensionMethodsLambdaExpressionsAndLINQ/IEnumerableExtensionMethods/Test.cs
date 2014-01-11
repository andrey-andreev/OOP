using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethods
{
    class Test
    {
        static void Main(string[] args)
        {
            List<decimal> nums = new List<decimal>();
            nums.Add(54.15m);
            nums.Add(13.1m);
            nums.Add(-7.3m);
            nums.Add(73.4m);

            Console.WriteLine("Sum: {0}", nums.Sum());
            Console.WriteLine("Product: {0}", nums.Product());
            Console.WriteLine("Min: {0}", nums.Min());
            Console.WriteLine("Max: {0}", nums.Max());
            Console.WriteLine("Average: {0}", nums.Average());
        }
    }
}
