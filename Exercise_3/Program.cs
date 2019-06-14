using System;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputA;
            double y = 0;

            while (true)
            {
                Console.WriteLine("Введите число:");
                while (true)
                {
                    if (double.TryParse(Console.ReadLine(), out inputA))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод. Введите корректные данные:");
                    }
                }

                if (inputA < -1)
                {
                    y = -1 / (inputA * inputA);
                }
                else if (inputA >= -1 && inputA <= 2)
                {
                    y = inputA * inputA;
                }
                else if (inputA > 2)
                {
                    y = 4;
                }

                Console.WriteLine($"f({inputA}) = {y}");
            }
        }
    }
}
