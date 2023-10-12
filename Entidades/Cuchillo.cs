using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuchillo : Item , IArma
    {
        public int durabilidad;

        public Cuchillo(int durabilidad,string nombre):base(nombre)
        {
            this.durabilidad = durabilidad;
        }

        public string Atacar()
        {
            return "Stab stab";
        }

        public override string Usar()
        {
            this.durabilidad--;
            return $"Se utilizo el {base.nombre}";
        }
    }
}
