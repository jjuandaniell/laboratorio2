using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número del 1 al 7:");
        if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 1 && numero <= 7)
        {
            string dia = ObtenerNombreDia(numero);
            Console.WriteLine($"El día correspondiente es: {dia}");
        }
        else
        {
            Console.WriteLine("Número inválido. Por favor, ingrese un número del 1 al 7.");
        }
    }

    static string ObtenerNombreDia(int numero)
    {
        switch (numero)
        {
            case 1:
                return "Lunes";
            case 2:
                return "Martes";
            case 3:
                return "Miércoles";
            case 4:
                return "Jueves";
            case 5:
                return "Viernes";
            case 6:
                return "Sábado";
            case 7:
                return "Domingo";
            default:
                throw new ArgumentOutOfRangeException(nameof(numero), "El número debe estar entre 1 y 7");
        }
    }
}
