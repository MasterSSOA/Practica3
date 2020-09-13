// Practica 3 Ejercicio 7. 
// Nota : Programa capaz de generar la tabla de multiplicar del numero 5
//        del 1 hasta el 1000.
//
//
//                                               © By Anthony Reyes Duran

using System;
class Program
{
    static void Main(string[] args)
    {
        int Numero = 5;
        int Total;

        Console.WriteLine("TABLA DE MULTIPLICACION DEL NUMERO {0} \n\t   Del 1 al 1000\n", Numero);
        for (int i = 1; i <= 1000; i++)
        {
            Total = Numero * i;
            Console.WriteLine("{0} x {1} = {2}", Numero, i, Total);
        }
        Console.ReadKey();
    }
}
