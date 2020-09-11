// Practica 3 Ejercicio 5. 
// Nota : Programa capaz de convertir un mes de su número correspondiente
//        a su nombre en el calendario.
//
//
//                                               © By Anthony Reyes Duran

using System;

namespace Practica3e5
{
    class Program
    {
        //Estructura principal
        static void Main(string[] args)
        {

        }

        //Función convertidor de número a nombre de mes.
        static string MonthConverter(string Mes)
        {
            Meses meses = Meses.Enero;

            switch (meses)
            {
                case Meses.Enero:
                    break;
                case Meses.Febrero:
                    break;
                case Meses.Marzo:
                    break;
                case Meses.Abril:
                    break;
                case Meses.Mayo:
                    break;
                case Meses.Junio:
                    break;
                case Meses.Julio:
                    break;
                case Meses.Agosto:
                    break;
                case Meses.Septiembre:
                    break;
                case Meses.Octubre:
                    break;
                case Meses.Noviembre:
                    break;
                case Meses.Diciembre:
                    break;
                default:
                    break;
            }

            return Mes;
        }
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

