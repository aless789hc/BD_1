using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_1
{
    public partial class UC_Gestion : UserControl
    {
        private bool mostrandoPwd = false;
        public UC_Gestion()
        {
            InitializeComponent();
        }

        private void btnMostrarNueva_Click(object sender, EventArgs e)
        {
            mostrandoPwd = !mostrandoPwd;
            txtPwd.PasswordChar = mostrandoPwd ? '\0' : '*';
        }
    }
}
