using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    public abstract class Personaje
    {
        private string nombre, movimiento, arma;
        public EquiparArma equiparArma;
        public RealizarMovimiento realizarMovimiento;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Arma { get { return arma; } set { arma = value; } }
        public string Movimiento { get { return movimiento; } set { movimiento = value; } }
        

        public void establecerArma(EquiparArma ea)
        {
            equiparArma = ea;
        }

        public void establecerMovimiento(RealizarMovimiento rm)
        {
            realizarMovimiento = rm;
        }

        public void ejecutarArma()
        {
            arma = equiparArma.Equipar();
        }

        public void ejecutarMovimiento()
        {
            movimiento = realizarMovimiento.Realizar();
        }
    }
}
