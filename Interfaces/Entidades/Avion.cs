using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo , IAFIP
    {
        protected double _velocidadMaxima;

        public Avion(double velocidadMaxima, double precio) : base(precio)
        {
            _velocidadMaxima = velocidadMaxima;
        }

        public double CalcularImpuesto()
        {
            throw new NotImplementedException();
        }
    }
}
