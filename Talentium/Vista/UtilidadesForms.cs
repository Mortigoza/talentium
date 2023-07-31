﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

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

        // Maneja texto excrito en un textbox del formulario
        public static void TextboxDynamic(TextBox txt)
        {
            if (txt.Text == null || txt.Text == txt.AccessibleName)
            {
                txt.Text = null;
                txt.ForeColor = System.Drawing.Color.Black;
            }
        }
        public static void restaurar(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.Text = txt.AccessibleName;
                txt.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}