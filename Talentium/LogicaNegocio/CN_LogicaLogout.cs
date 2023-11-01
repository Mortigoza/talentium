using Comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaNegocio
{
    public class CN_LogicaLogout
    {
        private void limpiarCache()
        {
            UserCache.Clear();
            PermisosCache.Clear();
        }
        public void Logout(Form frm)
        {
            limpiarCache();
            frm.DialogResult = DialogResult.OK;
            frm.Dispose();
        }
    }
}
