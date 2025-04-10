using System;

namespace Week2_Array_Multidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS MULTIDIMENSIONALES EN C#");
            Console.WriteLine("==============================");

            // 1. ARRAYS BIDIMENSIONALES (MATRICES)
            Console.WriteLine("1. Arrays Bidimensionales (Matrices):");

            // Declaración e inicialización de una matriz 3x3
            int[,] matriz = new int[3, 3];

            // Asignar valores a la matriz
            matriz[0, 0] = 1; matriz[0, 1] = 2; matriz[0, 2] = 3;
            matriz[1, 0] = 4; matriz[1, 1] = 5; matriz[1, 2] = 6;
            matriz[2, 0] = 7; matriz[2, 1] = 8; matriz[2, 2] = 9;

            // Inicialización directa de una matriz
            int[,] otraMatriz = new int[,] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            // Obtener dimensiones de la matriz
            Console.WriteLine("\nDimensiones de la matriz:");
            Console.WriteLine($"Número de dimensiones: {matriz.Rank}");
            Console.WriteLine($"Filas (Dimensión 0): {matriz.GetLength(0)}");
            Console.WriteLine($"Columnas (Dimensión 1): {matriz.GetLength(1)}");
            Console.WriteLine($"Total de elementos: {matriz.Length}");

            // Recorrer una matriz con bucles anidados
            Console.WriteLine("\nRecorrido de la matriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }

            // 2. ARRAYS TRIDIMENSIONALES
            Console.WriteLine("\n2. Arrays Tridimensionales:");

            // Declaración e inicialización de un array 3D (2x3x2)
            int[,,] array3D = new int[2, 3, 2] {
            { // Primer "página"
                { 1, 2 }, // Primera fila
                { 3, 4 }, // Segunda fila
                { 5, 6 }  // Tercera fila
            },
            { // Segunda "página"
                { 7, 8 },
                { 9, 10 },
                { 11, 12 }
            }
        };

            // Recorrer un array 3D
            Console.WriteLine("\nRecorrido del array 3D:");
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                Console.WriteLine($"Página {i + 1}:");
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        Console.Write($"{array3D[i, j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // 3. ARRAYS ESCALONADOS (JAGGED ARRAYS)
            Console.WriteLine("3. Arrays Escalonados (Jagged Arrays):");

            // Declaración de un array escalonado (array de arrays)
            int[][] arrayEscalonado = new int[3][];

            // Inicialización de cada "fila" con diferentes tamaños
            arrayEscalonado[0] = new int[] { 1, 2 };            // Primera fila con 2 elementos
            arrayEscalonado[1] = new int[] { 3, 4, 5, 6 };      // Segunda fila con 4 elementos
            arrayEscalonado[2] = new int[] { 7, 8, 9 };         // Tercera fila con 3 elementos

            // Recorrer un array escalonado
            Console.WriteLine("\nRecorrido del array escalonado:");
            for (int i = 0; i < arrayEscalonado.Length; i++)
            {
                Console.Write($"Fila {i}: ");
                for (int j = 0; j < arrayEscalonado[i].Length; j++)
                {
                    Console.Write($"{arrayEscalonado[i][j]} ");
                }
                Console.WriteLine();
            }

            // 4. OPERACIONES CON MATRICES
            Console.WriteLine("\n4. Operaciones con matrices:");

            // Sumar dos matrices
            int[,] matrizA = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] matrizB = new int[,] { { 5, 6 }, { 7, 8 } };
            int[,] matrizSuma = new int[2, 2];

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizSuma[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Suma de matrices:");
            MostrarMatriz(matrizA);
            Console.WriteLine("+");
            MostrarMatriz(matrizB);
            Console.WriteLine("=");
            MostrarMatriz(matrizSuma);

            // Buscar elemento en una matriz
            Console.WriteLine("\nBúsqueda en matriz:");
            int valorBuscado = 5;
            bool encontrado = false;
            int filaEncontrado = -1, columnaEncontrado = -1;

            for (int i = 0; i < otraMatriz.GetLength(0) && !encontrado; i++)
            {
                for (int j = 0; j < otraMatriz.GetLength(1) && !encontrado; j++)
                {
                    if (otraMatriz[i, j] == valorBuscado)
                    {
                        encontrado = true;
                        filaEncontrado = i;
                        columnaEncontrado = j;
                    }
                }
            }

            if (encontrado)
                Console.WriteLine($"El valor {valorBuscado} se encontró en la posición [{filaEncontrado}, {columnaEncontrado}]");
            else
                Console.WriteLine($"El valor {valorBuscado} no se encontró en la matriz");


            /*
            RETO OPCIONAL: MATRIZ DE TEMPERATURAS SEMANALES

            Objetivo: Crear un programa que registre y analice temperaturas diarias por semana usando arrays bidimensionales.

            Requisitos:
            1. Crear una matriz para almacenar las temperaturas de 4 semanas (filas) y 7 días por semana (columnas)
            2. Permitir al usuario introducir las temperaturas o generarlas aleatoriamente entre 10°C y 35°C
            3. Calcular y mostrar:
               - La temperatura media de cada semana
               - La temperatura media de cada día de la semana (todos los lunes, todos los martes, etc.)
               - El día más caluroso y el más frío (indicando semana y día)
            4. Mostrar gráficamente la matriz de temperaturas con formato adecuado

            Bonus (opcional):
            - Generar un gráfico ASCII simple que muestre la evolución de temperaturas
            - Permitir buscar días con temperatura superior o inferior a un valor introducido por el usuario
            */

            Console.WriteLine("\nREGISTRO DE TEMPERATURAS SEMANALES");
            Console.WriteLine("==================================");

            // 1. Declarar la matriz de temperaturas (4 semanas x 7 días)
            double[,] temperaturas = new double[4, 7];

            // 2. Preguntar si desea introducir datos manualmente o generarlos
            Console.WriteLine("¿Desea introducir las temperaturas manualmente o generarlas aleatoriamente?");
            Console.WriteLine("1. Introducir manualmente");
            Console.WriteLine("2. Generar aleatoriamente");
            Console.Write("Elija una opción (1-2): ");

            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 1 && opcion != 2))   
            {
                Console.Write("Por favor, introduzca 1 o 2: ");
            }
            if (opcion == 1)
            {
                addTemperature(temperaturas);
            }
            else
            {
                generateTemperature(temperaturas);
            }

            //3. Calcular y mostrar
            Console.WriteLine("\n----------- Cálculos estadísticos: -----------");
            averageWeeklyTemperature(temperaturas);
            averageWeekDayTemperature(temperaturas);
            extremeDays(temperaturas);

            //4.Mostrar gráficamente la matriz de temperaturas con formato adecuado
            Console.WriteLine("\n------- matriz Temperatura [4,7] ----------");
            ShowArray(temperaturas);
        }

        static void addTemperature(double[,] array)
        {
            for(int i=0; i < array.GetLength(0); i++)
            {
                for(int j=0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Introduce el valor para la posición [{i},{j}]:");
                    array[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        static void generateTemperature(double[,] array)
        {   
            Random random = new Random();   
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int valorEntero = random.Next(10, 35);
                    array[i, j] = (double)valorEntero;
                }
            }
        }

        static void averageWeeklyTemperature(double[,] array) 
        {
            double[] sumWeek = { 0,0,0,0};
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumWeek[i] += array[i, j];
                }
            }
            Console.WriteLine($"Temperatura promedio de semana 1: {sumWeek[0] / 4}");
            Console.WriteLine($"Temperatura promedio de semana 2: {sumWeek[1] / 4}");
            Console.WriteLine($"Temperatura promedio de semana 3: {sumWeek[2] / 4}");
            Console.WriteLine($"Temperatura promedio de semana 4: {sumWeek[3] / 4}");
        }

        static void averageWeekDayTemperature(double[,] array)
        {
            double[] sumWeekDay = { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumWeekDay[j] += array[i, j];
                }
            }
            Console.WriteLine($"Temperatura promedio de los 4 lunes: {sumWeekDay[0] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 martes: {sumWeekDay[1] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 miercoles: {sumWeekDay[2] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 jueves: {sumWeekDay[3] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 viernes: {sumWeekDay[4] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 sabado: {sumWeekDay[5] / 4}");
            Console.WriteLine($"Temperatura promedio de los 4 domingo: {sumWeekDay[6] / 4}");
        }

        static void extremeDays(double[,] array)
        {
            int maxValueX = 0, maxValueY = 0;
            int minValueX = 0, minValueY = 0; 
            double maxValue = array[0,0];
            double minValue = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (maxValue <= array[i, j])
                    {
                        maxValue = array[i, j];
                        maxValueX = i;
                        maxValueY = j;
                    }
                    if (minValue >= array[i, j])
                    {
                        minValue = array[i, j];
                        minValueX = i;
                        minValueY = j;
                    }
                }
            }
            Console.WriteLine($"El temperatura más alta es {array[maxValueX, maxValueY]} - semana: {maxValueX+1} - dia: {maxValueY + 1}");
            Console.WriteLine($"El temperatura más baja es {array[minValueX, minValueY]} - semana: {minValueX+1} - dia: {minValueY + 1}");
        }
        static void ShowArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        // Método auxiliar para mostrar una matriz 2x2
        static void MostrarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
