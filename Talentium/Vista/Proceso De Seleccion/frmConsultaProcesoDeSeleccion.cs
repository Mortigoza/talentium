using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista
{
    public partial class frmConsultaProcesoDeSeleccion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        public frmConsultaProcesoDeSeleccion()
        {
            InitializeComponent();
        }

        private void txtCuilCuit_Leave(object sender, EventArgs e)
        {
            string cuil = txtCuilCuit.Text.Trim();
            if (cuil.Length != 11 && cuil != "")
            {
                MessageBox.Show("El cuil ingresado no tiene un formato correcto.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuilCuit.Focus();
            }
        }

        private bool filtroUtilizado = false;
        //private void controlesUsados()
        //{
        //    txtCuilCuit.TextChanged += txtCuilCuit_TextChanged;
        //    cmbPuesto.SelectedIndexChanged += cmbPuesto_TextChanged;
        //    cmbEtapa.SelectedIndexChanged += cmbEtapa_TextChanged;
        //}

        private void cmbPuesto_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void cmbEtapa_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void txtCuilCuit_TextChanged(object sender, EventArgs e)
        {
            filtroUtilizado = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!filtroUtilizado)
            {
            
                MessageBox.Show("Por favor, utiliza al menos un filtro para la búsqueda.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbPuesto_DropDown(object sender, EventArgs e)
        {
            cmbPuesto.DataSource = proceso.ObtenerPuestos();
            cmbPuesto.DisplayMember = "puesto";
            cmbPuesto.ValueMember = "id_puesto";
        }

        private void cmbEtapa_DropDown(object sender, EventArgs e)
        {
            List<string> lista = new List<string>{"Primera entrevista", "Segunda entrevista", "Preocupacional"};
            cmbEtapa.DataSource = lista;
        }
    }
}
