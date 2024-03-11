using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número:");
        int num3 = int.Parse(Console.ReadLine());

        int menor = Math.Min(Math.Min(num1, num2), num3);
        int mayor = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"El menor número es: {menor}");
        Console.WriteLine($"El mayor número es: {mayor}");
    }
}

