using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Privado : Avion
    {
        protected int _valoracionServicioDeAbordo;

        public Privado(int valoracionServicioDeAbordo, double precio, double velocidad):base(velocidad,precio)
        {
            _valoracionServicioDeAbordo = valoracionServicioDeAbordo;
        }
    }
}
