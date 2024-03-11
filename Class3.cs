using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese la cantidad de números primos a generar:");
        int cantidad = int.Parse(Console.ReadLine());

        int contador = 0;
        int numeroActual = 2;

        while (contador < cantidad)
        {
            if (EsPrimo(numeroActual))
            {
                Console.Write($"{numeroActual} ");
                contador++;
            }

            numeroActual++;
        }
    }
}