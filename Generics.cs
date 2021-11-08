using System;
using System.Collections.Generic;
using System.Text;

namespace Day_13_Problems
{
    class Generic<T>
    {
        public T[] GArray;
        public Generic(T[] array)
        {
            this.GArray = array;
        }
        public T[] Sort()
        {
            Array.Sort(GArray);
            return GArray;
        }
        public void MaxValue()
        {
            T[] sorted_values = this.Sort();
            Console.WriteLine("Max value is {0}", sorted_values[sorted_values.Length - 1]);
        }


        //private T FisrtValue, SecondValue, ThirdValue;

        //public Generic(T firstValue, T secondValue, T thirdValue)
        //{
        //    this.FisrtValue = firstValue;
        //    this.SecondValue = secondValue;
        //    this.ThirdValue = thirdValue;
        //}

        //public void GenericMax(T FisrtValue, T SecondValue, T ThirdValue)
        //{
        //    if (FisrtValue.CompareTo(SecondValue) > 0 && FisrtValue.CompareTo(ThirdValue) > 0)
        //        Console.WriteLine("{0} is the maximum value among three.", FisrtValue);
        //    else if (SecondValue.CompareTo(FisrtValue) > 0 && SecondValue.CompareTo(ThirdValue) > 0)
        //        Console.WriteLine("{0} is the maximum value among three.", SecondValue);
        //    else if (ThirdValue.CompareTo(FisrtValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
        //        Console.WriteLine("{0} is the maximum value among three.", ThirdValue);
        //}
    }
}
