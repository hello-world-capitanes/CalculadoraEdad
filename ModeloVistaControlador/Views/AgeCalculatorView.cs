using ModeloVistaControlador.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloVistaControlador
{
    public class AgeCalculatorView
    {

        public DateTime GetBirthDateInput()
        {
            Console.Write("\n***  Ingresa la fecha de nacimiento (dd/mm/aaaa): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                return birthDate;
            }
            else
            {
                Console.WriteLine("\n***  Fecha de nacimiento inválida. Inténtalo de nuevo. ***");
                return GetBirthDateInput();
            }
        }

        public int ShowMenuCalculateAgeAndGetChoice()
        {
            Console.WriteLine("\n*** Opciones: ***");
            Console.WriteLine("*** 1. Mostrar edad en años ***");
            Console.WriteLine("*** 2. Mostrar edad en años, meses y días ***");
            Console.Write("\n*** Elige una opción: ");

            if (int.TryParse(Console.ReadLine(), out int option) && (option > 0 && option <= 2))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                return ShowMenuCalculateAgeAndGetChoice();
            }
        }

        public int ShowMainMenuAndGetChoice()
        {
            Console.WriteLine("\n*** Opciones: ***");
            Console.WriteLine("*** 1. Calculadora de edad");
            Console.WriteLine("*** 2. Calculadora de edad en otros planetas ***");
            Console.WriteLine("*** 3. Cambiar fecha de nacimiento ***");
            Console.WriteLine("*** 4. Salir al menú principal ***");
            Console.Write("\n*** Elige una opción: ");

            if (int.TryParse(Console.ReadLine(), out int option) && (option > 0 && option <= 4))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                return ShowMenuCalculateAgeAndGetChoice();
            }
        }

        public void CalculateAgeOnOtherPlanets(UserModel personModel)
        {
            Console.WriteLine("***  Calcula edad en otros planetas ***");

            Console.WriteLine("Seleccione el planeta para calcular la edad:");
            Console.WriteLine("1. Mercurio");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Marte");
            Console.WriteLine("4. Júpiter");
            Console.WriteLine("5. Saturno");
            Console.WriteLine("6. Urano");
            Console.WriteLine("7. Neptuno");
            Console.Write("Ingrese el número del planeta: ");
            if (int.TryParse(Console.ReadLine(), out int option))
            {
                double edadPlaneta = CalculateAgeOnPlanet(personModel.BirthDate, option);
                Console.WriteLine($"Su edad en ese planeta es aproximadamente {edadPlaneta:F2} años.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número de planeta válido.");
            }

        }

        public static double CalculateAgeOnPlanet(DateTime birthDate, int option)
        {
            TimeSpan edad = DateTime.Now - birthDate;
            double ageInYears = edad.TotalDays / 365.25;

            switch (option)
            {
                case 1: // Mercurio
                    return ageInYears / 0.2408467;
                case 2: // Venus
                    return ageInYears / 0.61519726;
                case 3: // Marte
                    return ageInYears / 1.8808158;
                case 4: // Júpiter
                    return ageInYears / 11.862615;
                case 5: // Saturno
                    return ageInYears / 29.447498;
                case 6: // Urano
                    return ageInYears / 84.016846;
                case 7: // Neptuno
                    return ageInYears / 164.79132;
                default:
                    return -1; // Valor no válido
            }
        }

        public void ShowAge(AgeModel age)
        {
            string message = $"La edad es: {age.years} años";

            if (age.months != 0)
            {
                message += $", {age.months} meses, y {age.days} días.";
            } 

            Console.WriteLine(message);
        }
    }
}
