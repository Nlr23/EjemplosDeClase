using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //  Las interfaces se implementan NO se heredan
    //  Los metodos que se definen en una interface los tiene que usar la clase. (TODOS)

    public interface IArma
    {
        public string Atacar();
    }
}
