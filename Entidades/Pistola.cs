using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pistola:Arma
    {
        public string modelo;
        public int municion;

        public Pistola(string modelo,int danio, int durabilidad, string alcance):base(danio,durabilidad,alcance)
        {
            this.modelo = modelo;
            this.municion = 100;
        }

        public override string Atacar()
        {
            this.municion --;
            return "Pew pew";

        }
    }
}
