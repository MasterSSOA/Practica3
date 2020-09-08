// Practica 3 Ejercicio 1. 
// Nota : Programa capaz imprimir en pantalla una lista de los números enteros 
//        cuales quiera luego de que el usuario especifique el numero de rango
//        inicial y el final.  
//
//
//                                                    © By Anthony Reyes Duran

using System;

class Program
{
    static void Main(string[] args)
    {
        int StartNumber;
        int EndNumber;
        try
        {
            Console.Write("\tLISTADO DE NUMEROS\n\nDigite el Número de Rango Inicial : ");
            StartNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el Número de Rango Final : ");
            EndNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            if (StartNumber > EndNumber)
            {
                for (int i = StartNumber; i >= EndNumber; i--)
                {
                    Console.WriteLine("\t\t" + StartNumber);
                    StartNumber -= 1;
                }
                Console.ReadKey();
            }
            else
            {
                for (int i = StartNumber; i <= EndNumber; i++)
                {
                    Console.WriteLine("\t\t" + StartNumber);
                    StartNumber += 1;
                }
                Console.ReadKey();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error inesperado : {0}", e.Message.ToString());
            Console.ReadKey();
        }
    }
}