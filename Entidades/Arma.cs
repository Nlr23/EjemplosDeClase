using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Arma: IArma
    {
        public int _danio;
        public int _durabilidad;
        public string _alcance;

        public Arma(int danio, int durabilidad, string alcance)
        {
            _danio = danio;
            _durabilidad = durabilidad;
            this._alcance = alcance;
        }

        public abstract string Atacar();

    }
}
