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
        //Fábricas simples que se encargan de la creación de personajes, movimientos y armas para personajes.
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                mandarPersonaje();
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
            lblArmaP1.Text = "Arma:" + "\n" + p1.Arma;
            lblArmaP2.Text = "Arma:" + "\n" + p2.Arma;
            lblArmaP3.Text = "Arma:" + "\n" + p3.Arma;
            lblArmaP4.Text = "Arma:" + "\n" + p4.Arma;
        }

        private void hacerAccion(Personaje personaje)
        {
            ConsultaBD consultaBD = new ConsultaBD();

            if (comboMovimiento.Enabled)
            {
                //Se manda añadir un movimiento para el personaje usando la fábrica simple.
                simpleFabricaMovimientos.crearMovimiento(personaje, comboMovimiento.Text);
                personaje.ejecutarMovimiento();
                consultaBD.guardarAccion(personaje);
                mboxAccion(personaje);
            }
            else if (comboArma.Enabled)
            {
                //Se manda añadir un arma para el personaje usando la fábrica simple.
                simpleFabricaArmas.crearArma(personaje, comboArma.Text);
                personaje.ejecutarArma();
                simpleFabricaMovimientos.crearMovimiento(personaje, "Cambio de arma");
                personaje.ejecutarMovimiento();
                consultaBD.guardarAccion(personaje);
                mboxAccion(personaje);
            }
        }
        

        private void mandarPersonaje()
        {
            switch (txtPersonaje.Text)
            {
                case "Rey":
                    hacerAccion(p1);
                    break;
                case "Arquero":
                    hacerAccion(p2);
                    break;
                case "Ogro":
                    hacerAccion(p3);
                    break;
                case "Caballero":
                    hacerAccion(p4);
                    break;
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

        public void mboxAccion(Personaje personaje)
        {
            if (personaje.Movimiento == "Ataque")
            {
                MessageBox.Show(personaje.Nombre + " realizó " + personaje.Movimiento.ToLower() + " con " + personaje.Arma.ToLower());
            }
            else
            {
                MessageBox.Show(personaje.Nombre + " realizó " + personaje.Movimiento.ToLower());
            }

            txtPersonaje.Clear(); comboArma.ResetText(); comboMovimiento.ResetText();
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

        private void btnLog_Click(object sender, EventArgs e)
        {
            FormaLog formaLog = new FormaLog();
            formaLog.ShowDialog();
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
