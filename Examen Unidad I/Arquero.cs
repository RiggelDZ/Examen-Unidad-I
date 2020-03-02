using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    class Arquero:Personaje
    {
        public Arquero()
        {
            Nombre = "Arquero";
            establecerArma(new ArcoFlecha());
        }
    }
}
