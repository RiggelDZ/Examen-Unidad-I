using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    //Patrón Simple Factory
    class SimpleFabricaMovimientos
    {
        public void crearMovimiento(Personaje personaje, string movimiento)
        {
            switch (movimiento)
            {
                case "Atacar":
                    personaje.establecerMovimiento(new Atacar());
                    break;
                case "Avanzar":
                    personaje.establecerMovimiento(new Avanzar());
                    break;
                case "Curar":
                    personaje.establecerMovimiento(new Curar());
                    break;
                case "Defender":
                    personaje.establecerMovimiento(new Defender());
                    break;
                case "Cambio de arma":
                    personaje.establecerMovimiento(new CambiarArma());
                    break;
            }
        }
    }
}
