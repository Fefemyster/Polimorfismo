using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Rectángulo : Forma
    {
        public double altura { get; set; }
        public double baseRectangulo { get; set; }
        public override double CalcularArea()
        {
            double area = altura*baseRectangulo;
            Console.WriteLine($"El área del Rectángulo es: {area}");
            return area;
        }
    }
}
