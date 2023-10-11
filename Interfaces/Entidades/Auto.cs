using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Auto:Vehiculo
    {
        protected string _patente;

        protected Auto(string patente,double precio):base(precio)
        {
            _patente = patente;
        }

        public void MostrarPatente()
        {
            
        }
    }
}
