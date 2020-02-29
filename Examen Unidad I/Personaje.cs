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
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Movimiento { get { return movimiento; } set { movimiento = value; } }
        public string  Arma { get { return arma; } set { arma = value; } }

        public Personaje() { }

        public void establecerArma(EquiparArma ea)
        {
            equiparArma = ea;
        }
        public void establecerMovimiento()
        {
            
        }
        public void ejecutarArma()
        {
            Arma = equiparArma.Equipar();
        }
        public void ejecutarMovimiento() { }
    }
}
