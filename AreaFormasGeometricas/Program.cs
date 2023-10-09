using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        Console.WriteLine("Insira 3 valores: ");

        string[] valores = Console.ReadLine().Split(' ');
        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double pi = 3.14159;

        double triangulo = (a * c) / 2;
        double circulo = pi * Math.Pow(c, 2);
        double trapezio = ((a + b) * c) / 2;
        double quadrado = Math.Pow(b, 2);
        double retangulo = a * b;

        Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
    }

}