using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escribe el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escribe el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int suma = Sumar(numero1, numero2);
        Console.WriteLine($"La suma de {numero1} y {numero2} es {suma}");
    }

    static int Sumar(int a, int b)
    {
        return a + b;
    }
}
