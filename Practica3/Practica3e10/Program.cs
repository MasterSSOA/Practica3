// Practica 3 Ejercicio 10. 
// Nota : Programa capaz de Solicitar Banco y Monto a retirar
//        presentando a su vez restricciones en pautadas en la practica.
//
//
//                                               © By Anthony Reyes Duran

using System;
class Program
{
    static void Main(string[] args)
    {
        string Line = "__";
        int Opcion;
        double Monto;

        for (int i = 0; i < 26; i++)
        {
            Line += "__";
        }

        Console.WriteLine("\t\tCAJERO AUTOMÁTICO ABC\n{0}", Line);
        Console.WriteLine("\t\t\tMENÚ\n{0}", Line);
        Console.WriteLine("\t\tSELECCIONE SU BANCO:\n\t\t   [1 - Banco ABC]" +
                          "\n\t\t   [2 - Otro Banco]");

        try
        {
            Console.Write("Opción : ");
            Opcion = Convert.ToInt32(Console.ReadLine());
            
            if (Opcion == 1)
            {
                Console.WriteLine("{0}\n\t\tBIENVENIDO A SU BANCO\n{0}", Line);
                Console.WriteLine("\tNota : Límite de Retiro RD$10,000.00\n");
                Console.Write("Digité el Monto a Retirar : ");
                Monto = Convert.ToDouble(Console.ReadLine());

                if ((100 <= Monto && Monto <= 10000) && Monto != 0)
                {
                    Console.WriteLine("{0}", DistribuidorBilletes(Monto));
                    Console.WriteLine("Por Favor, Espere su Dinero...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0}\nEsta Transaccion No Puede Ser Realizada...\n{0}", Line);
                    Console.ReadKey();
                }
            }
            else if (Opcion == 2)
            {
                Console.WriteLine("{0}\n\t\tBIENVENIDO - CAJERO ABC\n{0}", Line);
                Console.WriteLine("\tNota : Límite de Retiro RD$ 2,000.00\n");
                Console.Write("Digité el Monto a Retirar : ");
                Monto = Convert.ToDouble(Console.ReadLine());

                if ((100 <= Monto && Monto <= 2000) && Monto != 0)
                {
                    Console.WriteLine("{0}", DistribuidorBilletes(Monto));
                    Console.WriteLine("Por Favor, Espere su Dinero...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("{0}\nEsta Transaccion No Puede Ser Realizada...\n{0}", Line);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("{0}\nEsta Transaccion No Puede Ser Realizada...\n{0}", Line);
                Console.ReadKey();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error : " + e.Message);
            Console.ReadKey();
        }
    }

    //Función de divisiones de Billetes
    static string DistribuidorBilletes(double Monto)
    {
        string Line = "__";
        double Resuntalte;
        int BilleteMil;
        int BilleteQui;
        int BilleteCien;
        string Resultados = "";

        if (Monto % 100 != 0)
        {
            Console.WriteLine("{0}\nEl Cajero No Posee Los Billetes \nNecesarios " +
                              "Para Realizar Esta Transaccion...\n{0}", Line);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nLa Distribución de Billetes Será \n" +
                              "Realizada de la Siguente Manera :\n");

            BilleteMil = 0;
            BilleteQui = 0;
            BilleteCien = 0;
            Resuntalte = Monto;

            while ((0 < Resuntalte && Resuntalte >= 1000) && BilleteMil < 9)
            {
                Resuntalte -= 1000;
                BilleteMil += 1;
            }
            while ((0 < Resuntalte && Resuntalte >= 500) && BilleteQui < 19)
            {
                Resuntalte -= 500;
                BilleteQui += 1;
            }
            while ((0 < Resuntalte && Resuntalte >= 100) && BilleteCien < 99)
            {
                Resuntalte -= 100;
                BilleteCien += 1;
            }

            Resultados = "RD$1,000.00 : " + BilleteMil + " Billete(s)\n" +
                         "RD$  500.00 : " + BilleteQui + " Billete(s)\n" +
                         "RD$  100.00 : " + BilleteCien + " Billete(s)\n";
        }
        return Resultados;
    }
}
