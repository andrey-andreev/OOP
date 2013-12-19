using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeList
{
    public class GenericList<T> 
    {
        public T[] GenericArray { get; set; }
        private int Lenght;
        private int elementsCurentNumber;

        public GenericList(int size)
        {
            this.GenericArray = new T[size];
            this.Lenght = size;
            this.elementsCurentNumber = 0;
        }

        public void Add(T element)
        {
            this.GenericArray[this.elementsCurentNumber] = element;
            this.elementsCurentNumber++;
            if (this.Lenght == this.elementsCurentNumber)
            {
                IncreaseCapacity();
            }
            
        }

        public T GetElement(int pos)
        {
            if (pos < 0 || pos > this.elementsCurentNumber)
            {
                throw new IndexOutOfRangeException("The entered position is of the array.");
            }
            return this.GenericArray[pos];
        }

        public void Remove(int pos)
        {
            if (pos < 0 || pos > this.elementsCurentNumber)
            {
                throw new IndexOutOfRangeException("The entered position is of the array.");
            }
            for (int index = pos ; index < this.elementsCurentNumber; index++)
			{
                this.GenericArray[index] = this.GenericArray[index + 1];
			}
            this.elementsCurentNumber--;
        }

        public void Insert(T element, int pos)
        {
            if (pos < 0 || pos > this.elementsCurentNumber)
            {
                throw new IndexOutOfRangeException("The entered position is of the array.");
            }
            for (int index = this.elementsCurentNumber; index > pos; index--)
            {
                this.GenericArray[index] = this.GenericArray[index - 1];
            }
            this.GenericArray[pos] = element;
            this.elementsCurentNumber++;

            if (this.Lenght == this.elementsCurentNumber)
            {
                IncreaseCapacity();
            }
        }

        public void Clear()
        {
            Array.Clear(this.GenericArray, 0, Lenght);
        }

        private void IncreaseCapacity()
        {
            T[] tempArray = new T[this.Lenght];
            this.GenericArray.CopyTo(tempArray, 0);
            this.Lenght *= 2;
            this.GenericArray = new T[this.Lenght];
            tempArray.CopyTo(this.GenericArray, 0);
        }

        public int FindByValue(T element)
        {
            return Array.IndexOf(this.GenericArray, element);
        }

        public T Min<T>() where T : System.IComparable<T>, IComparable
        {
            dynamic min = this.GenericArray[0];
            for (int i = 1; i < this.elementsCurentNumber; i++)
            {
                T listItem = (dynamic)this.GenericArray[i];
                if (listItem.CompareTo(min) < 0)
                {
                    min = this.GenericArray[i];
                }
            }
            return min;
        }

        public T Max<T>() where T : System.IComparable<T>, IComparable
        {
            dynamic max = this.GenericArray[0];
            for (int i = 1; i < this.elementsCurentNumber; i++)
            {
                T tempValue = (dynamic)this.GenericArray[i];
                if (tempValue.CompareTo(max) > 0)
                {
                    max = this.GenericArray[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.elementsCurentNumber; i++)
            {
                result.Append(this.GenericArray[i]);
                if (i < this.elementsCurentNumber - 1)
                {
                    result.Append(", ");
                }
            }

            return string.Format(result.ToString());
        }
    }
}
