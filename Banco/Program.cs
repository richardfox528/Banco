using System;

namespace Banco
{
    internal class Program
    {
        static byte meses;
        static readonly string date = DateTime.Now.ToString("dddd dd 'de' MMMM yyyy HH:mm:ss tt 'GMT' K");
        static int cantidad;
        static readonly float interes = 0.07f;
        static float totalCapital = cantidad;
        private static string validateCantidad;
        private static string validateMeses;
        private static bool isNum;

        static void Main(string[] args)
        {
            Console.Title = "Banco de la Republica.";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El Banco de la República está ofertando un programa de inversión que otorga intereses de 0.7% a meses vencidos.\nEsta inversión es a máximo 2.5 años o (30) meses por capital invertido.\n\nEl siguiente es un programa que calculara automáticamente su inversión.");
            Console.Write("\npresione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("LA CANTIDAD DE DINERO ESTÁ OFERTADA A MESES TIEMPO VENCIDO:");

            while (!isNum || cantidad < 1)
            {
                Console.Write("\nINGRESE CANTIDAD DE DINERO A INVERTIR: ");
                validateCantidad = Console.ReadLine();
                isNum = int.TryParse(validateCantidad, out cantidad);
                Console.ForegroundColor = ConsoleColor.Red;
            }
            
            Console.ForegroundColor = ConsoleColor.Blue;
            
            while (!isNum || meses < 1 || meses > 30)
            {
                Console.Write("\nINGRESE CANTIDAD DE MESES A INVERTIR: ");
                validateMeses = Console.ReadLine();
                isNum = byte.TryParse(validateMeses, out meses);
                Console.ForegroundColor = ConsoleColor.Red;
            }
        
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nIngresaste {cantidad:C} a {meses} meses.\n");
            for (var i = 1; i <= meses; i++)
            {
                var ganancias = cantidad * interes;
                cantidad = (int)(cantidad + ganancias);
                totalCapital += ganancias;
                Console.WriteLine($"El capital ganado en {i} mes es: {ganancias:C}");
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nLa ganancia total en {meses} meses es de {totalCapital:C}");
            Console.Write($"Consulta realizada el {date}");
            Console.ReadKey();
        }
    }
}