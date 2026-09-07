//Eloración de listas/arreglos unidimensionales
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.- Arreglos unidimensionales");
        int[] miArreglo = { 15, 22, 8, 41, 50, 33, 19, 27, 12, 5 };
        
        for (int i = 0; i < miArreglo.Length; i++)
        {
            Console.WriteLine(miArreglo[i]);
        }
        Console.Write("Nuevo valor para el tercer elemento: ");
        miArreglo[2] = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("buscar numero: ");
        int numeroBuscado = int.Parse(Console.ReadLine() ?? "0");
        bool encontrado = false;
        for (int i = 0; i < miArreglo.Length; i++)
        {
            if (miArreglo[i] == numeroBuscado) encontrado = true;
        }
        if (encontrado)
        {
            Console.WriteLine("El número existe en la lista.");
        }
        else
        {
            Console.WriteLine("El número no existe ");
        }

        // Etapa 2.- USo de listas. rreglos bidimensionales (matriz 3x3)
        Console.WriteLine("2.- Uso de listas/arreglos bidimensionales (matriz 3x3)");
        int[,] miMatriz = new int[3, 3];
        int sumatotal = 0;
        Console.WriteLine("Ingrese los elementos para una matriz de 3x3:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Posicion [{i},{j}]: ");
                miMatriz[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }
        Console.WriteLine("Matriz ingresada:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(miMatriz[i, j] + "\t");
                sumatotal += miMatriz[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("Suma total de todos los elementos de la matriz es: " + sumatotal);

        // Etapa 3 Operaciones sobre listas
        Console.WriteLine(" ETAPA 3: Listas dinámicas ");
        List<string> miLista = new List<string>();
        miLista.Add("Elemento 1");
        miLista.Add("Elemento 2");

        Console.WriteLine("Elementos iniciales de la lista dinamicas:");
        foreach (string item in miLista)
        {
            Console.WriteLine("- " + item);
        }
        // 4.- Menú interactivo
        Console.WriteLine("\n4.- Menú interactivo");
        int opcion = 0; // Declaramos la variable aquí para que el while funcione

        while (opcion != 3)
        {
            Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
            Console.WriteLine("1. Agregar nuevo elemento a la lista");
            Console.WriteLine("2. Mostrar todos los elementos actuales");
            Console.WriteLine("3. Salir del programa");
            Console.Write("Elija una opción: ");
            opcion = int.Parse(Console.ReadLine() ?? "0");

            if (opcion == 1)
            {
                Console.Write("Escriba el elemento que desea agregar: ");
                string nuevoElemento = Console.ReadLine() ?? string.Empty;
                miLista.Add(nuevoElemento);
                Console.WriteLine("¡Elemento agregado con éxito!");
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Elementos guardados actualmente en la lista:");
                if (miLista.Count == 0)
                {
                    Console.WriteLine("(La lista está vacía)");
                }
                else
                {
                    for (int i = 0; i < miLista.Count; i++)
                    {
                        Console.WriteLine($"{i}. {miLista[i]}");
                    }
                }
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Saliendo del programa. ¡Tarea finalizada con éxito!");
            }
            else
            {
                Console.WriteLine("Opción no válida. Intente de nuevo.");
            }
        }
    }
}