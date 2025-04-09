namespace Week1_Switch_IfElse_Statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF - ELSE
            Console.WriteLine("");
            Console.WriteLine("=============== CODIGO DE IF ELSE =====================");
            Random random = new Random();                   //Instancia de objeto de clase Random
            int edad = random.Next(1, 66);
            Console.WriteLine("Mi edad es de " + edad);
            if (edad >= 18)
            {
                Console.WriteLine("Soy mayor de edad");
            }
            else
            {
                Console.WriteLine("Soy menor de edad");
            }

            int calificacion = random.Next(0, 20);
            Console.WriteLine("Tu nota es de " + calificacion);
            if (calificacion >= 18)
            {
                Console.WriteLine("Tu nota es sobresaliente");
            }
            else if (calificacion >= 14)
            {
                Console.WriteLine("Tu nota es buena");
            }
            else if (calificacion >= 10)
            {
                Console.WriteLine("Tu nota debe mejorar");
            }
            else
            {
                Console.WriteLine("Estas jalado");
            }

            Console.WriteLine(5 / 10);
            /*  Reto 02 de abril: Calculadora en C# con sentencias if/else */
            Console.WriteLine("");
            Console.WriteLine("===================== CALCULADORA EN C# ==================");
            Console.WriteLine("Ingrese el primer número: ");
            double number1 = Convert.ToDouble(Console.ReadLine()); //Lee string y convierte string en double
            Console.WriteLine("Ingrese el segundo número: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la operación: (+,-,*,/)");
            char operation = Console.ReadLine()[0];                 //Lee string y captura caracter de orden 0
            double result = 0;                                      //declaracion de result

            if (operation == '+')
            {
                result = number1 + number2;
                Console.WriteLine($"La suma de {number1} y {number2} es: {result}");   //interpolacion de cadenas
            }
            else if (operation == '-')
            {
                result = number1 - number2;
                Console.WriteLine($"La diferencia entre {number1} y {number2} es: {result}");
            }
            else if (operation == '*')
            {
                result = number1 * number2;
                Console.WriteLine($"El producto de {number1} y {number2} es: {result}");
            }
            else if (operation == '/')
            {
                if (number2 != 0)
                {
                    result = number1 / number2;
                    Console.WriteLine($"La división de {number1} entre {number2} es: {result}");
                }
                else
                {
                    Console.WriteLine("La división entre cero no esta definida");
                }
            }
            else
            {
                Console.WriteLine("La operación no es válida");
            }
        }
    }
}
