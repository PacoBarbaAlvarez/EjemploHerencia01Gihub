using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia01Gihub
{
    internal class Aves : Animal
    {
        public override string TipoAlimentacion()
        {
            return base.TipoAlimentacion() + ": Insectos";
        }
    }
}
