using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    //Patrón Simple Factory
    class SimpleFabricaPersonajes
    {
        public Personaje crearPersonaje(string tipo)
        {
            Personaje personaje = null;

            switch (tipo)
            {
                case "rey": personaje = new Rey();
                    personaje.ejecutarArma();
                    break;
                case "arquero": personaje = new Arquero();
                    personaje.ejecutarArma();
                    break;
                case "ogro": personaje = new Ogro();
                    personaje.ejecutarArma();
                    break;
                case "caballero": personaje = new Caballero();
                    personaje.ejecutarArma();
                    break;
            }

            return personaje;
        }
    }
}
