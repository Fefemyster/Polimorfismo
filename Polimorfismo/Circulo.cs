using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : Forma
    {
        public double Radio { get; set; }

        public override double CalcularArea()
        {
            double area = Math.PI * Math.Pow(Radio, 2);
            Console.WriteLine($"El área del círculo es: {area}");
            return area;
        }
    }
}
