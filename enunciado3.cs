using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre de usuario: ");
        string username = Console.ReadLine();

        Console.Write("Ingrese la contraseña: ");
        string password = Console.ReadLine();

        string correctUsername = "Daniel";
        string correctPassword = "1234";

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Acceso concedido");
        }
        else if (username == correctUsername)
        {
            Console.WriteLine("Contraseña incorrecta");
        }
        else
        {
            Console.WriteLine("Usuario no registrado");
        }
    }
}
