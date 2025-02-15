using System;

class Program
{
    static void Main(string[] args)
    {
        // Parte 1: Declaración y Uso de Variables
        Console.WriteLine("========= Parte 1: Declaracion y Uso de Variables =========");

        // Declaración de variables
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;

        // Solicitar valores al usuario
        Console.Write("Ingrese un numero entero: ");
        numeroEntero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese un numero decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine());

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine();

        Console.Write("Ingrese un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine());

        // Mostrar valores en consola
        Console.WriteLine($"Numero entero: {numeroEntero}");
        Console.WriteLine($"Numero decimal: {numeroDecimal}");
        Console.WriteLine($"Texto: {texto}");
        Console.WriteLine($"Valor booleano: {valorBooleano}");

        // Parte 2: Operaciones Matemáticas
        Console.WriteLine("\n========= Parte 2: Operaciones Matematicas =========");

        // Declaración de variables numéricas
        int num1, num2;
        Console.Write("Ingrese el primer numero entero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero entero: ");
        num2 = int.Parse(Console.ReadLine());

        // Operaciones matemáticas con int
        Console.WriteLine($"Suma: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
        Console.WriteLine($"Multiplicacion: {num1} * {num2} = {num1 * num2}");
        Console.WriteLine($"Division: {num1} / {num2} = {(num2 != 0 ? (num1 / num2).ToString() : "Division por cero no permitida")}");

        // Operaciones matemáticas con otros tipos de datos
        float numFloat1, numFloat2;
        Console.Write("Ingrese el primer numero decimal (float): ");
        numFloat1 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo numero decimal (float): ");
        numFloat2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"Suma: {numFloat1} + {numFloat2} = {numFloat1 + numFloat2}");
        Console.WriteLine($"Resta: {numFloat1} - {numFloat2} = {numFloat1 - numFloat2}");
        Console.WriteLine($"Multiplicacion: {numFloat1} * {numFloat2} = {numFloat1 * numFloat2}");
        Console.WriteLine($"Division: {numFloat1} / {numFloat2} = {(numFloat2 != 0 ? (numFloat1 / numFloat2).ToString() : "Division por cero no permitida")}");

        // Parte 3: Operaciones Lógicas
        Console.WriteLine("\n========= Parte 3: Operaciones Logicas =========");

        // Solicitar valores al usuario
        int valor1, valor2;
        Console.Write("Ingrese el primer valor numerico: ");
        valor1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo valor numerico: ");
        valor2 = int.Parse(Console.ReadLine());

        // Comparaciones lógicas
        Console.WriteLine($"¿{valor1} es mayor que {valor2}? {valor1 > valor2}");
        Console.WriteLine($"¿{valor1} es menor que {valor2}? {valor1 < valor2}");
        Console.WriteLine($"¿{valor1} es igual a {valor2}? {valor1 == valor2}");

        // Uso de AND (&&) y OR (||)
        Console.WriteLine($"¿{valor1} es mayor que 10 y {valor2} es menor que 20? {valor1 > 10 && valor2 < 20}");
        Console.WriteLine($"¿{valor1} es menor que 10 o {valor2} es mayor que 20? {valor1 < 10 || valor2 > 20}");
    }
}
