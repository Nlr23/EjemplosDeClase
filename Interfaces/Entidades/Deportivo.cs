using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto , IAFIP
    {
        protected int _caballosFuerza;

        public Deportivo(int caballosFuerza, string patente, double precio):base(patente,precio)
        {
            _caballosFuerza = caballosFuerza;
        }

        public double CalcularImpuesto()
        {
            double precioNuevo;
        }
    }
}
