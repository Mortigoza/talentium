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
using Comun;
using SpreadsheetLight;
using System.IO;
using SpreadsheetLight.Drawing;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Reflection;
using System.Globalization;
using Vista.Lenguajes;
using LogicaNegocio.Lenguajes;
using LogicaNegocio.Bitacora;

namespace Vista
{
    public partial class Asistencias : Form
    {
        CN_Asistencias asistencias = new CN_Asistencias();
        C_Asistencias datos = new C_Asistencias();

        public Asistencias()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario

            dtgAlta.MultiSelect = false;
            dtgAlta.RowHeadersVisible = false;
            dtgAlta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtgModificar.MultiSelect = false;
            dtgModificar.RowHeadersVisible = false;
            dtgModificar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario


            btnExcel.Visible = false;
            buscarAlta.Enabled = false;
            datos.asistenciaCb = asistencias.area();
            areasAltas.DisplayMember = "area";
            areasAltas.DataSource = datos.asistenciaCb;
            AreaMod.DisplayMember = "area";
            AreaMod.DataSource = datos.asistenciaCb;
            dtgAlta.Columns["Abrir"].Visible = false;
            dtgModificar.Columns["Eliminar"].Visible = false;
            dtgModificar.Columns["Modificar"].Visible = false;
            fechaDesdeMod.Visible = false;
            FechaHastaMod.Visible = false;
            lblFechaHastaMod.Visible = false;
            lblFechaDesdeMod.Visible = false;
            Refrescar(dtgAlta);
            Refrescar(dtgModificar);

        }
        public void RecibirDatos(bool ocultar)
        {
            datos.isReport = ocultar;
            btnExcel.Visible = ocultar;
            btnExcel.Enabled = false; 
            ControlAsist.TabPages.Remove(tbpAlta);
            ControlAsist.SelectedTab = tbpModificar;
            tbpModificar.Text = "Reporte Inasistencias";
        }
        public void Refrescar(DataGridView dtg)
        {
            dtg.DataSource = null;
            dtg.AllowUserToAddRows = false;
            dtg.MultiSelect = false;
            dtg.RowHeadersVisible = false;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg.AllowUserToAddRows = false;
            dtg.AllowUserToResizeRows = false;
            dtg.ReadOnly = true;

            dtgModificar.Columns["Modificar"].Visible = false;
            dtgModificar.Columns["Eliminar"].Visible = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgAlta.CurrentRow;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 0) // Índice de la primera columna de botón
                {
                    if (filaSeleccionada != null)
                    {
                        // Accede a los valores de las celdas en esa fila

                        datos.idPersona = Convert.ToInt32(filaSeleccionada.Cells["id_persona"].Value.ToString());
                        datos.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                        datos.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                        datos.Area = filaSeleccionada.Cells["Area"].Value.ToString();
                        datos.Puesto = filaSeleccionada.Cells["Puesto"].Value.ToString();
                        datos.Alta = true;
                    }
                    AsistenciasPanel panel = new AsistenciasPanel(datos);

                    this.Hide();
                    panel.ShowDialog();
                    this.Show();
                    dtgAlta.DataSource = null;
                    cuilAltas.Clear();
                    areasAltas.SelectedIndex = 0;
                    puestosAltas.SelectedIndex = 0;
                    dtgAlta.Columns["Abrir"].Visible = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void cargar(DataTable data)
        {
            dtgAlta.AllowUserToAddRows = false;
            dtgAlta.DataSource = data;
            dtgAlta.Columns["Abrir"].Visible = true;

            // Ocultar las demás columnas

            dtgAlta.Columns["id_persona"].Visible = false;
            UtilidadesForms.TraducirColumnasDtg(ref dtgAlta);
        }
        public void cargarDtg(DataTable data)
        {
            dtgModificar.AllowUserToAddRows = false;
            dtgModificar.DataSource = data;
            if (!datos.isReport)
            {
                dtgModificar.Columns["Modificar"].Visible = true;
                dtgModificar.Columns["Eliminar"].Visible = true;
            }
            
            // Ocultar los id en las columnas

            dtgModificar.Columns["id_persona"].Visible = false;
            dtgModificar.Columns["id_asistencia"].Visible = false;
            dtgModificar.Columns["id_motivo"].Visible = false;
            UtilidadesForms.TraducirColumnasDtg(ref dtgModificar);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (areasAltas.Items.Count > 0 && puestosAltas.Items.Count > 0)
            {
                //boton buscar del alta
                datos.selectedA = (DataRowView)areasAltas.SelectedItem;
                datos.selectedP = (DataRowView)puestosAltas.SelectedItem;
                datos.idA = Convert.ToInt32(datos.selectedA["id_area"]);
                datos.idP = Convert.ToInt32(datos.selectedP["id_puesto"]);
                if (string.IsNullOrEmpty(cuilAltas.Text))
                {
                    datos.asistenciaCargar = asistencias.filtroAlta(datos.idA, datos.idP, null);
                    cargar(datos.asistenciaCargar);
                }
                else
                {
                    datos.asistenciaCargar = asistencias.filtroAlta(datos.idA, datos.idP, cuilAltas.Text);
                    cargar(datos.asistenciaCargar);

                }
            }
        } 
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true; // Cancela la entrada de caracteres no numéricos

            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void areasAltas_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.selectedAA = (DataRowView)areasAltas.SelectedItem;
            datos.idAP = Convert.ToInt32(datos.selectedAA["id_area"]);

            datos.selectedAP = asistencias.puesto(datos.idAP);
            puestosAltas.DisplayMember = "puesto";
            puestosAltas.DataSource = datos.selectedAP;

            if (areasAltas.SelectedItem != null && puestosAltas.Text != null)
            {
                buscarAlta.Enabled = true;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void periodo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void periodo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (periodo.Checked)
            {
                FechaMod.Visible = false;
                fechaDesdeMod.Visible = true;
                FechaHastaMod.Visible = true;
                lblFechaHastaMod.Visible = true;
                lblFechaDesdeMod.Visible = true;
                lblFechaMod.Visible = false;
            }
            else
            {
                FechaMod.Visible = true;
                fechaDesdeMod.Visible = false;
                FechaHastaMod.Visible = false;
                lblFechaHastaMod.Visible = false;
                lblFechaDesdeMod.Visible = false;
                lblFechaMod.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AreaMod.Items.Count > 0 && PuestoMod.Items.Count > 0)
            {
                //boton buscar del modificar
                datos.selectedMA = (DataRowView)AreaMod.SelectedItem;
                datos.selectedMP = (DataRowView)PuestoMod.SelectedItem;
                datos.idAs = datos.selectedMA["id_area"];
                datos.idPs = datos.selectedMP["id_puesto"];

                datos.dtAs = asistencias.filtroModificacion(periodo.Checked, datos.idAs, datos.idPs, CuilMod.Text, FechaMod.Value, fechaDesdeMod.Value, FechaHastaMod.Value);

                cargarDtg(datos.dtAs);
                if (datos.dtAs.Rows.Count >= 1)
                {
                    btnExcel.Enabled = true;
                }
                else
                {
                    btnExcel.Enabled = false;
                }

            }
        }

        private void AreaMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.selectedArea= (DataRowView)areasAltas.SelectedItem;
            datos.idAM = Convert.ToInt32(datos.selectedArea["id_area"]);

            datos.selectedPuesto = asistencias.puesto(datos.idAM);
            PuestoMod.DisplayMember = "puesto";
            PuestoMod.DataSource = datos.selectedPuesto;

            if (areasAltas.SelectedItem != null && puestosAltas.Text != null)
            {
                buscarAlta.Enabled = true;
            }
        }

