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
        int idAsis = 0;
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
            idAsis = listaObjetos[0].idAsistencia;
            checkPeriodo.Checked = listaObjetos[0].Periodo;
            dateTimePicker3.Value = listaObjetos[0].Fecha;
            dateTimePicker1.Value = listaObjetos[0].Fecha_desde;
            dateTimePicker2.Value = listaObjetos[0].Fecha_hasta;
            cmbMotivo.SelectedIndex = listaObjetos[0].Id_motivo;
            txtOtro.Text = listaObjetos[0].Otro_motivo;
            checkJustificada.Checked = listaObjetos[0].Justificada;
            txtObs.Text = listaObjetos[0].Observaciones;

            fechaDesde.Visible = false;
            fechaHasta.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            txtOtro.Visible = false;
            label7.Visible = false;
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
            try
            {
                if (datos.Alta)
                {
                    DataRowView selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;
                    asistencias.IdPersona = idPer;
                    asistencias.Fecha = dateTimePicker3.Value;
                    asistencias.FechaDesde = dateTimePicker1.Value;
                    asistencias.FechaHasta = dateTimePicker2.Value;
                    asistencias.IdMotivo = selectedMotivo["id_motivo"];
                    asistencias.OtroMotivo = txtOtro.Text;
                    asistencias.Justificada = checkJustificada.Checked;
                    asistencias.Observaciones = txtObs.Text;
                    asistencias.Periodo = checkPeriodo.Checked;
                    asistencias.insertarAsistencias();
                    this.Hide();
                    MessageBox.Show("operación realizada con éxito");
                }
                else 
                {
                    DataRowView selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;
                    asistencias.IdPersona = idPer;
                    asistencias.IdAsistencia = idAsis;
                    asistencias.Fecha = dateTimePicker3.Value;
                    asistencias.FechaDesde = dateTimePicker1.Value;
                    asistencias.FechaHasta = dateTimePicker2.Value;
                    asistencias.IdMotivo = selectedMotivo["id_motivo"];
                    asistencias.OtroMotivo = txtOtro.Text;
                    asistencias.Justificada = checkJustificada.Checked;
                    asistencias.Observaciones = txtObs.Text;
                    asistencias.Periodo = checkPeriodo.Checked;
                    asistencias.ModificarAsistencias();
                    this.Hide();
                    MessageBox.Show("operación realizada con éxito");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al ingresar los datos: "+ ex);
            }
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

        private void cmbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;
            var valor = asistencias.revisarMotivo(selectedMotivo["id_motivo"]);
            if (valor == 9)
            {
                txtOtro.Visible = true;
                label7.Visible = true;
            }
            else 
            {
                txtOtro.Visible = false;
                label7.Visible = false;
            }
        }
    }
}