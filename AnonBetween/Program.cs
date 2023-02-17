using System;

namespace AnonBetween
{
    public delegate int AddDelegate(int a, int b, int c);
    class Program
    {
        static void Main(string[] args)
                           
        {
            Console.WriteLine("Введите 3 параметра:");

            int val1 = Int32.Parse(Console.ReadLine());
            int val2 = Int32.Parse(Console.ReadLine());
            int val3 = Int32.Parse(Console.ReadLine());


            AddDelegate aD = new AddDelegate(delegate
                (int number1 , int number2 , int number3)
            {
                int result = (number1 + number2 + number3) / 3;

                return result;
            });

            int serarif = aD(val1, val2, val3);

            Console.WriteLine("Среднее арифметическое параметров = " + serarif);
        }
    }
}
