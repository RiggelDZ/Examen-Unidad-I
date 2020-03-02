using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace Examen_Unidad_I
{
    class Rey : Personaje
    {

        Conexion con = new Conexion();

        public Rey()
        {
            Nombre = "Rey";
            establecerArma(new Espada());
        }
    }
}
