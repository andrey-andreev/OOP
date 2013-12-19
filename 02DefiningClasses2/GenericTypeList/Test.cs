using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeList
{
    class Test
    {
        static void Main(string[] args)
        {
            GenericList<int> testVar = new GenericList<int>(4);
            testVar.Add(3);
            testVar.Add(45);
            testVar.Add(-34);
            testVar.Add(13);
            testVar.Add(346);
            testVar.Add(34);
            testVar.Add(-98);
            
            for (int index = 0; index < testVar.GenericArray.Length; index++)
			{
                Console.WriteLine("index {0}: {1}", index, testVar.GenericArray[index]);
			}
            Console.WriteLine();

            //testVar.Insert(123, 2);
            //testVar.Remove(1);
            //testVar.Clear();
            //Console.WriteLine("Testing method FindByValue : {0}", testVar.FindByValue(-34));
            //Console.WriteLine("Testing method GetElement : {0}", testVar.GetElement(1));
            //Console.WriteLine(testVar.ToString());
            //Console.WriteLine(testVar.Min<int>());
            //Console.WriteLine(testVar.Max<int>());
            
            Console.WriteLine();
            for (int index = 0; index < testVar.GenericArray.Length; index++)
            {
                Console.WriteLine("index {0}: {1}", index, testVar.GenericArray[index]);
            }
            
        }
    }
}
