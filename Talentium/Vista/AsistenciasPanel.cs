﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using LogicaNegocio;
namespace Vista
{
    public partial class AsistenciasPanel : Form
    {
        CN_Asistencias asistencias = new CN_Asistencias();
        C_Asistencias datos = new C_Asistencias();
        int idPer = 0;
        int IdMotiv = 0;
        public AsistenciasPanel(C_Asistencias dato)
        {
            InitializeComponent();
            DataTable asistencia = asistencias.motivo();
            cmbMotivo.DisplayMember = "motivo";//id_motivo es el id
            cmbMotivo.DataSource = asistencia;
            List<C_Asistencias> listaObjetos = new List<C_Asistencias>();
            listaObjetos.Add(dato);
            valorNombre.Text = listaObjetos[0].Nombre;
            valorApellido.Text = listaObjetos [0].Apellido; 
            valorArea.Text = listaObjetos [0].Area; 
            valorPuesto.Text = listaObjetos [0].Puesto;
            idPer = listaObjetos[0].idPersona;
            fechaDesde.Visible = false;
            fechaHasta.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
        }

        private void AsistenciasPanel_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fechaHasta_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;
            datos.idPersona = idPer;
            datos.fecha = dateTimePicker3.Value;
            datos.fecha_desde = dateTimePicker1.Value;
            datos.fecha_hasta = dateTimePicker2.Value;
           // datos.idMotivo = selectedMotivo["id_motivo"];

        }

        private void checkPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPeriodo.Checked)
            {
                fechaDesde.Visible = true;
                fechaHasta.Visible = true;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                fecha.Visible = false;
                dateTimePicker3.Visible = false;
            }
            else 
            {
                fechaDesde.Visible = false;
                fechaHasta.Visible = false;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                fecha.Visible = true;
                dateTimePicker3.Visible = true;
            }
        }

        private void valorPuesto_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}