namespace While_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a los bucle While");
            //Escribir bucle infinito
            /*int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine("El valor de contador es "+ contador);
                contador++;
            }*/

            //Tabla de multiplicar
            int contadorTabla = 1;
            Console.WriteLine("Ingrese el valor de la tabla de multiplicar");
            int valorTabla=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"======= Tabla del {valorTabla} =========");
            while (contadorTabla<=12)
            {
                int resultado = valorTabla * contadorTabla;
                Console.WriteLine(valorTabla+" * "+contadorTabla+" = "+resultado);
                contadorTabla++;
            }

            // Imprimir cuadrado con patrones del 1 al 5
            Console.WriteLine("");
            Console.WriteLine("Patron del 1 al 5");
            int inicio =1;
            while(inicio<=5)
            {
                int b = 1;
                while(b<=5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                inicio++;
            }

            //Ejercicio de While loop 
            /* 1****
               12***
               123**
               1234*
               12345
             */
            Console.WriteLine("");
            Console.WriteLine("Patron numeros y asteriscos");
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (i < j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(i);
                    }

                        j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
