using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;
using Vista.Lenguajes;
using Vista.Properties;

namespace Comun
{
    public static class UtilidadesForms
    {

        // Bloquea los controles de un formulario
        public static void BloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Enabled = false;
                if (item is ComboBox cmb) cmb.Enabled = false;
                if (item is GroupBox | item is Panel) BloquearControles(item);
            }
        }

        // Desbloquea los controles de un formulario
        public static void DesbloquearControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Enabled = true;
                if (item is ComboBox cmb) cmb.Enabled = true;
                if (item is GroupBox | item is Panel) DesbloquearControles(item);
            }
        }

        // Limpia los controles de un formulario
        public static void LimpiarControles(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox txt) txt.Text = null;
                if (item is ComboBox cmb) cmb.Text = null;
                if (item is GroupBox | item is Panel) LimpiarControles(item);
            }
        }

        public static void moverListboxRow(ListBox ls1, ListBox ls2, DataTable dt1, DataTable dt2, int selectIndex)
        {
            if (ls1.Items.Count > 0)
            {
                DataRow row = dt2.NewRow();
                row[0] = ls1.SelectedValue;
                row[1] = ls1.Text;
                dt2.Rows.Add(row);

                dt1.Rows.RemoveAt(selectIndex);
                ls2.Update();
            }
        }
        public static void LimpiarDataGrid(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }

        public static void CargarComboLenguajes(ComboBox cmb)
        {
            cmb.DataSource = Idioma.ObtenerIdiomas();//Cargo el Combo con la lista de la clase Idioma
            cmb.DisplayMember = "Nombre"; //Muestro el "campo" nombre de la lista
            cmb.ValueMember = "InfoCultura";//Guardo la informacion Cultural en el Combo
            cmb.SelectedValue = Settings.Default.Idioma; //Selecciono el idioma guardado por defecto
        }

    }
}
