// Practica 3 Ejercicio 9. 
// Nota : Programa capaz de registrar la cantidad de billetes digitados por
//        alguien sobre un cajero automático.
//
//
//                                               © By Anthony Reyes Duran

using System;
class Program
{
    static void Main(string[] args)
    {
        int BilleteMil;
        int BilleteQui;
        int BilleteCien;
        int TotalMil;
        int TotalQui;
        int TotalCien;
        int Monto;
        string Line = "__";

        for (int i = 0; i < 22; i++)
        {
            Line += "__";
        }

        Console.WriteLine("   CAJERO AUTOMÁTICO REGISTRO DE BILLETES\n" +
                          "        REABASTECIMIENTO DE BILLETES");
        Console.WriteLine("\n  (NOTA: Límites de Billetes de 1000 :  9" +
                          "\n         Límites de Billetes de  500 : 19 " +
                          "\n         Límites de Billetes de  100 : 99\n");
        try
        {
            Console.Write("\nCantidad de Billetes de Mil \t\tx : ");
            
            BilleteMil = Convert.ToInt32(Console.ReadLine());
            if (1 > BilleteMil || BilleteMil > 9)
            {
                Console.Write("\nNo Se Puede Realizar Esta Transaccion...\n" +
                              "Limite de Billetes de Mil : 9.");
                Console.ReadKey();
                return;
            }
            
            Console.Write("Cantidad de Billetes de Quinientos \tx : ");
            BilleteQui = Convert.ToInt32(Console.ReadLine());
            if (1 > BilleteQui || BilleteQui > 19)
            {
                Console.Write("\nNo Se Puede Realizar Esta Transaccion...\n" +
                              "Limite de Billetes de Quinientos : 19.");
                Console.ReadKey();
                return;
            }
            
            Console.Write("Cantidad de Billetes de Cien \t\tx : ");
            BilleteCien = Convert.ToInt32(Console.ReadLine());
            if (1 > BilleteCien || BilleteCien > 99)
            {
                Console.Write("\nNo Se Puede Realizar Esta Transaccion...\n" +
                              "Limite de Billetes de Cien : 99.");
                Console.ReadKey();
                return;
            }

            TotalMil = BilleteMil * 1000;
            TotalQui = BilleteQui * 500;
            TotalCien = BilleteCien * 100;
            Monto = TotalMil + TotalQui + TotalCien;

            Console.Write("\n{0}\n", Line);
            Console.Write("      DETALLE DE BILLETES REGISTRADOS\n" +
                          "\n1000 x {0} : {1:n}" +
                          "\n 500 x {2} : {3:n}" +
                          "\n 100 x {4} : {5:n}" +
                          "\n{6}\n\nTotal de Monto Registrado : {7:n}",
                          BilleteMil, TotalMil, BilleteQui,
                          TotalQui, BilleteCien,
                          TotalCien, Line, Monto);

            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error : " + e.Message);
            Console.ReadKey();
        }
    }
}

