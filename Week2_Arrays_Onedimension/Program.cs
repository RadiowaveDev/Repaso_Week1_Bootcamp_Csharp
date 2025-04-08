namespace Week2_Arrays_Onedimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array unidimensionales");
            Console.WriteLine("=========================");

            //1.1.Declarar y inicializar array
            Console.WriteLine("Declarar y inicializar");
            int[] numeros = new int[5];
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            //1.2. Declarar e inicializar en 1 linea
            int[] otrosNumeros = new int[] { 10, 20, 30, 40, 50 };

            //1.3. Inicializacion implicita
            string[] nombres = { "Ana", "Juan", "Pedro", "Maria","Luis" };

            //2. Acceso a elementos
            Console.WriteLine("2.Acceso a los elementos:");
            Console.WriteLine($"El primer numero es: {numeros[0]}");
            Console.WriteLine($"El tercer nombre es: {numeros[2]}");
            Console.WriteLine($"El ultimo nombre es: {numeros[numeros.Length-1]}");

            //3.Longitud del array
            Console.WriteLine("Longitud del array: ");
            Console.WriteLine("El array numeros tiene como longitud"+ numeros.Length);

            //4.Recorrer la longitu del array
            Console.WriteLine("Recorrer el array con for:");
            for(int i=0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Indice {i}: {nombres[i]}");
            }

            //5.Recorrer con for each
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // 6. Operaciones comunes
            Console.WriteLine("\n6. Operaciones comunes:");

            // Sumar todos los elementos
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            Console.WriteLine($"La suma de todos los números es: {suma}");

            // Encontrar el valor máximo
            int maximo = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                    maximo = numeros[i];
            }
            Console.WriteLine($"El valor máximo es: {maximo}");

            // 7. Métodos de Array
            Console.WriteLine("\n7. Métodos del Array:");

            // Ordenar un array
            int[] desordenados = { 5, 2, 8, 1, 9 };
            Console.Write("Array desordenado: ");
            foreach (int num in desordenados)
                Console.Write($"{num} ");

            Array.Sort(desordenados);
            Console.Write("\nArray ordenado: ");
            foreach (int num in desordenados)
                Console.Write($"{num} ");

            // Invertir un array
            Array.Reverse(desordenados);
            Console.Write("\nArray invertido: ");
            foreach (int num in desordenados)
                Console.Write($"{num} ");

            // Buscar en un array
            string[] frutas = { "manzana", "pera", "naranja", "plátano", "uva" };
            int indice = Array.IndexOf(frutas, "naranja");
            Console.WriteLine($"\nLa naranja está en el índice: {indice}");

            // Copiar un array
            int[] copiaNumeros = new int[numeros.Length];
            Array.Copy(numeros, copiaNumeros, numeros.Length);
            Console.Write("\nArray copiado: ");
            foreach (int num in copiaNumeros)
                Console.Write($"{num} ");

            Console.WriteLine("\n");


            /*Reto: Sistemas de calificaciones
             Objetivo: Desarrollar un programa que gestione las calificaciones de estudiantes y que 
            realice diferentes operaciones estadisticas:
            1. Crear un array para almacenar las calificaciones de 10 estudiantes (valores entre 0 y 100)
            2. Implementar las siguientes funcionalidades
             F1:    Calcular el promedio de calificaciones
             F2:    Encontrar la calificacion mas alta y mas baja
             F3:    Calcular cuantos estudiantes aprobaron (calificacion >=60)
             F4:    Mostrar las calificaciones en orden ascendentes
             F5:    Mostrar cuantos estudiantes obtuvieron calificaciones en los siguientes rangos
             */


        }
    }
}
