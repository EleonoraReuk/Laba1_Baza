using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            Console.WriteLine("Вычисление a^n, используя только умножение");
            Console.Write("Введите число a (натуральное число): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите степень n (натуральное число): ");
            int n = int.Parse(Console.ReadLine());

            long result = Multiplication(a, n);
            Console.WriteLine($"{a}^{n} = {result}\n");


            //#2
            Console.WriteLine("Преобразование числа x в число n");
            Console.Write("Введите число x (x >= 100): ");
            int x = int.Parse(Console.ReadLine());

            if (x < 100)
            {
                Console.WriteLine("Ошибка: x >= 100");
            }
            else
            {
                int XtransformationToN = TransformationNumber(x);
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"n = {XtransformationToN}");
            }

        }

        static long Multiplication(int a, int n)
        {
            if (n == 0)
                return 1;
            long result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            return result;
        }

        static int TransformationNumber(int x)
        {
            string xString = x.ToString();

            char secondNumber = xString[1];

            string first = xString[0] + xString.Substring(2);
            string resultString = first + secondNumber;

            return int.Parse(resultString);
        }
    }
}