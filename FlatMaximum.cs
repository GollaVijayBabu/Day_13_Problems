using System;

namespace Day_13_Problems
{
    class UC_2
    {
        double[] FloatValues;
        public UC_2(double[] floatValues)
        {
            this.FloatValues = floatValues;
        }
        public double[] Sort()
        {
            Array.Sort(FloatValues);
            return FloatValues;
        }
        public void MaxValue()
        {
            double[] sorted_values = this.Sort();
            Console.WriteLine("Max value is {0}", sorted_values[sorted_values.Length - 1]);
        }
        /*public void floatMax()
        {
            Console.WriteLine("Please Enter First Number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Second Number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Third Number");
            double c = double.Parse(Console.ReadLine());
 
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                Console.WriteLine("{0} is the maximum number among three.", a);
            else if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                Console.WriteLine("{0} is the maximum number among three.", b);
            else if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                Console.WriteLine("{0} is the maximum number among three.", c);
        }*/
    }
}
