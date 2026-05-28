namespace BD_1
{
    public partial class UC_Sesiones : UserControl
    {
        public UC_Sesiones()
        {
            InitializeComponent();
            tlpFormulario.Visible = false;
        }
        private void LimpiarFormulario()
        {
            cmbCliente.Items.Clear();
            cmbFotografo.Items.Clear();
            cmbPaquete.Items.Clear();
            nmdHora.Value = 1;
            cmbEstado.SelectedIndex = 0;
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tlpFormulario.Visible = true;
            LimpiarFormulario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSesiones.SelectedRows.Count == 0) return;
            tlpFormulario.Visible = true;
            //Aqui se cargan los datos del cliente seleccionado en el formulario para editar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            tlpFormulario.Visible = false;
            // Aquí se elimina el cliente seleccionado
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // INSERT o UPDATE según sea agregar o editar

            tlpFormulario.Visible = false;
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tlpFormulario.Visible = false;
            LimpiarFormulario();
        }
    }
}
