using System;

namespace Calculadora_de_edad
{
    static class Mods
    {

        public static void CalculaEdadBasic()
        {

            Console.WriteLine("***  Calcula edad ***");
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimientoStr = Console.ReadLine();
            // Convertir la entrada del usuario en un objeto DateTime
            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Calcular la diferencia en años, meses y días
                int edadAnios = fechaActual.Year - fechaNacimiento.Year;
                int edadMeses = fechaActual.Month - fechaNacimiento.Month;
                int edadDias = fechaActual.Day - fechaNacimiento.Day;

                // Ajustar la edad si el día y mes de nacimiento es posterior al actual
                if (edadMeses < 0 || (edadMeses == 0 && edadDias < 0))
                {
                    edadAnios--;
                    edadMeses += 12;
                }

                // Imprimir la edad calculada
                Console.WriteLine($"Su edad es: {edadAnios} años, {edadMeses} meses y {edadDias} días.");
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
            }
        }

        public static void CalculaEdadFutura()
        {
            Console.WriteLine("***  Calcula edad futura ***");
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimientoStr = Console.ReadLine();
            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                Console.Write("Ingrese la fecha futura para calcular la edad (dd/mm/aaaa): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFutura))
                {
                    TimeSpan diferencia = fechaFutura - fechaNacimiento;
                    int edadAnios = (int)(diferencia.TotalDays / 365.25);
                    Console.WriteLine($"Su edad en la fecha futura es de {edadAnios} años.");
                }
                else
                {
                    Console.WriteLine("Fecha futura inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
            }

        }

        public static void CalculaEdadFormatoOptimizado()
        {
            Console.WriteLine("***  Calcula edad formato optimizado ***");
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
            string fechaNacimientoStr = Console.ReadLine();
            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                Console.Write("Elija el formato de visualización de edad (años/meses - 'am' o solo años - 'a'): ");
                string formatoElegido = Console.ReadLine().ToLower();

                int edadAnios = Utils.CalcularEdadEnAnios(fechaNacimiento);
                int edadMeses = Utils.CalcularEdadEnMeses(fechaNacimiento);

                switch (formatoElegido)
                {
                    case "am":
                        Console.WriteLine($"Su edad es de {edadAnios} años o {edadMeses} meses.");
                        break;
                    case "a":
                        Console.WriteLine($"Su edad es de {edadAnios} años.");
                        break;
                    default:
                        Console.WriteLine("Formato de visualización no válido. Use 'am' o 'a'.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
            }

        }

        public static void CalculaEdadFechaExacta()
        {
            Console.WriteLine("***  Calcula edad con fecha exacta ***");
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa hh:mm:ss): ");
            string fechaNacimientoStr = Console.ReadLine();
            if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                TimeSpan diferencia = DateTime.Now - fechaNacimiento;
                int anios = diferencia.Days / 365;
                int meses = (diferencia.Days % 365) / 30;
                int dias = (diferencia.Days % 365) % 30;
                int horas = diferencia.Hours;
                int minutos = diferencia.Minutes;
                int segundos = diferencia.Seconds;

                Console.WriteLine($"Su edad exacta es: {anios} años, {meses} meses, {dias} días, {horas} horas, {minutos} minutos, {segundos} segundos.");
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa hh:mm:ss.");
            }

        }

        public static void CalculaEdadConversion()
        {
            Console.WriteLine("***  Calcula edad conversión ***");
            // Solicitar la fecha de nacimiento al usuario
            Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
            {
                Console.Write("Ingrese la fecha actual (dd/mm/aaaa): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaActual))
                {
                    TimeSpan diferencia = fechaActual - fechaNacimiento;
                    int edadAnios = (int)(diferencia.TotalDays / 365.25);

                    Console.WriteLine($"Su edad en años es de {edadAnios} años.");

                    // Conversión de edad a otras unidades de tiempo
                    Console.WriteLine($"Su edad en meses es de {edadAnios * 12} meses.");
                    Console.WriteLine($"Su edad en semanas es de {edadAnios * 52} semanas.");
                    Console.WriteLine($"Su edad en días es de {edadAnios * 365} días.");
                }
                else
                {
                    Console.WriteLine("Fecha actual inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }
            }
            else
            {
                Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
            }
        }

        public static void CalculaEdadConValidacion()
        {
            Console.WriteLine("***  Calcula edad con validación ***");

            DateTime fechaNacimiento = Utils.ObtenerFechaNacimientoValida();

            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la diferencia en años, meses y días
            int edadAnios = fechaActual.Year - fechaNacimiento.Year;
            int edadMeses = fechaActual.Month - fechaNacimiento.Month;
            int edadDias = fechaActual.Day - fechaNacimiento.Day;

            // Ajustar la edad si el día y mes de nacimiento es posterior al actual
            if (edadMeses < 0 || (edadMeses == 0 && edadDias < 0))
            {
                edadAnios--;
                edadMeses += 12;
            }

            // Imprimir la edad calculada
            Console.WriteLine($"Su edad es: {edadAnios} años, {edadMeses} meses y {edadDias} días.");
        }

        public static void CalculaEdadOtrosPlanetas()
        {
            Console.WriteLine("***  Calcula edad en otros planetas ***");

            DateTime fechaNacimiento = Utils.ObtenerFechaNacimientoValida();

            Console.WriteLine("Seleccione el planeta para calcular la edad:");
            Console.WriteLine("1. Mercurio");
            Console.WriteLine("2. Venus");
            Console.WriteLine("3. Marte");
            Console.WriteLine("4. Júpiter");
            Console.WriteLine("5. Saturno");
            Console.WriteLine("6. Urano");
            Console.WriteLine("7. Neptuno");
            Console.Write("Ingrese el número del planeta: ");
            if (int.TryParse(Console.ReadLine(), out int seleccion))
            {
                double edadPlaneta = Utils.CalcularEdadEnPlaneta(fechaNacimiento, seleccion);
                Console.WriteLine($"Su edad en ese planeta es aproximadamente {edadPlaneta:F2} años.");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número de planeta válido.");
            }

        }

    }
}
