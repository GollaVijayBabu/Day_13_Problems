using System;

namespace Day_13_Problems
{
    class UC_3
    {
        string[] strName;
        public UC_3(string[] str)
        {
            this.strName = str;
        }
        public string[] Sort()
        {
            Array.Sort(strName);
            return strName;
        }
        public void MaxValue()
        {
            string[] sorted_values = this.Sort();
            Console.WriteLine("Max value is {0}", sorted_values[sorted_values.Length - 1]);
        }
        /* public void stringMax()
         {
             Console.WriteLine("Please Enter First String Value");
             string str1 = Convert.ToString(Console.ReadLine());
             Console.WriteLine("Please Enter Second String Value");
             string str2 = Convert.ToString(Console.ReadLine());
             Console.WriteLine("Please Enter Third String Value");
             string str3 = Convert.ToString(Console.ReadLine());

             if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
                 Console.WriteLine("{0} is the maximum string among three.", str1);
             else if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0)
                 Console.WriteLine("{0} is the maximum string among three.", str2);
             else if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0)
                 Console.WriteLine("{0} is the maximum string among three.", str3);
         }*/
    }
}
