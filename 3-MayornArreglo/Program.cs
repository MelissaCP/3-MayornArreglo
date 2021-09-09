using System;
using C = System.Console;

namespace _3_MayornArreglo
{
    /// Practica 3
    /// 3.- Encontrar el mayor de n números en un arreglo.

    /// Chávez Pérez Melissa
    /// #M21210035

    class Program
    {
        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            C.Write("\nFavor de Ingresar cuantos numeros desea comparar ");
            int v;
            v = int.Parse(C.ReadLine());

            // Declaracion de Arreglo 
            int[] datos = new int[v];
            int i, mayor = 0, j= 0;
            for(i=0; i < v; i++)
            {
                C.WriteLine("\nIngrese valor {0}",(i+1));
                datos[i] = Convert.ToInt32(C.ReadLine());
            }
            while (j<v)
            {
                if (datos[j] > mayor)
                    mayor = datos[j];
                j++;
            }
            C.WriteLine("El mayor de los datos es: {0}", mayor);
            C.ReadLine();

        }
    }
}
