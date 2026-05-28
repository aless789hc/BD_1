using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BD_1
{
    public partial class UC_Cliente : UserControl
    {

        public UC_Cliente()
        {
            InitializeComponent();
            tlpFormulario.Visible = false;
        }


        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
        }




        private void btnBuscar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tlpFormulario.Visible = true;
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0) return;
            tlpFormulario.Visible = true;
            //Aqui se cargan los datos del cliente seleccionado en el formulario para editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tlpFormulario.Visible = false;
            // Aquí se elimina el cliente seleccionado
        }

       

        

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            tlpFormulario.Visible = false;
            LimpiarFormulario();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // INSERT o UPDATE según sea agregar o editar

            tlpFormulario.Visible = false;
            LimpiarFormulario();
        }
    }
}
