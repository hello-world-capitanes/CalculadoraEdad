using System;

namespace Calculadora_de_edad
{
    public static class Utils
    {
        public static int CalcularEdadEnAnios(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }

        public static int CalcularEdadEnMeses(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edadMeses = (fechaActual.Year - fechaNacimiento.Year) * 12 + fechaActual.Month - fechaNacimiento.Month;
            if (fechaActual.Day < fechaNacimiento.Day)
            {
                edadMeses--;
            }
            return edadMeses;
        }

        public static DateTime ObtenerFechaNacimientoValida()
        {
            DateTime fechaNacimiento;
            while (true)
            {
                Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                {
                    if (EsFechaValida(fechaNacimiento))
                    {
                        return fechaNacimiento;
                    }
                    else
                    {
                        Console.WriteLine("Fecha de nacimiento inválida. Debe ser una fecha pasada.");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }
            }
        }

        static bool EsFechaValida(DateTime fecha)
        {
            // Verificar si la fecha es anterior a la fecha actual (no en el futuro)
            return fecha <= DateTime.Now;
        }

        public static double CalcularEdadEnPlaneta(DateTime fechaNacimiento, int seleccion)
        {
            TimeSpan edad = DateTime.Now - fechaNacimiento;
            double edadEnAnios = edad.TotalDays / 365.25;

            switch (seleccion)
            {
                case 1: // Mercurio
                    return edadEnAnios / 0.2408467;
                case 2: // Venus
                    return edadEnAnios / 0.61519726;
                case 3: // Marte
                    return edadEnAnios / 1.8808158;
                case 4: // Júpiter
                    return edadEnAnios / 11.862615;
                case 5: // Saturno
                    return edadEnAnios / 29.447498;
                case 6: // Urano
                    return edadEnAnios / 84.016846;
                case 7: // Neptuno
                    return edadEnAnios / 164.79132;
                default:
                    return -1; // Valor no válido
            }
        }


    }
}
