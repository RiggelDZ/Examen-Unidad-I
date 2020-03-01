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
        public RealizarMovimiento crearMovimiento(string movimiento)
        {
            RealizarMovimiento realizarMovimiento = null;

            switch (movimiento)
            {
                case "Atacar":
                    realizarMovimiento = new Atacar();
                    break;
                case "Avanzar":
                    realizarMovimiento = new Avanzar();
                    break;
                case "Curar":
                    realizarMovimiento = new Curar();
                    break;
                case "Defender":
                    realizarMovimiento = new Defender();
                    break;
            }

            return realizarMovimiento;
        }
    }
}
