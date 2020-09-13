// Practica 3 Ejercicio 8. 
// Nota : Programa capaz de calcular los impuestos generados para los 
//        sueldos aplicados dentro del programa.
//
//
//                                               © By Anthony Reyes Duran

using System;

namespace Practica3e8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Monto;
            double ARS;
            double AFP;
            double ISR = 0;
            double Sueldo;
            double Impuestos;

            try
            {
                Console.Write("Digite un Monto de Sueldo Mensual: ");
                Monto = Convert.ToDouble(Console.ReadLine());
                ARS = Monto * 0.0304;
                AFP = Monto * 0.0287;
                Console.WriteLine("\n\tRESULTADOS DEL CÁLCULO:\n\nSalario Mensual:\tRD${0:n}", Monto);
                Console.WriteLine("ARS:\t\t\tRD${0:n} (3.04%)", ARS);
                Console.WriteLine("AFP:\t\t\tRD${0:n} (2.87%)", AFP);

                if (34685 < Monto && Monto <= 52027.42)
                {
                    ISR = (Monto - 34685) * 0.15;
                    Console.WriteLine("\nESTE MONTO PAGA IMPUESTO SOBRE LA RENTA (ISR)\n");
                    Console.WriteLine("TASA:\t\t\t15% del Excendente de RD$416,220.01");
                    Console.WriteLine("VALOR A RETENER:\tRD${0:n}", ISR);
                }
                else if (52027.42 < Monto && Monto <= 72260.25)
                {
                    ISR = ((Monto - 52027.42) * 0.2) + 2601.33;
                    Console.WriteLine("\nESTE MONTO PAGA IMPUESTO SOBRE LA RENTA (ISR)\n");
                    Console.WriteLine("TASA:\t\t\tRD$2,601.33 + El 20% del Excendente de RD$624,329.01");
                    Console.WriteLine("VALOR A RETENER:\tRD${0:n}", ISR);
                }
                else if (72260.25 < Monto)
                {
                    ISR = ((Monto - 72260.25) * 0.25) + 6648;
                    Console.WriteLine("\nESTE MONTO PAGA IMPUESTO SOBRE LA RENTA (ISR)\n");
                    Console.WriteLine("TASA:\t\t\tRD$6,648.00 + El 25% del Excendente de RD$867,123.01");
                    Console.WriteLine("VALOR A RETENER:\tRD${0:n}", ISR);
                }

                Impuestos = ARS + AFP + ISR;
                Sueldo = Monto - Impuestos;

                Console.WriteLine("\nTotal de Impuestos: \tRD${0:n}", Impuestos);
                Console.WriteLine("Sueldo a Pagar: \tRD${0:n}", Sueldo);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.ReadKey();
            }

        }
    }
}