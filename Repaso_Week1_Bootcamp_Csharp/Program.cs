namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int edad = random.Next(1,65);
            double numdecimal = 11.3;
            char genero = 'M';
            bool isPeruvian = true;
            string name = "Umbrella";

            if(edad >= 18 && genero.Equals('M') && isPeruvian)
            {
                Console.WriteLine("Tengo " + edad + " años");
                Console.WriteLine("Soy un hombre peruano mayor de edad");
            }
            else
            {
                Console.WriteLine("Tengo " + edad + " años");
                Console.WriteLine("No soy un hombre peruano mayor de edad");
            }

            string weekDay = "lunes";

            switch (weekDay)
            {
                case "lunes":
                    Console.WriteLine($"Hoy es lunes");
                    break;
                case "martes":
                    Console.WriteLine("Hoy es martes");
                    break;
                case "miercoles":
                    Console.WriteLine("Hoy es miercoles");
                    break;
                case "jueves":
                    Console.WriteLine("Hoy es jueves");
                    break;
                case "viernes":
                    Console.WriteLine("Hoy es viernes");
                    break;
                case "sabado":
                    Console.WriteLine("Hoy es sabado");
                    break;
                case "domingo":
                    Console.WriteLine("Hoy es domingo");
                    break;
                default:
                    Console.WriteLine("No es un dia de la semana");
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("Ingrese el valor a evaluar: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number%2 == 0)
            {
                Console.WriteLine($"El numero {number} es par");
            }
            else
            {
                Console.WriteLine($"El numero {number} es impar");
            }
            
        }
    }
}
