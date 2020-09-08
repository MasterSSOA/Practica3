// Practica 3 Ejercicio 2. 
// Nota : Programa capaz imprimir en pantalla una la sumatoria total de
//        los numeros N digitados siempre y cuando este no sea cero.
//
//
//                                             © By Anthony Reyes Duran

using System;

class Program
{
    static void Main(string[] args)
    {
		int Numero = 0;
		int Sumatoria = 0;
		int NumeroDigitado = -1;
        
		try
		{
			Console.WriteLine("\tBIENVENIDO AL PROGRAMA DE SUMATORIA\n(Nota*: Para Presentar la " +
							  "Sumatoria Total de los Números \n\t y Salir del Programa Digite el 0)\n");
			do
			{
                Console.Write("Digite un Número : ");
				Numero = Convert.ToInt32(Console.ReadLine());
                Sumatoria += Numero;
				NumeroDigitado += 1;
			}
            while (Numero != 0);
			
			Console.WriteLine("\nLa Cantidad de Números Digitados Fueron : {0}", NumeroDigitado);
			Console.WriteLine("La Sumatoria Total Es			: {0}", Sumatoria);
			Console.ReadKey();
		}
		catch (Exception e)
		{
			Console.WriteLine("Error Inesperado : " + e.Message.ToString());
			Console.ReadKey();
		}
    }
}
