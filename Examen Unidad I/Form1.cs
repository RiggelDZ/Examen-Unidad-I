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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void comboMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPersonaje.Text))
            {
                MessageBox.Show("Seleccione un personaje.");
            }
            else if (comboArma.Enabled && string.IsNullOrWhiteSpace(comboArma.Text))
            {
                MessageBox.Show("Seleccione un arma.");
            }
            else if (comboMovimiento.Enabled && string.IsNullOrWhiteSpace(comboMovimiento.Text))
            {
                MessageBox.Show("Seleccione un movimiento.");
            }
        }

        private void radioMovimiento_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMovimiento.Checked)
            {
                lblMovimiento.Text = "Movimiento";
                comboMovimiento.Enabled = true; comboMovimiento.Visible = true;
                comboArma.Enabled = false; comboArma.Visible = false; comboArma.ResetText();
            }
        }

        private void radioArma_CheckedChanged(object sender, EventArgs e)
        {
            if (radioArma.Checked)
            {
                lblMovimiento.Text = "Arma";
                comboMovimiento.Enabled = false; comboMovimiento.Visible = false; comboMovimiento.ResetText();
                comboArma.Enabled = true; comboArma.Visible = true; 
            }
        }

        private void pboxP1_MouseClick(object sender, MouseEventArgs e)
        {
            txtPersonaje.Text = p1.Nombre;
        }

        private void pboxP2_MouseClick(object sender, MouseEventArgs e)
        {
            txtPersonaje.Text = p2.Nombre;
        }

        private void pboxP3_MouseClick(object sender, MouseEventArgs e)
        {
            txtPersonaje.Text = p3.Nombre;
        }

        private void pboxP4_MouseClick(object sender, MouseEventArgs e)
        {
            txtPersonaje.Text = p4.Nombre;
        }
    }
}
