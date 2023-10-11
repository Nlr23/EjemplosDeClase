using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familiar : Auto
    {
        protected int _cantAsientos;

        public Familiar(int cantAsientos,string patente,double precio):base(patente,precio)
        {
            _cantAsientos = cantAsientos;
        }
    }
}
