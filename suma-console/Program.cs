using suma_console;
using System;

public class Program
{
    static void Main()
    {
        var suma = new suma();
        
        Console.WriteLine("Escribe el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"La suma de {numero1} y {numero2} es {suma.Sumar(numero1, numero2)}");
    }
}
