using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    class Caballero:Personaje
    {
        public Caballero()
        {
            Nombre = "Caballero";
            equiparArma = new Lanza();
        }
    }
}
