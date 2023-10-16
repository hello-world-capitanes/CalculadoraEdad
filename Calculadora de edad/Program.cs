using System;

namespace Calculadora_de_edad
{
    class Program
    {
        static void Main()
        {
            InitApp();

            string response = string.Empty;

            while(!response.ToUpper().Equals("N"))
            {
                Console.WriteLine("\n");
                Console.Write("*** ¿Quieres probar otra opción? [S/N]:");
                response = Console.ReadLine();
                Console.WriteLine("\n");
                InitApp();
            }
            
            Console.WriteLine("*** Presiona una tecla para salir...");
            Console.ReadKey();
            
        }

        private static void InitApp()
        {
            Console.WriteLine("***  Bienvenido a la calculadora de edad. ¿Qué opción quieres probar? ***");
            Console.WriteLine("1. Calculadora de edad");
            Console.WriteLine("2. Calculadora de edad futura");
            Console.WriteLine("3. Calculadora de edad con formato optimizado");
            Console.WriteLine("4. Calculadora de edad de fecha exacta");
            Console.WriteLine("5. Calculadora de edad con conversión a años meses y días.");
            Console.WriteLine("6. Calculadora de edad con validación de formato. ");
            Console.WriteLine("7. Calculadora de edad en otros planetas.");
            Console.Write("¿Qué opción quieres probar?: ");

            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {

                switch (seleccion)
                {
                    case 1:
                        Mods.CalculaEdadBasic();
                        break;
                    case 2:
                        Mods.CalculaEdadFutura();
                        break;
                    case 3:
                        Mods.CalculaEdadFormatoOptimizado();
                        break;
                    case 4:
                        Mods.CalculaEdadFechaExacta();
                        break;
                    case 5:
                        Mods.CalculaEdadConversion();
                        break;
                    case 6:
                        Mods.CalculaEdadConValidacion();
                        break;
                    case 7:
                        Mods.CalculaEdadOtrosPlanetas();
                        break;
                    default:
                        Console.WriteLine("Entrada inválida. Ingrese un número de opción válida.");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número de planeta válido.");
            }
        }
    }

}
