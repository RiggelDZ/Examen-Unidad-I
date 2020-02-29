using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Examen_Unidad_I
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();

            Personaje personaje = new Rey();
            personaje.ejecutarArma();
            label1.Text = personaje.Nombre + " " + personaje.Arma;
        }
    }
}
