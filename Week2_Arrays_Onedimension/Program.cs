using System.Diagnostics.CodeAnalysis;

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
             F5:    Mostrar cuantos estudiantes obtuvieron calificaciones en los siguientes rangos:
                     * 0-59 (Reprobado)
                     * 60-69 (Suficiente)
                     * 70-79 (Bien)
                     * 80-89 (Notable)
                     * 90-100 (Excelente)
             */
            int[] grades = { 45, 55,65,70,85,81,79,69,52,91};
            int acum = SumElements(grades);
            int gradeAverage = acum / grades.Length;
            int least = leastElement(grades);
            int biggest = biggestElement(grades);
            int aprobados=approvedStudents(grades);
            Console.WriteLine("========= Reto1: Sistemas de calificaciones ==============");
            Console.WriteLine($"La nota promedio de los {grades.Length} es {gradeAverage}");
            Console.WriteLine($"La nota más baja de la clase es de {least}");
            Console.WriteLine($"La nota más alta de la clase es de {biggest}");
            Console.WriteLine($"Cantidad de alumnos aprobados: " + aprobados);
            ordenarArray(grades);
            rangoAlumnos(grades);
        }

        public static int SumElements(int[] arrays)
        {
            int sum = 0;
            foreach (int array in arrays)
            {
                sum += array;
            }
            return sum; 
        }

        public static int leastElement(int[] arrays)
        {
            int minimo = arrays[0];
            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] < minimo)
                    minimo = arrays[i];
            }
            return minimo;
        }
        public static int biggestElement(int[] arrays)
        {
            int maximo = arrays[0];
            for (int i = 1; i < arrays.Length; i++)
            {
                if (arrays[i] > maximo)
                    maximo = arrays[i];
            }
            return maximo;
        }
        public static int approvedStudents(int[] arrays)
        {
            int cont = 0;
            foreach (int array in arrays)
            {
                if (array >= 60)
                {
                    cont++;
                }
            }
            return cont;
        }
        public static void ordenarArray(int[] arrays)
        {
            Array.Sort(arrays);
            Console.Write("Notas ordenadas: ");
            foreach (int array in arrays)
                Console.Write($"{array} ");
        }
        public static void rangoAlumnos(int[] arrays)
        {
            int numReprobado = 0;
            int numSuficiente = 0;
            int numBien = 0;
            int numNotable = 0;
            int numExcelente = 0;

            foreach (int array in arrays)
            {
                if (array < 60)
                {
                    numReprobado += 1;
                }else if(array>=60 && array < 70)
                {
                    numSuficiente += 1;
                }else if(array>=70 && array < 80)
                {
                    numBien += 1;  
                }else if(array>=80 && array < 90)
                {
                    numNotable += 1;
                }else if(array<=90 && array <= 100)
                {
                    numExcelente += 1;
                }
            }
            Console.WriteLine("\nRango de notas de alumnos");
            Console.WriteLine($"El numero de notas excelentes es {numExcelente}");
            Console.WriteLine($"El numero de notas notables es {numNotable}");
            Console.WriteLine($"El numero de notas bien es {numBien}");
            Console.WriteLine($"El numero de notas suficientes es {numSuficiente}");
            Console.WriteLine($"El numero de notas reprobadas es {numReprobado}");
        }
    }
}
