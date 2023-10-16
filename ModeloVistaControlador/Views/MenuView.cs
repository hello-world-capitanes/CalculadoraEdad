using System;


namespace ModeloVistaControlador.Views
{
    public class MenuView
    {
        public void ShowWelCome()
        {
            Console.WriteLine("***  ¡Bienvenido a las prácticas de MVC! ***");
        }

        public string GetNameInput()
        {
            Console.Write("\n***  ¿Cómo te llamas?: ");
            string name = Console.ReadLine();

            if (!String.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                Console.WriteLine("\n***  Por favor, introduce un nombre: ");
                return GetNameInput();
            }
        }

        public void ShowName(string name)
        {
            Console.WriteLine($"***  Encantado, {name} ***");
        }

        public int ShowMenuAndGetChoice(string name)
        {
            Console.WriteLine("\n************************************");
            Console.WriteLine("***  Menú principal:  ***");
            Console.WriteLine("***  1. Calculadora de edad ***");
            Console.WriteLine("***  2. Cambiar nombre ***");
            Console.WriteLine("***  3. Salir ***");
            Console.Write($"***  ¿Qué opción quieres, {name}?: ");

            if (int.TryParse(Console.ReadLine(), out int option) && (option > 0 &&  option <= 3))
            {
                return option;
            }
            else
            {
                Console.WriteLine("\n***  Entrada inválida. Por favor, introduce un número de opción válida. ***");
                return ShowMenuAndGetChoice(name);
            }
        }

        public void ShowDespedida(string name)
        {
            Console.WriteLine($"\n***  ¡Hasta pronto, {name}! ***");
            Console.WriteLine("*** Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
