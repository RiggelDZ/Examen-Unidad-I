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
        SimpleFabricaMovimientos simpleFabricaMovimientos = new SimpleFabricaMovimientos();
        SimpleFabricaArmas simpleFabricaArmas = new SimpleFabricaArmas();

        Personaje p1, p2, p3, p4;

        public FormaPrincipal()
        {
            InitializeComponent();

            p1 = crearPersonaje("rey");
            p2 = crearPersonaje("arquero");
            p3 = crearPersonaje("ogro");
            p4 = crearPersonaje("caballero");

            imprimirDatosPersonajes();
            
            /*
            p2.Movimiento = "Defender";
            lblArmaP1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            p2.guardarAccion();*/
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                hacerAccion(p1);
                imprimirDatosPersonajes();

            }
        }

        private Personaje crearPersonaje(string nombre)
        {
            Personaje personaje = null;
            personaje = fabricaPersonajes.crearPersonaje(nombre);
            return personaje;
        }

        private void imprimirDatosPersonajes()
        {
            lblArmaP1.Text = string.Empty; lblArmaP2.Text = string.Empty;
            lblArmaP3.Text = string.Empty; lblArmaP4.Text = string.Empty;
            lblArmaP1.Text = lblArmaP1.Text + "\n" + p1.Arma;
            lblArmaP2.Text = lblArmaP2.Text + "\n" + p2.Arma;
            lblArmaP3.Text = lblArmaP3.Text + "\n" + p3.Arma;
            lblArmaP4.Text = lblArmaP4.Text + "\n" + p4.Arma;
        }

        private void hacerAccion(Personaje personaje)
        {
            if (comboMovimiento.Enabled)
            {
                personaje.realizarMovimiento = simpleFabricaMovimientos.crearMovimiento(comboMovimiento.Text);
            }
            else if (comboArma.Enabled)
            {
                simpleFabricaArmas.crearArma(personaje, comboArma.Text);
                personaje.ejecutarArma();
            }
        }

        private bool validarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtPersonaje.Text))
            {
                MessageBox.Show("Seleccione un personaje.");
                return false;
            }
            else if (comboArma.Enabled && string.IsNullOrWhiteSpace(comboArma.Text))
            {
                MessageBox.Show("Seleccione un arma.");
                return false;
            }
            else if (comboMovimiento.Enabled && string.IsNullOrWhiteSpace(comboMovimiento.Text))
            {
                MessageBox.Show("Seleccione un movimiento.");
                return false;
            }
            return true;
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
