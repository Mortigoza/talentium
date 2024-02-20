using Comun;
using LogicaNegocio;
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
using Vista.Gestion_de_Talento;
using Vista.Lenguajes;
using LogicaNegocio.Administracion_Del_Personal;

namespace Vista
{
    public partial class frmMenu : Form
    {
        private CN_AdministracionDatosPersonal datosPersonales;
        public frmMenu()
        {
            InitializeComponent();
            datosPersonales = new CN_AdministracionDatosPersonal();
            Idioma.CargarIdioma(this.Controls, this); //Asigno los nombres a los controles del formulario

            string permisos = "";
            PermisosCache[] listaPermisos = PermisosCache.GetPermisos();
            for (int i = 0, len = listaPermisos.Length; i < len; i++)
            {
                permisos += $"{listaPermisos[i].Id}: {listaPermisos[i].Permiso}\n";
            }
            //MessageBox.Show(permisos);


            List<ToolStripMenuItem> items;
            // AdminPersonal
            UtilidadesForms.checkPermiso(altasToolStripMenuItem, Permisos.Alta_personal);
            UtilidadesForms.checkPermiso(consultarToolStripMenuItem, Permisos.Gestion_personal);

            // GestTalento
            UtilidadesForms.checkPermiso(altaCandidatoToolStripMenuItem, Permisos.Alta_PrSeleccion);
            UtilidadesForms.checkPermiso(gestiónCandidatoToolStripMenuItem, Permisos.Gestion_PrSeleccion);
            UtilidadesForms.checkPermiso(altaEvaluaciónDeDesempeñoToolStripMenuItem, Permisos.Alta_Desempeño);
            UtilidadesForms.checkPermiso(gestionDeDesempeñoToolStripMenuItem, Permisos.Gestion_Desempeño);
            UtilidadesForms.checkPermiso(asignarToolStripMenuItem, Permisos.Gestion_Capacitaciones);
            UtilidadesForms.checkPermiso(gestionDeCapacitacionesToolStripMenuItem, Permisos.Gestion_Capacitaciones);

            // GestAsistencia
            UtilidadesForms.checkPermiso(consultaDeAsistenciasToolStripMenuItem, Permisos.Gestion_Asistencias);

            // NominaSalarial
            items = new List<ToolStripMenuItem>{
                conveniosToolStripMenuItem, categoriasToolStripMenuItem
            };
            UtilidadesForms.checkPermiso(items, Permisos.Gestion_Nomina);

            // AnalisisYReportes
            UtilidadesForms.checkPermiso(asistenciasToolStripMenuItem1, Permisos.Gestion_Informes);
            UtilidadesForms.checkPermiso(desempeñoToolStripMenuItem, Permisos.Gestion_Informes);
            UtilidadesForms.checkPermiso(nóminaSalarialToolStripMenuItem1, Permisos.Gestion_Informes);
            UtilidadesForms.checkPermiso(certificacionDeServiciosToolStripMenuItem, Permisos.Gestion_Certificado);

            // Accesibilidad
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
            this.Hide();
            frmConsultaPersonal frm = new frmConsultaPersonal();
            frm.ShowDialog();
            this.Show();
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaPersonal alta = new frmAltaPersonal(false);
            alta.ShowDialog();
            this.Show();
        }

        private void áreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAreas area = new frmAreas();
            area.ShowDialog();
            this.Show();
        }

        private void puestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPuesto puestos = new frmPuesto();
            puestos.ShowDialog();
            this.Show();
        }

        private void crearEvaluacionDeDesempenioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaEvaluacionDesempenio evaluacionDesempenio = new frmAltaEvaluacionDesempenio();
            evaluacionDesempenio.ShowDialog();
            this.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaEvaluacionDesempenio consultarEvaluacionDesempenio = new frmConsultaEvaluacionDesempenio();
            consultarEvaluacionDesempenio.ShowDialog();
            this.Show();
        }

        private void certificacionDeServiciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCertificacionServicios frm = new frmCertificacionServicios();
            frm.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaUsuario frm = new frmConsultaUsuario();
            frm.ShowDialog();
            this.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPerfiles frm = new frmPerfiles();
            frm.ShowDialog();
            this.Show();
        }

        private void asistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencias frm = new Asistencias();
            frm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            CN_LogicaLogout logout = new CN_LogicaLogout();
            logout.Logout(this);
        }

        private void altaCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaPersonal frm = new frmAltaPersonal(true);
            frm.ShowDialog();
            this.Show();
        }

        private void gestiónCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaProcesoDeSeleccion frm = new frmConsultaProcesoDeSeleccion();
            frm.ShowDialog();
            this.Show();
        }

        private void altaEvaluaciónDeDesempeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaEvaluacionDesempenio frm = new frmAltaEvaluacionDesempenio();
            frm.ShowDialog();
            this.Show();
        }

        private void gestionDeDesempeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaEvaluacionDesempenio frm = new frmConsultaEvaluacionDesempenio();
            frm.ShowDialog();
            this.Show();
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gestionDeCapacitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmABMCapacitaciones frm = new frmABMCapacitaciones();
            frm.ShowDialog();
            this.Show();
        }

        private void consultaDeAsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencias frm = new Asistencias();
            frm.ShowDialog();
            this.Show();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CambioDePassRecupero frm = new CambioDePassRecupero();
            frm.ShowDialog();
            this.Show();
        }

        private void conveniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConvenios frm = new frmConvenios();
            frm.ShowDialog();
            this.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategorias frm = new frmCategorias();
            frm.ShowDialog();
            this.Show();
        }

        private void configuraciónDeEntrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfigEntrevistas frm = new frmConfigEntrevistas();
            frm.ShowDialog();
            this.Show();
        }

        private void configuraciónDeAltaPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConfigAltaPersonal frm = new frmConfigAltaPersonal();
            frm.ShowDialog();
            this.Show();
        }
    }
}
