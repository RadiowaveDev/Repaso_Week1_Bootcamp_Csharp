namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int edad = random.Next(1,65);
            char genero = 'M';
            bool isPeruvian = true;

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

            int weekDay = random.Next(1,8);

            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Hoy es lunes");
                    break;
                case 2:
                    Console.WriteLine("Hoy es martes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es miercoles");
                    break;
                case 4:
                    Console.WriteLine("Hoy es jueves");
                    break;
                case 5:
                    Console.WriteLine("Hoy es viernes");
                    break;
                case 6:
                    Console.WriteLine("Hoy es sabado");
                    break;
                case 7:
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

            /*Escribe un programa en C# para hallar el mayor de 3 numeros*/
            Console.WriteLine("");
            Console.WriteLine("Ingrese el primer numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor = 0;
            if (num2 > num1)
            {
                mayor = num2;
                if (num3 > num2)
                {
                    mayor = num3;
                }
            }
            else if (num1 > num2)
            {
                mayor = num1;
                if (num3 > num1)
                {
                    mayor = num3;
                }
            }
            Console.WriteLine($"El mayor de los tres numeros es {mayor}");

            /* Hallar el area del rectangulo y del circulo*/
            Console.WriteLine("");
            Console.WriteLine("Ingrese el tipo de figura (rectangulo, circulo): ");
            string figura = Console.ReadLine();
            decimal area = 0;
            decimal pi = 3.1416m;
            switch (figura)
            {
                case "rectangulo":
                    Console.WriteLine("Ingrese el valor de la base: ");
                    int Base = Convert.ToInt32(Console.ReadLine()); 
                    Console.WriteLine("Ingrese el valor de la altura");
                    int altura = Convert.ToInt32(Console.ReadLine());
                    area = Base * altura;
                    Console.WriteLine("El area del rectangulo es "+area);
                    break;
                case "circulo":
                    Console.WriteLine("Ingrese el valor del radio: ");
                    decimal radio = Convert.ToInt32(Console.ReadLine());
                    area =  pi* radio * radio;
                    Console.WriteLine("El area del circulo es " + area);
                    break;
                default:
                    Console.WriteLine("Figura geometrica inesperada");
                    break;
            }

            int suma = Add(7, 13);
            Console.WriteLine("Funcion suma static retorna "+suma);
        }

        public static int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
