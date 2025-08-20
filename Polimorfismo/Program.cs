using System;
using Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        // Lista de formas 
        List<Forma> formas = new List<Forma>
        {
            new Circulo { Nombre = "Círculo 1", Radio = 5 },
            new Rectángulo { Nombre = "Rectángulo 1", altura = 4, baseRectangulo = 6 }
        };
        // Calculando y mostrando el area de cada forma
        foreach (var forma in formas)
        {
            Console.WriteLine($"Calculando área para: {forma.Nombre}");
            forma.CalcularArea();
        }
    }
}



