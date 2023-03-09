using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia01Gihub
{
    internal class Animal
    {
        private const int TAMANIO = 20;

        protected string _alimentacion = "Comida";
        private string _nombre;

        public virtual string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {

                if (value.Length > TAMANIO)
                {
                    throw new Exception("Error");
                }

                _nombre = value;
            }
        }

        public virtual string TipoAlimentacion()
        {
            return _alimentacion;
        }
    }
}
