using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    //Patrón Simple Factory
    class SimpleFabricaArmas
    {
        public void crearArma(Personaje personaje,string arma)
        {
            switch (arma)
            {
                case "Arco y Flecha":
                    personaje.establecerArma(new ArcoFlecha());
                    break;
                case "Espada":
                    personaje.establecerArma(new Espada());
                    break;
                case "Hacha":
                    personaje.establecerArma(new Hacha());
                    break;
                case "Lanza":
                    personaje.establecerArma(new Lanza());
                    break;
            }
        }
    }
}
