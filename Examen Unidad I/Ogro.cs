﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_I
{
    class Ogro:Personaje
    {
        public Ogro()
        {
            Nombre = "Ogro";
            establecerArma(new Hacha());
        }
    }
}
