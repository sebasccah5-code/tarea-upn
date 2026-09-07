// Etapa 1-. Arreglos unidemensionales
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
        miArreglo[2] = int.Parse(Console.ReadLine());

        Console.Write("buscar numero: ");
        int numeroBuscado = int.Parse(Console.ReadLine());
        bool encontrado = false;
        for (int i = 0; i < miArreglo.Length; i++)
        {
            if (miArreglo[i] == numeroBuscado) encontrado = true;
        }
        Console.WriteLine(encontrado ? "El número existe en la lista." : "El número no existe ");
    }
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
        miMatriz[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Matriz ingresada:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matriz¨[i, j] + "\t");
        sumatotal += miMatriz[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("Suma total de todos los elementos de la matriz es: " + sumatotal);