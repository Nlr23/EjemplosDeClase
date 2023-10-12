using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hacha:Arma , IItem
    {
        public int cantidadHojas;

        public Hacha(int cantidadHojas,int danio,int durabilidad,string alcance):base(danio,durabilidad,alcance)
        {
            this.cantidadHojas = cantidadHojas;
        }

        public override string Atacar()
        {
            return "waaachazzzzzzzzz";
        }

        public string Usar()
        {
            return "Talando arbol";
        }
    }
}
