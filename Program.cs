using System;

class Program
{
    static void Main(string[] args)
    {
        // Лямбда-вирази для кожного випадку
        Func<double, double> positiveCase = x => 1 / x;
        Func<double, double> negativeCase = x => x * x + 2 * x + 4;
        Func<double, double> zeroCase = x => 4.0;

        // Введення значення x
        Console.Write("Введіть значення x: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            double result;

            // Обчислення значення F(x) залежно від x
            if (x > 0)
            {
                result = positiveCase(x);
            }
            else if (x < 0)
            {
                result = negativeCase(x);
            }
            else
            {
                result = zeroCase(x);
            }

            // Вивід результату
            Console.WriteLine($"F({x}) = {result}");
        }
        else
        {
            Console.WriteLine("Введено некоректне число.");
        }
    }
}