        private void dataGridModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dtgModificar.CurrentRow;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == 0) // Índice de la primera columna de botón
                {
                    if (filaSeleccionada != null)
                    {
                        // Accede a los valores de las celdas en esa fila

                        datos.idAsistencia = Convert.ToInt32(filaSeleccionada.Cells["id_asistencia"].Value.ToString());
                        datos.idPersona = Convert.ToInt32(filaSeleccionada.Cells["id_persona"].Value.ToString());
                        datos.Nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                        datos.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                        datos.Area = filaSeleccionada.Cells["Area"].Value.ToString();
                        datos.Puesto = filaSeleccionada.Cells["Puesto"].Value.ToString();

                        datos.Periodo = Convert.ToBoolean(filaSeleccionada.Cells["periodo"].Value.ToString());
                      
                        datos.Fecha = Convert.ToDateTime(filaSeleccionada.Cells["fecha"].Value.ToString());
                        
                        datos.Justificada = Convert.ToBoolean(filaSeleccionada.Cells["justificada"].Value.ToString());
                        datos.Id_motivo = Convert.ToInt32(filaSeleccionada.Cells["id_motivo"].Value.ToString());
                        datos.Otro_motivo = filaSeleccionada.Cells["otro_motivo"].Value.ToString();
                        datos.Observaciones = filaSeleccionada.Cells["observaciones"].Value.ToString();
                        datos.Alta = false;

                    }
                    AsistenciasPanel panel = new AsistenciasPanel(datos);

                    this.Hide();
                    panel.ShowDialog();
                    this.Show();

                    dtgModificar.DataSource = null;
                    CuilMod.Clear();
                    AreaMod.SelectedIndex = 0;
                    PuestoMod.SelectedIndex = 0;
                    periodo.Checked = false;
                    FechaMod.Value = DateTime.Now;
                    fechaDesdeMod.Value = DateTime.Now;
                    FechaHastaMod.Value = DateTime.Now;
                    dtgModificar.Columns["Modificar"].Visible = false;
                    dtgModificar.Columns["Eliminar"].Visible = false;
                }
                else if(e.ColumnIndex == 1) {
                    DialogResult result = MessageBox.Show(Errores.QuiereContinuar, Errores.Aviso, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Verificar la respuesta del usuario
                    if (result == DialogResult.Yes)
                    {
                        datos.idAsistencia = Convert.ToInt32(filaSeleccionada.Cells["id_asistencia"].Value.ToString());

                        string _idAsis = filaSeleccionada.Cells["id_persona"].Value.ToString();
                        asistencias.EliminarAsistencias(datos.idAsistencia);
                        CN_Bitacora.AltaBitacora($"Inasistencia del empleado ID: {_idAsis} eliminada", "DELETE", this.Name);
                        Refrescar(dtgModificar);
                    }
                }
            }
        }

        private void btnBuscarReporte_Click(object sender, EventArgs e)
        {

        }
       // se convierte el booleano en si y no para exportar en la columna del excel
        private string ConvertirBoolASiONo(object valor)
        {
            if (valor is bool)
            {
                return (bool)valor ? "Si" : "No";//devuelve si/no si es bool
            }
            return valor.ToString(); // Si no es bool, devuelve el valor original
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
                   
            
        }

        private void dataGridModificar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dtgModificar.Columns[e.ColumnIndex] is DataGridViewButtonColumn && (e.RowIndex >= 0))
            {
                if (dtgModificar.Columns[e.ColumnIndex].Name == "Modificar")
                {
                    e.Value = Columnas.abrir;
                }
                else if (dtgModificar.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    e.Value = Columnas.eliminar;
                }
            }
        }

        private void dataGridAlta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dtgAlta.Columns[e.ColumnIndex] is DataGridViewButtonColumn && (e.RowIndex >= 0))
            {
                if (dtgAlta.Columns[e.ColumnIndex].Name == "Abrir")
                {
                    e.Value = Columnas.abrir;
                }
            }
        }

        private void cuilAltas_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void CuilMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Archivos Excel (.xlsx)|.xlsx";
                saveDialog.Title = "Elije el nombre del archivo Excel";
                string defaultFileName = string.Format("Reporte Inasistencia " + DateTime.Now.ToString("dd-MM-yyyy") + ".xlsx"); // Nombre predeterminado del archivo
                saveDialog.FileName = defaultFileName;
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // string rutaCompleta = Path.Combine(folderDialog.SelectedPath, defaultFileName);
                    string rutaCompleta = saveDialog.FileName;

                    SLDocument sl = new SLDocument();
                    SLStyle style = new SLStyle();
                    style.Font.FontSize = 12;
                    style.Fill.SetPatternType(PatternValues.Solid);
                    style.Fill.SetPatternForegroundColor(System.Drawing.Color.LightBlue);
                    style.Border.TopBorder.BorderStyle = BorderStyleValues.Medium;
                    style.Border.BottomBorder.BorderStyle = BorderStyleValues.Medium;
                    style.Border.LeftBorder.BorderStyle = BorderStyleValues.Medium;
                    style.Border.RightBorder.BorderStyle = BorderStyleValues.Medium;
                    style.Font.Bold = true;
                    sl.SetWorksheetDefaultColumnWidth(25);
                    int numCol = 0;
                    int numFila = 10;

                    string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources", "ImgTalentium.jpeg");

                    SLPicture picture = new SLPicture(rutaImagen);
                    picture.SetPosition(0, 0); // Establece la posición de la imagen (fila 2, columna 1)
                    picture.ResizeInPixels(170, 110);  // Establece el tamaño de la imagen (ancho, alto)
                    sl.InsertPicture(picture);

                    try
                    {
                        foreach (DataGridViewColumn cl in dtgModificar.Columns)
                        {
                            //El if esta para que las columnas ids no se muestren en el excel
                            if (cl.Index != 0 && cl.Index != 1 && cl.Index != 5 && cl.Index != 11)
                            {
                                string nombreColumna = cl.HeaderText;
                                string nombreColumnaFormateado = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nombreColumna.ToLower());

                                sl.SetCellValue(9, numCol, nombreColumnaFormateado);
                                sl.SetCellStyle(9, numCol, style);
                                sl.SetCellStyle(9, 9, 9, numCol, style);

                                numCol++;
                            }
                        }

                        DateTime fechaEmision = DateTime.Now; // Puedes ajustar la fecha según tus necesidades
                        SLStyle fechaEmisionStyle = new SLStyle();
                        fechaEmisionStyle.Alignment.Horizontal = HorizontalAlignmentValues.Right;
                        fechaEmisionStyle.SetFontBold(true);
                        fechaEmisionStyle.SetFontItalic(true);
                        fechaEmisionStyle.Font.FontSize = 12;
                        sl.SetCellStyle(2, 10, fechaEmisionStyle); // Fila 1, Columna 1
                        sl.SetCellValue(2, 10, "Fecha de Emisión: " + fechaEmision.ToString("dd/MM/yyyy"));
                        SLStyle titulo = new SLStyle();
                        titulo.Alignment.Horizontal = HorizontalAlignmentValues.Right;
                        titulo.SetFontBold(true);
                        titulo.SetFontUnderline(UnderlineValues.Single); // Aplicar subrayado al texto
                        titulo.Font.FontSize = 16;
                        sl.SetCellStyle(6, 6, titulo);
                        sl.SetCellValue(6, 6, "Reporte de Inasistencia");
                        SLStyle fondo = new SLStyle();
                        fondo.Alignment.Horizontal = HorizontalAlignmentValues.Right;
                        fondo.Fill.SetPatternType(PatternValues.Solid);
                        fondo.Fill.SetPatternForegroundColor(System.Drawing.Color.White);
                        sl.SetCellStyle(1, 1, 8, 12, fondo);

                        var data = dtgModificar.Columns;
                        var fila = dtgModificar.Rows;
                        foreach (DataGridViewRow row in dtgModificar.Rows)
                        {

                            sl.SetCellValue(numFila, 1, row.Cells[3].Value.ToString());
                            sl.SetCellValue(numFila, 2, row.Cells[4].Value.ToString());
                            sl.SetCellValue(numFila, 3, row.Cells[6].Value.ToString());
                            sl.SetCellValue(numFila, 4, row.Cells[7].Value.ToString());
                            sl.SetCellValue(numFila, 5, ConvertirBoolASiONo(row.Cells[8].Value));
                            sl.SetCellValue(numFila, 6, row.Cells[9].Value.ToString());
                            sl.SetCellValue(numFila, 7, ConvertirBoolASiONo(row.Cells[10].Value));
                            sl.SetCellValue(numFila, 8, row.Cells[12].Value.ToString());
                            sl.SetCellValue(numFila, 9, row.Cells[13].Value.ToString());
                            sl.SetCellValue(numFila, 10, row.Cells[14].Value.ToString());
                            numFila++;
                        }
                        sl.SaveAs(rutaCompleta);
                        MessageBox.Show(Errores.OperacionExitosa, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception msj)
                    {
                        MessageBox.Show(msj.Message);

                    }
                }
            }
        }

        private void lnkAtas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dtgAlta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dtgAlta.Columns[e.ColumnIndex] is DataGridViewButtonCell && (e.RowIndex >= 0))
            {
                if (dtgAlta.Columns[e.ColumnIndex].Name == Columnas.abrir)
                {
                    e.Value = "a";
                }
            }
        }

        private void dtgModificar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dtgModificar.Columns[e.ColumnIndex] is DataGridViewButtonCell && (e.RowIndex >= 0))
            {
                if (dtgModificar.Columns[e.ColumnIndex].Name == Columnas.modificar)
                {
                    e.Value = Columnas.abrir;
                }
                if (dtgModificar.Columns[e.ColumnIndex].Name == Columnas.eliminar)
                {
                    e.Value = Columnas.eliminar;
                }
            }
        }
    }
}
