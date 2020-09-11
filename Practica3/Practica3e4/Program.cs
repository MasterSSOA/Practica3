// Practica 3 Ejercicio 4. 
// Nota : Programa capaz de leer un numero y retornar el mismo número
//        duplicado.
//
//
//                                             © By Anthony Reyes Duran

using System;

class Program
{
    //Estructura principal del programa.
    static void Main(string[] args)
    {
        double Numero;
        try
        {
            Console.Write("DUPLICADOR DE NÚMERO\n\nDigite un número: ");
            Numero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDuplicado : {0} ", Duplicador(Numero));
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error : " + e.Message.ToString());
            Console.ReadKey();
        }
    }

    //Método de duplicación de números.
    static double Duplicador(double Numero)
    {
        double _Total;
        _Total = Numero * 2;
        return _Total;
    }

}

