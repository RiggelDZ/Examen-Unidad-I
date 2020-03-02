using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Unidad_I
{
    public partial class FormaLog : Form
    {
        ConsultaBD consultaBD = new ConsultaBD();

        public FormaLog()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (comboNombre.Enabled)
                {
                    buscarDatos(comboNombre.Text);
                }
                else if (comboArma.Enabled)
                {
                    buscarDatos(comboArma.Text);
                }
                else if (comboMovimiento.Enabled)
                {
                    buscarDatos(comboMovimiento.Text);
                }
                else if (comboHora.Enabled)
                {
                    buscarDatos(comboHora.Text);
                }
            }
        }

        private void buscarDatos(string busqueda)
        {
            try
            {
                dgLog.DataSource = consultaBD.buscar(busqueda, comboBuscar.Text).Tables[0];
                imprimitDG();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void imprimitDG()
        {
            dgLog.Columns[0].HeaderText = "Nombre";
            dgLog.Columns[2].HeaderText = "Acción";
            dgLog.Columns[3].HeaderText = "Fecha y Hora";
            dgLog.Columns["Hora"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgLog.Refresh();
        }

        private void comboBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBuscar.Text)
            {
                case "Nombre":
                    comboNombre.ResetText();
                    comboNombre.Enabled = true; comboNombre.Visible = true;
                    comboArma.Visible = false; comboArma.Enabled = false;
                    comboMovimiento.Visible = false; comboMovimiento.Enabled = false;
                    comboHora.Visible = false; comboHora.Enabled = false;
                    break;
                case "Arma":
                    comboArma.ResetText();
                    comboArma.Enabled = true; comboArma.Visible = true;
                    comboNombre.Visible = false; comboNombre.Enabled = false;
                    comboMovimiento.Visible = false; comboMovimiento.Enabled = false;
                    comboHora.Visible = false; comboHora.Enabled = false;
                    break;
                case "Movimiento":
                    comboArma.ResetText();
                    comboMovimiento.Enabled = true; comboMovimiento.Visible = true;
                    comboNombre.Visible = false; comboNombre.Enabled = false;
                    comboArma.Visible = false; comboArma.Enabled = false;
                    comboHora.Visible = false; comboHora.Enabled = false;
                    break;
                case "Hora":
                    comboHora.ResetText();
                    comboHora.Enabled = true; comboHora.Visible = true;
                    comboNombre.Visible = false; comboNombre.Enabled = false;
                    comboArma.Visible = false; comboArma.Enabled = false;
                    comboMovimiento.Visible = false; comboMovimiento.Enabled = false;
                    break;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PDF pdf = new PDF();
            if (dgLog.Rows.Count > 0)
            {
                pdf.exportar(dgLog, "Log");
            }
            else
            {
                MessageBox.Show("No hay datos que exportar");
            }
        }

        private bool validarCampos()
        {
            if (!string.IsNullOrWhiteSpace(comboBuscar.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Selecciona un método de búsqueda");
                return false;
            }
        }
    }
}
