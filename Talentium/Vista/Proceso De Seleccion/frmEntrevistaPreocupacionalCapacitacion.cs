﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista.Gestion_de_Talento
{
    public partial class frmEntrevistaPreocupacionalCapacitacion : Form
    {
        CN_LogicaProcesoSeleccion proceso = new CN_LogicaProcesoSeleccion();
        private int idCandidato;
        private bool cambiosDetectados = false;
        private bool comboExteriorHabilitado = false;
        private string valorOriginalComboExterior;
        
        public int IdCandidato
        {
            get { return idCandidato; }
            set { idCandidato = value; }
        }
        public frmEntrevistaPreocupacionalCapacitacion(string nombre, string apellido, string puesto, int idCandidatoSeleccionado)
        {
            InitializeComponent();
            lblNombreApellido.Text = $"{nombre} {apellido}";
            lblPuesto.Text = puesto;
            this.idCandidato = idCandidatoSeleccionado;
           // dtpEntrevista.MinDate = DateTime.Today;
        }

        private void cmbEstadoEntrevista_DropDown(object sender, EventArgs e)
        {
            List<string> estados = new List<string>() { "APTO", "NO APTO" };
            cmbEstadoEntrevista.DataSource = estados;
        }

        private void cmbEmpleados_DropDown(object sender, EventArgs e)
        {
            
        }

        private void cmbAreas_DropDown(object sender, EventArgs e)
        {
            cmbAreas.DataSource = proceso.ObtenerAreas();
            cmbAreas.DisplayMember = "area";
            cmbAreas.ValueMember = "id_area";
        }

        private void cmbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedArea = cmbAreas.SelectedItem as DataRowView;
            int idAreaSeleccionada = Convert.ToInt32(selectedArea["id_area"]);
            DataTable DTEmpleados = proceso.ObtenerEmpleados(idAreaSeleccionada);
            DTEmpleados.Columns.Add("NombreCompleto", typeof(string), "APELLIDOS + ', ' + NOMBRES");

            if (DTEmpleados != null && DTEmpleados.Rows.Count > 0)
            {
                cmbEmpleados.DataSource = DTEmpleados;
                cmbEmpleados.DisplayMember = "NombreCompleto";
            }
            else
            {
                cmbEmpleados.DataSource = null;
                cmbEmpleados.Items.Clear();
            }
        }

        private void dtpEntrevista_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpEntrevista.Value;

            if (fechaSeleccionada < DateTime.Now) 
            {
                cmbEstadoEntrevista.Enabled = true;
                cmbEmpleados.Enabled = false;
                cmbAreas.Enabled = false;
            }
            else
            {
                cmbEstadoEntrevista.Enabled = false;
                cmbEstadoEntrevista.Text = "PROGRAMADA";
                cmbEmpleados.Enabled = true;
                cmbAreas.Enabled = true;
            }
        }
        
        private void cmbEstadoEntrevista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoEntrevista.Enabled && cmbEstadoEntrevista.Text != null)
            {
                cambiosDetectados = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCandidato = IdCandidato;
            if (cmbEstadoEntrevista.Enabled)
            {
                
                if (cmbEstadoEntrevista.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un estado.");
                    return;
                }
                
                string estado = cmbEstadoEntrevista.SelectedItem.ToString();
                proceso.ModificarEstado(idCandidato, estado);
                MessageBox.Show("Los datos han sido guardados correctamente.");
                if (estado == "APTO")
                {
                    tabPreocupacional.Enabled = true;
                }
            }
            else
            {
                DateTime fecha_etapa = dtpEntrevista.Value;
                string area = cmbAreas.Text;
                string entrevistador = cmbEmpleados.Text;
                proceso.InsertarSegundaEntrevista(idCandidato, fecha_etapa, area, entrevistador);
                MessageBox.Show("Los datos han sido guardados correctamente.");
                tabPreocupacional.Enabled = true;
            }
        }

        private void tabEtapas_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPageIndex == 1 && !tabPreocupacional.Enabled))
            {
                e.Cancel = true;
            }
        }

        private void frmEntrevistaPreocupacionalCapacitacion_Load(object sender, EventArgs e)
        {
            tabPreocupacional.Enabled = false;
        }
    }
}
