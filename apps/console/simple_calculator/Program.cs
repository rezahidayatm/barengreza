// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Calculator
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.Clear();
			
			// Program start here
            Calculator();

			// Program ends here
			// Console.ReadLine();
		}

		public static void Calculator()
		{
            Console.WriteLine("Selamat datang di kalkulator sederhana");
            
            bool ulang = true;
            while (ulang) 
            {
                Console.WriteLine("\nSilahkan masukkan input untuk angka pertama");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Silahkan masukkan operator (+, -, *, /)");
                string? op = Console.ReadLine();

                Console.WriteLine("Silahkan masukkan input untuk angka kedua");
                double y = Convert.ToDouble(Console.ReadLine());

                double hasil = 0;
                bool operatorValid = true;

                switch (op)
                {
                    case "+":
                        hasil = x + y;
                        break;
                    case "-":
                        hasil = x - y;
                        break;
                    case "*":
                        hasil = x * y;
                        break;
                    case "/":
                        if (y != 0)
                        { 
                            hasil = x / y;
                        }
                        else
                        {
                            Console.WriteLine($"Error: Tidak bisa membagi dengan {y}!");
                            operatorValid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Error: Operator tidak valid!");
                        operatorValid = false;
                        break;
                }
            
                if (operatorValid)
                {
                    Console.WriteLine($"Hasil dari {x} {op} {y} = {hasil}");
                }

                Console.WriteLine("Ulang kalkulator? Y/n");
                string? ulangiInput = Console.ReadLine();
                if (ulangiInput != "n")
                {
                    continue;
                }
                break;
            }
        }
    }
}

