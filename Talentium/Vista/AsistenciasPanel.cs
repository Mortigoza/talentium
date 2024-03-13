using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Comun;
using LogicaNegocio;
using Vista.Lenguajes;

namespace Vista
{
    public partial class AsistenciasPanel : Form
    {
        CN_Asistencias asistencias = new CN_Asistencias();
        C_Asistencias datos;
        
        public AsistenciasPanel(C_Asistencias dato)
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            datos = dato;
            
            DataTable asistencia = asistencias.motivo();
            cmbMotivo.DisplayMember = "motivo";//id_motivo es el id
            cmbMotivo.DataSource = asistencia;

            List<C_Asistencias> listaObjetos = new List<C_Asistencias>();
            listaObjetos.Add(dato);
            valorNombre.Text = listaObjetos[0].Nombre;
            valorApellido.Text = listaObjetos [0].Apellido; 
            valorArea.Text = listaObjetos [0].Area; 
            valorPuesto.Text = listaObjetos [0].Puesto;
            datos.idPer = listaObjetos[0].idPersona;
            datos.idAsis = listaObjetos[0].idAsistencia;
            checkPeriodo.Checked = listaObjetos[0].Periodo;
            if (!dato.Alta) {
                dttFecha.Value = listaObjetos[0].Fecha;
                checkPeriodo.Enabled = false;
                /*
                dttFechaDesde.Value = listaObjetos[0].Fecha_desde;
                dttFechaHasta.Value = listaObjetos[0].Fecha_hasta;*/
            }
            txtOtro.Text = listaObjetos[0].Otro_motivo;
            checkJustificada.Checked = listaObjetos[0].Justificada;
            txtObservaciones.Text = listaObjetos[0].Observaciones;

            fechaDesde.Visible = false;
            fechaHasta.Visible = false;
            dttFechaDesde.Visible = false;
            dttFechaHasta.Visible = false;
            txtOtro.Visible = false;
            lblOtro.Visible = false;
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
                    List<Asistencia> asistencia = new List<Asistencia>();
                    datos.selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;

                    if (checkPeriodo.Checked)
                    {
                        for (datos.fecha = dttFechaDesde.Value; datos.fecha <= dttFechaHasta.Value;)
                        {
                            Asistencia nuevaAsistencia = new Asistencia
                            {
                                idPersona = datos.idPer,
                                Fecha = datos.fecha,
                                idMotivo = (int)datos.selectedMotivo["id_motivo"],
                                OtroMotivo = txtOtro.Text,
                                Justificada = checkJustificada.Checked,
                                Observaciones = txtObservaciones.Text,
                                Periodo = checkPeriodo.Checked
                            };

                            asistencia.Add(nuevaAsistencia);
                            datos.fecha = datos.fecha.AddDays(1);
                        }
                    }
                    else
                    {
                        Asistencia nuevaAsistencia = new Asistencia
                        {
                            idPersona = datos.idPer,
                            Fecha = dttFecha.Value,
                            idMotivo = (int)datos.selectedMotivo["id_motivo"],
                            OtroMotivo = txtOtro.Text,
                            Justificada = checkJustificada.Checked,
                            Observaciones = txtObservaciones.Text,
                            Periodo = checkPeriodo.Checked
                        };

                        asistencia.Add(nuevaAsistencia);
                    }
                    try
                    {
                        asistencias.insertarAsistencias(asistencia);
                        MessageBox.Show("operación realizada con éxito");

                    }
                    catch (Exception exe)
                    {
                        MessageBox.Show("Error al cargar asistencias" + exe);

                    }
                    this.Hide();
                }
                else 
                {
                    datos.selectedMotivo = (DataRowView)cmbMotivo.SelectedItem;
                    asistencias.IdPersona = datos.idPer;
                    asistencias.IdAsistencia = datos.idAsis;
                    asistencias.Fecha = dttFecha.Value;
                    asistencias.FechaDesde = dttFechaDesde.Value;
                    asistencias.FechaHasta = dttFechaHasta.Value;
                    asistencias.IdMotivo = datos.selectedMotivo["id_motivo"];
                    asistencias.OtroMotivo = txtOtro.Text;
                    asistencias.Justificada = checkJustificada.Checked;
                    asistencias.Observaciones = txtObservaciones.Text;
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
            if (checkPeriodo.Checked && datos.Alta == true)
            {
                fechaDesde.Visible = true;
                fechaHasta.Visible = true;
                dttFechaDesde.Visible = true;
                dttFechaHasta.Visible = true;
                fecha.Visible = false;
                dttFecha.Visible = false;
            }
            else if (checkPeriodo.Checked == false && datos.Alta == true)
            {
                fechaDesde.Visible = false;
                fechaHasta.Visible = false;
                dttFechaDesde.Visible = false;
                dttFechaHasta.Visible = false;
                fecha.Visible = true;
                dttFecha.Visible = true;
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
            datos.cbMotivo = (DataRowView)cmbMotivo.SelectedItem;
            datos.valor = asistencias.revisarMotivo(datos.cbMotivo["id_motivo"]);
            if (datos.valor == 9)
            {
                txtOtro.Visible = true;
                lblOtro.Visible = true;
            }
            else 
            {
                txtOtro.Visible = false;
                lblOtro.Visible = false;
            }
        }
    }
}
