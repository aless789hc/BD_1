using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_1
{
    public partial class UC_Perfil : UserControl
    {
        private bool mostrarNPwd = false;
        private bool mostrarCPwd = false;
        // aqui la fecha de registro la puse en textbox
        public UC_Perfil()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarNueva_Click(object sender, EventArgs e)
        {
            mostrarNPwd = !mostrarNPwd;
            txtNuevaP.PasswordChar = mostrarNPwd ? '\0' : '*';
        }

        private void btnConfirmarContra_Click(object sender, EventArgs e)
        {
            mostrarCPwd = !mostrarCPwd;
            txtConfirmarP.PasswordChar = mostrarCPwd ? '\0' : '*';
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //checar que la nueva contraseña y la confirmación coincidan. Al igual que la contraseña actual sea correcta. Si todo es correcto, actualizar la contraseña en la base de datos.
        }
    }
}
