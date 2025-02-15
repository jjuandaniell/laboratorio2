using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese su edad: ");
        if (int.TryParse(Console.ReadLine(), out int edad))
        {
            string categoria = DeterminarCategoria(edad);
            Console.WriteLine($"Categoría: {categoria}");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }

    static string DeterminarCategoria(int edad)
    {
        if (edad < 12)
        {
            return "Niño";
        }
        else if (edad >= 12 && edad <= 17)
        {
            return "Adolescente";
        }
        else if (edad >= 18 && edad <= 59)
        {
            return "Adulto";
        }
        else
        {
            return "Adulto mayor";
        }
    }
}
