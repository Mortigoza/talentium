using System;
using System.Data;
using AccesoDatos;
using Comun;
using System.Windows.Forms;
using LogicaNegocio.Lenguajes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogicaNegocio
{
    public class CN_CambiarPassword
    {
        CD_AccesoBD acceso = new CD_AccesoBD();
        public DataTable ObtenerTodasPregutasSeg()
        {
            return acceso.ConsultarTodasPregSeg();
        }
        public DataTable ObtenerPregutasUsuarios(int id_preg)
        {
            return acceso.Consulta1PgtaSeg(id_preg);
            //return acceso.ConsultaPregSeg(id);
        }
        public DataTable ObtenerRespuetasUsuarios(int id)
        {
            return acceso.ConsultaRtaSeg(id);
            
        }
        public void insertarRta(int idUsuario, string rta, int idPregunta)
        {
            //user ya viene hasheado
            try
            {
               

                acceso.InsertarRespuestaSeg(idUsuario, rta, idPregunta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
        public void insertarPass(string user, string pass) 
        {
            //user ya viene hasheado
            try 
            {
                string usrBd = Seguridad.DesEncriptar(UserCache.usuario);
                string psw = Seguridad.Hash(usrBd + pass);
                string dig = Seguridad.Hash(Seguridad.DigVerif(Seguridad.Hash(pass)).ToString());
                //el nueva es false porqe en el unico momento que va a ser true es cuando se crea el usuario.
                bool nueva = false;
                acceso.InsertarNuevaPass(user, psw, dig, nueva );
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualiar la contraseña" + ex);
            }
        }
        public bool ValidarPass(bool esNuevo, bool allow, System.Windows.Forms.TextBox txtContra1, System.Windows.Forms.TextBox txtContra2, System.Windows.Forms.TextBox txtRespuesta, System.Windows.Forms.ComboBox cmbPreguntas)
        {
            if (string.IsNullOrWhiteSpace(txtContra1.Text) || string.IsNullOrWhiteSpace(txtContra2.Text))
            {
                MessageBox.Show(Errores.CamposIncompletos, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtContra1.Text != txtContra2.Text)
            {
                MessageBox.Show(Errores.PasNoIgual, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!allow)
            {
                MessageBox.Show(Errores.PasFaltaCriterio, Errores.Aviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPreguntas.SelectedItem != null && allow)
            {
                CN_CambiarPassword pass = new CN_CambiarPassword();
                switch (esNuevo)
                {
                    default:
                        pass.insertarPass(UserCache.usuario, txtContra2.Text);
                        return true;
                    case true:
                        DataRowView selectedRow = (DataRowView)cmbPreguntas.SelectedItem;
                        int id = Convert.ToInt32(selectedRow["id_pregunta"]);

                        string rta = txtRespuesta.Text.ToUpper();

                        // Se realiza el insert de las respuestas y preguntas.
                        pass.insertarRta(UserCache.id, rta, id);
                        return true;
                }
            }
            return false;
        }
    }
}
