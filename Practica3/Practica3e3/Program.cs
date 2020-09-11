// Practica 3 Ejercicio 3. 
// Nota : Programa capaz de validar un usuario y arrojar sí su acceso
//        será True o False luego de validar.
//
//
//                                             © By Anthony Reyes Duran

using System;
using System.Runtime.CompilerServices;

class Program
{
    // Código Principal.
    static void Main(string[] args)
    {
        int Attempts = 0;
        string UserName;
        string Pass = string.Empty;
        bool Result = false;

        while (Attempts < 3)
        {
            // Encabezado.
            Console.Write("\tVALIDACION DE CUENTA\nUsuario : ");
            UserName = Console.ReadLine();
            Console.Write("Contraseña : ");
            Pass = Console.ReadLine();
            
            // Llamada de Método.
            Result = Validation(UserName, Pass);

            // Lógica de bluque y llamada para el pase.
            if (Result)
            {
                Attempts += 3;
            }
            else
            {
                Attempts += 1; 
                if(Attempts != 3)
                    Console.WriteLine("\nPetición Acceso : Invalida\n");
            }
        }
        Console.WriteLine("\nAcceso Al Sistema: {0}\n", Result);
        Console.ReadKey();
    }

    // Método de Validación de Usuario.
    static bool Validation(string UserName, string Pass)
    {
        bool _Validation = false;

        if (UserName == "admin" && Pass == "1234")
            _Validation = true;


        return _Validation;
    }

}

