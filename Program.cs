using System;

namespace Day_13_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 13 Problems \n");
            Console.WriteLine("Please select following options \n");
            Console.WriteLine(" 1.UC_1 \n 2.UC_2 \n 3.UC_3 \n 4.GenericClass \n");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter out of how many values you want to find maximum");
                    int N = Convert.ToInt32(Console.ReadLine());
                    int[] Number = new int[N];
                    for (int i = 0; i < N; i++)
                    {
                        Console.WriteLine("Please enter the {0} number", i + 1);
                        Number[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    UC_1 maxInt = new UC_1(Number);
                    maxInt.MaxValue();
                    //maxInt.intMax();
                    break;

                case 2:
                    Console.WriteLine("Please enter out of how many values you want to find maximum");
                    int n = Convert.ToInt32(Console.ReadLine());
                    double[] Float = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Please enter the {0} float Value", i + 1);
                        Float[i] = double.Parse(Console.ReadLine());
                    }

                    UC_2 maxFloat = new UC_2(Float);
                    maxFloat.MaxValue();
                    //maxFloat.floatMax();
                    break;

                case 3:
                    Console.WriteLine("Please enter out of how many strings you want to find maximum");
                    int a = Convert.ToInt32(Console.ReadLine());
                    string[] str = new string[a];
                    for (int i = 0; i < a; i++)
                    {
                        Console.WriteLine("Please enter the {0} float Value", i + 1);
                        str[i] = Convert.ToString(Console.ReadLine());
                    }

                    UC_3 maxString = new UC_3(str);
                    maxString.MaxValue();
                    //maxString.stringMax();
                    break;

                case 4:
                    Console.WriteLine("Please enter out of how many values you want to find maximum");
                    int b = Convert.ToInt32(Console.ReadLine());
                    dynamic[] genericArray = new dynamic[b];
                    for (int i = 0; i < b; i++)
                    {
                        Console.WriteLine("Please enter the {0} Value", i + 1);
                        genericArray[i] = (dynamic)Console.ReadLine();
                    }

                    Generic<dynamic> array = new Generic<dynamic>(genericArray);
                    array.MaxValue();

                    //Generic<int> intMax = new Generic<int>(100, 10, 125);
                    //Generic<double> floatMax = new Generic<double>(100.20, 100.5, 100.10);
                    //Generic<char> charMax = new Generic<char>('z', 'r', 'c');
                    /*intMax.GenericMax();
                    floatMax.GenericMax();
                    charMax.GenericMax();*/
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }
}

