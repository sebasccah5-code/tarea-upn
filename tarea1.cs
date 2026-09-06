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


// Etapa 3.- operaciones con listas
