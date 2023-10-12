using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Espada : Arma
    {
        public int filo;

        public Espada(int filo, int danio, int durabilidad, string alcance):base(danio,durabilidad,alcance)
        {
            this.filo = filo;
        }

        public override string Atacar()
        {
            this._durabilidad -= this.filo;
            return "zaaaaaz";
        }
    }
}
