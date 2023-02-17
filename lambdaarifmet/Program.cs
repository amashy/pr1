using System;


namespace lambdaarifmet
{
    public delegate int SomeDelegate (int a, int b);
     class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
            
            Console.WriteLine("Value 1 = ");
            int o = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Value 2 = ");
            int b = Int32.Parse(Console.ReadLine());    

            Console.WriteLine("'-' , '+' , '*' , '/'");

            string action = Console.ReadLine();

                switch (action)
                {
                    case "-":

                        SomeDelegate Sub = (s, d) =>
                        {
                            int result = s - d;

                            return result;
                        };

                        int c = Sub(o, b);

                        Console.WriteLine(c);

                        Console.ReadKey();
                        break;

                    case "+":

                        SomeDelegate Add = (s, d) =>
                        {
                            int result = s + d;

                            return result;
                        };

                        int q = Add(o, b);

                        Console.WriteLine(q);

                        Console.ReadKey();

                        break;

                    case "*":

                        SomeDelegate Mul = (s, d) =>
                        {
                            int result = s * d;

                            return result;
                        };

                        int j = Mul(o, b);

                        Console.WriteLine(j);

                        Console.ReadKey();

                        break;
                    case "/":

                        if (b != 0)
                        {

                            SomeDelegate Div = (s, d) =>
                            {
                                int result = s / d;

                                return result;
                            };

                            int k = Div(o, b);

                            Console.WriteLine(k);

                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Только не 0");
                        }

                        break;
                }
            }
                    
        
        }
    }
}
