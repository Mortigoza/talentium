using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Lenguajes;
using LogicaNegocio;
using LogicaNegocio.Lenguajes;
using Comun;

namespace Vista.Gestion_de_Talento
{
    public partial class frmABMCapacitaciones : Form
    {
        CN_Capacitaciones cnCapacitaciones = new CN_Capacitaciones();
        public frmABMCapacitaciones()
        {
            InitializeComponent();
            //idiomas
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            Niveles.Culture = Thread.CurrentThread.CurrentUICulture;
            cmbNivelAlta.Items.AddRange(new string[] { Niveles.cmbNivel0, Niveles.cmbNivel1, Niveles.cmbNivel2 });
            cmbNivelMod.Items.AddRange(new string[] { Niveles.cmbNivel0, Niveles.cmbNivel1, Niveles.cmbNivel2 });
            cmbExternaInternaAlta.Items.AddRange(new string[] { Niveles.cmbExternaInterna0, Niveles.cmbExternaInterna1 });
            cmbExternaInternaMod.Items.AddRange(new string[] { Niveles.cmbExternaInterna0, Niveles.cmbExternaInterna1 });
            cmbNivelAlta.SelectedIndex = 0;
            cmbNivelMod.SelectedIndex = 0;
            cmbExternaInternaAlta.SelectedIndex = 0; 
            cmbExternaInternaMod.SelectedIndex = 0;
            //cmbArea
            cnCapacitaciones.CnDT = cnCapacitaciones.area();
            cmbAreaAlta.ValueMember = "id_area";
            cmbAreaAlta.DisplayMember = "area";
            cmbAreaAlta.DataSource = cnCapacitaciones.CnDT.Copy();
            cmbAreaMod.ValueMember = "id_area";
            cmbAreaMod.DisplayMember = "area";
            cmbAreaMod.DataSource = cnCapacitaciones.CnDT.Copy();
            //dtg
            dtgCapacitacion.Columns.Clear();
        }
        public void limpiarControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Text = null;
                if (item is MaskedTextBox mtxt) mtxt.Text = null;
                if (item is ComboBox cmb) cmb.SelectedIndex = -1;
                if (item is GroupBox | item is Panel) limpiarControles(item);
            }
        }
        public void cargarDTG(bool like)
        {
            //traer capacitaciones al dtg
            if (like == false)
            {
                cnCapacitaciones.Cap = cnCapacitaciones.ConsultaCapacitaciones();
            }
            else 
            {
                cnCapacitaciones.Cap = cnCapacitaciones.filtrarCapacitaciones(txtFiltro.Text);

            }
            dtgCapacitacion.DataSource = null;
            dtgCapacitacion.DataSource = cnCapacitaciones.Cap;
            dtgCapacitacion.AllowUserToAddRows = false;
            dtgCapacitacion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgCapacitacion.MultiSelect = false;
            dtgCapacitacion.RowHeadersVisible = false;
            dtgCapacitacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgCapacitacion.AllowUserToAddRows = false;
            dtgCapacitacion.AllowUserToResizeRows = false;
            dtgCapacitacion.ReadOnly = true;

            // Ocultar las demás columnas

            dtgCapacitacion.Columns[0].Visible = false;
            dtgCapacitacion.Columns[2].Visible = false;
            dtgCapacitacion.Columns[4].Visible = false;
            dtgCapacitacion.Columns[5].Visible = false;
            UtilidadesForms.TraducirColumnasDtg(ref dtgCapacitacion);
        }
        private void frmABMCapacitaciones_Load(object sender, EventArgs e)
        {

            cargarDTG(false);
            bloquearGroupBox(grpModificacion, grpAlta);
        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAlta.Text) || string.IsNullOrWhiteSpace(txtTiempoEstimadoAlta.Text)) 
            {
                MessageBox.Show(Errores.CamposIncompletos, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cnCapacitaciones.IdArea = cmbAreaAlta.SelectedValue;
            cnCapacitaciones.Capacitacion = txtNombreAlta.Text;
            cnCapacitaciones.IdNivel = cmbNivelAlta.SelectedIndex;
            cnCapacitaciones.ExternaInterna = cmbExternaInternaAlta.SelectedIndex;
            cnCapacitaciones.TiempoEstimado = txtTiempoEstimadoAlta.Text;
            cnCapacitaciones.Obligatorio = chcObligatorioAlta.Checked;
            cnCapacitaciones.AltaCapacitaciones();
            cargarDTG(false);
            limpiarControles(grpAlta);
            chcObligatorioAlta.Checked = false;
            chcObligatorioMod.Checked = false;
        }

        private void dtgCapacitacion_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cnCapacitaciones._RowIndex = e.RowIndex;
            cnCapacitaciones._IdCapacitacion = Convert.ToInt32(dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[0].Value);
            
        }
        public void cargaCtrMod() 
        {
            txtNombreMod.Text = dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[1].Value.ToString();
            cmbNivelMod.SelectedIndex = (int)dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[2].Value;
            if (dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[4].Value.ToString() == "")
            {
                cmbAreaMod.SelectedValue = -1;
            }
            else
            {
                cmbAreaMod.SelectedValue = (int)dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[4].Value;
            }
            cmbExternaInternaMod.SelectedIndex = (int)dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[5].Value;
            txtTiempoEstimadoMod.Text = dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[6].Value.ToString();
            chcObligatorioMod.Checked = (bool)dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[7].Value;


        }
        private void btnDtgMod_Click(object sender, EventArgs e)
        {

            if (dtgCapacitacion.SelectedRows == null || dtgCapacitacion.SelectedRows.Count == 0)
            {
                MessageBox.Show(Errores.RegNoSelec, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cargaCtrMod();
            bloquearGroupBox(grpAlta, grpModificacion);

        }

        private void dtgCapacitacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cargaCtrMod();
            bloquearGroupBox(grpAlta, grpModificacion);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreMod.Text) || string.IsNullOrWhiteSpace(txtTiempoEstimadoMod.Text))
            {
                MessageBox.Show(Errores.CamposIncompletos, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cnCapacitaciones.IdCapacitacionesMod = dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[0].Value;
            cnCapacitaciones.IdArea = cmbAreaMod.SelectedValue;
            cnCapacitaciones.Capacitacion = txtNombreMod.Text;
            cnCapacitaciones.IdNivel = cmbNivelMod.SelectedIndex;
            cnCapacitaciones.ExternaInterna = cmbExternaInternaMod.SelectedIndex;
            cnCapacitaciones.TiempoEstimado = txtTiempoEstimadoMod.Text;
            cnCapacitaciones.Obligatorio = chcObligatorioMod.Checked;
            cnCapacitaciones.ModificarCapacitaciones();

            cargarDTG(false);
            limpiarControles(grpModificacion);
            bloquearGroupBox(grpModificacion, grpAlta);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cargarDTG(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgCapacitacion.SelectedRows == null || dtgCapacitacion.SelectedRows.Count == 0)
            {
                MessageBox.Show(Errores.RegNoSelec, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(Errores.QuiereContinuar, Errores.Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                try
                {
                    cnCapacitaciones.IdCapacitacionesMod = dtgCapacitacion.Rows[cnCapacitaciones._RowIndex].Cells[0].Value;
                    cnCapacitaciones.EliminarCapacitaciones();
                    cargarDTG(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarAlta_Click(object sender, EventArgs e)
        {
            txtNombreAlta.Clear();
            txtTiempoEstimadoAlta.Clear();
            cmbNivelAlta.SelectedIndex = 0;
            cmbAreaAlta.SelectedIndex = 0;
            cmbExternaInternaAlta.SelectedIndex = 0;
            chcObligatorioAlta.Checked = false;
        }

        private void btnCancelarMod_Click(object sender, EventArgs e)
        {
            txtNombreMod.Clear();
            txtTiempoEstimadoMod.Clear();
            cmbAreaMod.SelectedIndex = 0;
            cmbNivelMod.SelectedIndex = 0;
            cmbExternaInternaMod.SelectedIndex = 0;
            chcObligatorioMod.Checked = false;
            bloquearGroupBox(grpModificacion, grpAlta);
        }
        private void bloquearGroupBox(GroupBox grpActual, GroupBox grpBloqueado)
        {
            grpActual.Enabled = false;
            grpBloqueado.Enabled = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
