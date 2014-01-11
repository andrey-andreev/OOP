using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableExtensionMethods
{
    public static class ExtensionMethods
    {
        /* 2.
         * Implement a set of extension methods for IEnumerable<T> that implement 
         * the following group functions: sum, product, min, max, average.
         */

        public static T Sum<T>(this IEnumerable<T> inputColection)
            where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in inputColection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> inputColection)
            where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in inputColection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> inputColection)
            where T : IComparable
        {
            T min = inputColection.First();
            foreach (var item in inputColection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> inputColection)
            where T : IComparable
        {
            T max = inputColection.First();
            foreach (T item in inputColection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> inputColection)
            where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in inputColection)
            {
                sum += item;
            }
            dynamic average = sum / inputColection.Count<T>();

            return average;
        }
    }
}
