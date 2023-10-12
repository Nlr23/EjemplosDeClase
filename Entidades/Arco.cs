using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arco : Arma
    {
        public int cantidadFlechas;

        public Arco(int danio, int durabilidad, string alcance, int cantidadFlechas) : base(danio, durabilidad, alcance)
        {
            this.cantidadFlechas = cantidadFlechas;
        }

        public override string Atacar()
        {
            this.cantidadFlechas--;

            return "jfushhhhh";
        }
    }
}
