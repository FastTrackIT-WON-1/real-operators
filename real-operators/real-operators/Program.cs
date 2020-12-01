using System;

namespace real_operators
{
    class Program
    {
        static float MinusZero = -0F;
        static float PlusZero = 0F;

        static void Main(string[] args)
        {
            SumFloat(10, 20);
            SumFloat(10.5F, 20.2F);
            SumFloat(MinusZero, PlusZero);
            SumFloat(float.NaN, 10);
            SumFloat(float.NaN, float.PositiveInfinity);
            SumFloat(float.PositiveInfinity, float.PositiveInfinity);
            SumFloat(float.PositiveInfinity, float.NegativeInfinity);
            SumFloat(float.NegativeInfinity, float.NegativeInfinity);

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            DivFloat(20, 10);
            DivFloat(2, 0.5F);
            DivFloat(2, PlusZero);
            DivFloat(2, MinusZero);
            DivFloat(PlusZero, MinusZero);
            DivFloat(MinusZero, PlusZero);

            // ---------------------------------------------
            PrintSeparator();
            // ---------------------------------------------

            /* Why this code doesn't work as expected? */
            float a = 100;
            float b = -0;
            float x = a / b;

            // This should be -∞
            Console.WriteLine(x);
        }

        static void PrintSeparator()
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 70));
            Console.WriteLine();
        }

        static void SumFloat(float a, float b)
        {
            float sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        static void SumDouble(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        static void SumDecimal(decimal a, decimal b)
        {
            decimal sum = a + b;
            Console.WriteLine($"{a} + {b} = {sum}");
        }

        static void DivFloat(float a, float b)
        {
            float div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");
        }

        static void DivDouble(double a, double b)
        {
            double div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");
        }

        static void DivDecimal(decimal a, decimal b)
        {
            decimal div = a / b;
            Console.WriteLine($"{a} / {b} = {div}");
        }
    }
}
