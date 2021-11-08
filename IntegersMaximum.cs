using System;

namespace Day_13_Problems
{
    class UC_1
    {
        int[] Numbers;
        public UC_1(int[] Number)
        {
            this.Numbers = Number;
        }
        public int[] Sort()
        {
            Array.Sort(Numbers);
            return Numbers;
        }
        public void MaxValue()
        {
            int[] sorted_values = this.Sort();
            Console.WriteLine("Max value is {0}", sorted_values[sorted_values.Length - 1]);
        }

        /*public void intMax()
        {
            Console.WriteLine("Please Enter First Number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number");
            int c = int.Parse(Console.ReadLine());
 
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("{0} isn the maximum number among three.", a);
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("{0} is the maximum number among three.", b);
            else if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                Console.WriteLine("{0} is the maximum number among three.", c);
            else
                console.WriteLine("Please check your values");
        }*/
    }
}
