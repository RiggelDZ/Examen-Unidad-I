using System;
using MySql.Data.MySqlClient;

namespace Examen_Unidad_I
{
    //Patrón Strategy
    public abstract class Personaje
    {
        private string nombre, movimiento, arma;

        //Referencias a interfaces de comportamiento
        private EquiparArma equiparArma;
        private RealizarMovimiento realizarMovimiento;

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Arma { get { return arma; } set { arma = value; } }
        public string Movimiento { get { return movimiento; } set { movimiento = value; } }

        //Métodos que establecen el comportamiento
        public void establecerArma(EquiparArma ea)
        {
            equiparArma = ea;
        }

        public void establecerMovimiento(RealizarMovimiento rm)
        {
            realizarMovimiento = rm;
        }

        //Métodos que ejecutan el comportamiento
        public void ejecutarArma()
        {
            arma = equiparArma.equipar();
        }

        public void ejecutarMovimiento()
        {
            movimiento = realizarMovimiento.realizar();
        }
    }
}
