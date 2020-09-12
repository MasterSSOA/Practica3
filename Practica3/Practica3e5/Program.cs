// Practica 3 Ejercicio 5. 
// Nota : Programa capaz de convertir un mes de su número correspondiente
//        a su nombre en el calendario.
//
//
//                                               © By Anthony Reyes Duran

using System;
using System.Text.RegularExpressions;

namespace Practica3e5
{
    partial class Program
    {
        //Estructura principal
        static void Main(string[] args)
        {
            string Mes;
            int Captura;
            try
            {
                Console.Write("CONVERTIDOR DE MES\n\nNúmero de Mes : ");
                Captura = Convert.ToInt32(Console.ReadLine());
                Mes = MonthConverter(Captura);

                if (0 < Captura && Captura < 13)
                    Console.WriteLine("\nEl Mes es " + Mes);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message.ToString()); 
                Console.ReadKey();
            }
        }

        //Función convertidor de número a nombre de mes.
        static string MonthConverter(int NumeroMes)
        {
            string Mes = string.Empty;
            
            switch (NumeroMes)
            {
                case 1:
                    Mes = Meses.Enero.ToString();
                    break;
                case 2:
                    Mes = Meses.Febrero.ToString();
                    break;
                case 3:
                    Mes = Meses.Marzo.ToString();
                    break;
                case 4:
                    Mes = Meses.Abril.ToString();
                    break;
                case 5:
                    Mes = Meses.Mayo.ToString();
                    break;
                case 6:
                    Mes = Meses.Junio.ToString();
                    break;
                case 7:
                    Mes = Meses.Julio.ToString();
                    break;
                case 8:
                    Mes = Meses.Agosto.ToString();
                    break;
                case 9:
                    Mes = Meses.Septiembre.ToString();
                    break;
                case 10:
                    Mes = Meses.Octubre.ToString();
                    break;
                case 11:
                    Mes = Meses.Noviembre.ToString();
                    break;
                case 12:
                    Mes = Meses.Diciembre.ToString();
                    break;
                default:
                    Console.WriteLine("\nEste mes no existe.");
                    break;
            }
            return Mes;
        }

        //Enumeración de los Meses
        enum Meses
        {
            Enero,
            Febrero,
            Marzo,
            Abril,
            Mayo,
            Junio,
            Julio,
            Agosto,
            Septiembre,
            Octubre,
            Noviembre,
            Diciembre
        }
    }
}
