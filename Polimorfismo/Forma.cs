using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Forma()
    
    {
        public string Nombre { get; set; }
        public virtual double CalcularArea()
        {
          return 0; // Método base, puede ser sobreescrito por las clases derivadas
        }

    }
}
