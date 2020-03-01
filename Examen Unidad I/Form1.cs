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
        SimpleFabricaPersonajes fabricaPersonajes = new SimpleFabricaPersonajes();
        Personaje p1, p2, p3, p4;

        private void FormaPrincipal_Load(object sender, EventArgs e)
        {

        }

        public FormaPrincipal()
        {
            InitializeComponent();
            crearPersonajes();
        }

        private void crearPersonajes()
        {
            p1 = fabricaPersonajes.crearPersonaje("rey"); lblArmaP1.Text = lblArmaP1.Text + "\n" + p1.Arma;
            p2 = fabricaPersonajes.crearPersonaje("arquero"); lblArmaP2.Text = lblArmaP2.Text + "\n" + p2.Arma;
            p3 = fabricaPersonajes.crearPersonaje("ogro"); lblArmaP3.Text = lblArmaP3.Text + "\n" + p3.Arma;
            p4 = fabricaPersonajes.crearPersonaje("caballero"); lblArmaP4.Text = lblArmaP4.Text + "\n" + p4.Arma;
        }
    }
}
