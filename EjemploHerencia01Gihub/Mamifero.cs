using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia01Gihub
{
    internal class Mamifero : Animal
    {
        public override string TipoAlimentacion()
        {
            string cadena;

            _alimentacion = "";

            cadena = base.TipoAlimentacion();

            cadena += ": Otros seres vivos";

            return cadena;
        }
    }
}
