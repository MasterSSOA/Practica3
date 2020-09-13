// Practica 3 Ejercicio 6. 
// Nota : Programa capaz de realizar funciones seleccionados a traves de un
//        menu.
//
//
//                                                 © By Anthony Reyes Duran

using System;

namespace Practica3e6
{
    class Program
    {
        static void Main(string[] args)
        {
            double Option;
            double Valor;
            double ValorConvertido;
            string Value;
            char Bucle = 'y';

            try
            {

                while (Bucle == 'y')
                {
                    Console.Write("BIENVENIDO AL MENÚ\nSeleccione una opción\n\n" +
                                  "[1 - Convertir grados a Celsius a Fahrenheit]\n[2 - Convertir dólar a pesos]\n" +
                                  "[3 - Convertir metros a pies]\n[4 - Salir]\n\nNúmero de Menú: ");

                    Value = Console.ReadLine();
                    if (Value == string.Empty)
                        Value = "0";
                    Option = Convert.ToDouble(Value);

                    switch (Option)
                    {
                        case 1:
                            Console.Write("\nCONVERTIDOR DE GRADOS DE °C A °F\nCelcius : ");
                            Valor = Convert.ToDouble(Console.ReadLine());
                            ValorConvertido = (1.8 * Valor) + 32;
                            Console.WriteLine("Fahrenheit : {0}\n\nPresione Enter para seguir en el menú\n", ValorConvertido);
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.Write("\nCONVERTIDOR DE GRADOS DE DOLAR A PESO DOMINICANO\nMonto en Dolar : ");
                            Valor = Convert.ToDouble(Console.ReadLine());
                            ValorConvertido = 58.50 * Valor;        //El valor del dolar a peso dominicano es de 58.50 fecha 12/09/2020.
                            Console.WriteLine("Monto en Pesos : {0}\n\nPresione Enter para seguir en el menú\n", ValorConvertido);
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.Write("\nCONVERTIDOR DE GRADOS DE METROS A PIE\nMetro(s) : ");
                            Valor = Convert.ToDouble(Console.ReadLine());
                            ValorConvertido = 3.2808 * Valor;
                            Console.WriteLine("Pie(s) : {0:0.00}ft\n\nPresione Enter para seguir en el menú\n", ValorConvertido);
                            Console.ReadKey();
                            break;
                        case 4:
                            Bucle = 'n';
                            Console.Write("\nSaliendo del programa...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("\nDato invalido. Intente de nuevo!\n");
                            Console.ReadKey();
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
                Console.ReadKey();
            }


        }
    }
}