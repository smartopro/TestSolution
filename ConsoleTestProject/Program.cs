using System;

namespace ConsoleTestProject
{
    class Program
    {
        // delegate
        delegate int Operation(int x, int y);

        static int Sum (int a, int b)
        {
            return a + b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите операцию: ");
            char ch = Console.ReadKey().KeyChar;

            Operation op;

            switch (ch)
            {
                case '+':
                    op = Sum;
                    break;
                case '*':
                    op = Mul;
                    break;
                default:
                    Console.WriteLine("Ошибка ввода.");
                    op = null;
                    break;
            }

            int res = op(5, 10);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
