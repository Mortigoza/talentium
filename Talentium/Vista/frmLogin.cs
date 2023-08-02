﻿using Comun;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Talentium : Form
    {
        public Talentium()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CN_LogicaLogin.LogIn(txtUsername.Text, txtPassword.Text);
            
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            UtilidadesForms.restaurar(txtUsername);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            UtilidadesForms.restaurar(txtPassword);
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.TextboxDynamic(txtUsername);
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            UtilidadesForms.TextboxDynamic(txtPassword);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void btnMostrar_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
