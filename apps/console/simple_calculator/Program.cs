// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Calculator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			RunCalculator();
		}

		public static void RunCalculator()
		{
            Console.WriteLine("Selamat datang di kalkulator sederhana");
            
            while (true) 
            {
                var num1 = GetNumber("\nSilahkan masukkan input untuk angka pertama:");
                var op = GetOperator("Silahkan masukkan operator (+, -, *, /):");
                var num2 = GetNumber("Silahkan masukkan input untuk angka kedua:");

                try
                {
                    var result = PerformCalculation(num1, num2, op);
                    Console.WriteLine($"Hasil dari {num1} {op} {num2} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nUlang kalkulator? (Y/n)");
                if (Console.ReadLine()?.ToLower() == "n")
                {
                    break;
                }
            }
        }

        private static double GetNumber(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                if (double.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
                Console.WriteLine("Error: Input tidak valid. Silahkan masukkan angka.");
            }
        }

        private static string GetOperator(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var op = Console.ReadLine();
                if (op is "+" or "-" or "*" or "/")
                {
                    return op;
                }
                Console.WriteLine("Error: Operator tidak valid. Gunakan +, -, *, atau /.");
            }
        }

        private static double PerformCalculation(double num1, double num2, string op)
        {
            return op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" when num2 != 0 => num1 / num2,
                "/" when num2 == 0 => throw new DivideByZeroException("Tidak bisa membagi dengan nol."),
                _ => throw new ArgumentException("Operator tidak valid.", nameof(op))
            };
        }
    }
}
