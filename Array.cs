using System;
using System.Text;

namespace HW_Interface
{
    public class Array : ICalc , IOutput2, ICalc2
    {
        public int[] arr { get; set; }
        public int size;
        public int counter;

        public Array()
        {
            arr = new int[0];
            size = 0;
        }

        public int Less(int valueToCompare)
        {
            foreach(var item in arr)
            {
                if(item < valueToCompare)
                {
                    size++;
                }
            }
            return size;
        }

        public int Greater(int valueToCompare)
        {
            foreach(var item in arr)
            {
                if(item > valueToCompare)
                {
                    size++;
                }
            }
            return size;
        }

        public string ShowEven()
        {
            System.Text.StringBuilder stringBuilder = new StringBuilder();
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    stringBuilder.Append(item);
                }
            }
            return stringBuilder.ToString();
        }
        public string ShowOdd()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int item in arr)
            {
                if (item % 2 != 0)
                {
                    stringBuilder.Append(item);
                }
            }
            return stringBuilder.ToString();
        }

        public int CountDistinct()
        {
            return counter = arr.Where(t => arr.Count(t.Equals) == 1).Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            foreach (int item in arr)
            {
                if (item == valueToCompare)
                { 
                    counter++;
                }
            }
            return counter;
        }
    }
}
