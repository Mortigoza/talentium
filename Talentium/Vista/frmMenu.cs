using Comun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Accesibilidad;
using Vista.Analisis_y_reportes;
using Vista.Evaluacion_de_desempeño;
using Vista.Lenguajes;

namespace Vista
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario
            string permisos = "";
            PermisosCache[] listaPermisos = PermisosCache.GetPermisos();
            for (int i = 0, len = listaPermisos.Length; i < len; i++)
            {
                permisos += $"{listaPermisos[i].Id}: {listaPermisos[i].Permiso}\n";
            }
            MessageBox.Show(permisos);


            List<ToolStripMenuItem> items;
            UtilidadesForms.checkPermiso(altasToolStripMenuItem, Permisos.Alta_personal);
            items = new List<ToolStripMenuItem> {
                editarToolStripMenuItem, bajasToolStripMenuItem, consultarToolStripMenuItem
            };
            UtilidadesForms.checkPermiso(items, Permisos.Gestion_personal);
            UtilidadesForms.checkPermiso(certificacionDeServiciosToolStripMenuItem, Permisos.Gestion_Certificado);
            UtilidadesForms.checkPermiso(altasToolStripMenuItem, Permisos.Alta_personal);
            items = new List<ToolStripMenuItem> {
                puestosToolStripMenuItem, áreasToolStripMenuItem
            };
            UtilidadesForms.checkPermiso(items, Permisos.Gestion_Jerarquia);
            UtilidadesForms.checkPermiso(usuariosToolStripMenuItem, Permisos.Gestion_Usuario);
            UtilidadesForms.checkPermiso(perfilesToolStripMenuItem, Permisos.Gestion_Perfiles);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaPersonal alta = new frmAltaPersonal();
            alta.Show();
        }

        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAreas area = new frmAreas();
            area.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPuesto puestos = new frmPuesto();
            puestos.Show();
        }

        private void crearEvaluacionDeDesempenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaEvaluacionDesempenio evaluacionDesempenio = new frmAltaEvaluacionDesempenio();
            evaluacionDesempenio.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaEvaluacionDesempenio consultarEvaluacionDesempenio = new frmConsultaEvaluacionDesempenio();
            consultarEvaluacionDesempenio.Show();
        }

        private void certificacionDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCertificacionServicios frm = new frmCertificacionServicios();
            frm.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario frm = new frmConsultaUsuario();
            frm.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles frm = new frmPerfiles();
            frm.ShowDialog();
        }
    }
}
