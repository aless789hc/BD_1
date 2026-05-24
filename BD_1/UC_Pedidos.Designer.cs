namespace BD_1
{
    partial class UC_Pedidos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ped_id_pedido = new DataGridViewTextBoxColumn();
            sf_id_sesion = new DataGridViewTextBoxColumn();
            ped_formato_entrega = new DataGridViewTextBoxColumn();
            ped_fecha_entrega = new DataGridViewTextBoxColumn();
            ped_cantidad = new DataGridViewTextBoxColumn();
            panel_formulario = new Panel();
            nmdCantidad = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            cmbFormato = new ComboBox();
            label8 = new Label();
            cmbIDSesion = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 115);
            panel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(812, 42);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 39);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(686, 43);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(534, 43);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(394, 43);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Goudy Old Style", 10.2F);
            textBox1.Location = new Point(23, 43);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por nombre";
            textBox1.Size = new Size(365, 28);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.8F);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 0;
            label1.Text = "Pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ped_id_pedido, sf_id_sesion, ped_formato_entrega, ped_fecha_entrega, ped_cantidad });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(227, 230, 245);
            dataGridView1.Location = new Point(0, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 437);
            dataGridView1.TabIndex = 3;
            // 
            // ped_id_pedido
            // 
            ped_id_pedido.FillWeight = 68.4491959F;
            ped_id_pedido.HeaderText = "ID";
            ped_id_pedido.MinimumWidth = 6;
            ped_id_pedido.Name = "ped_id_pedido";
            ped_id_pedido.ReadOnly = true;
            // 
            // sf_id_sesion
            // 
            sf_id_sesion.FillWeight = 112.506271F;
            sf_id_sesion.HeaderText = "ID sesion";
            sf_id_sesion.MinimumWidth = 6;
            sf_id_sesion.Name = "sf_id_sesion";
            sf_id_sesion.ReadOnly = true;
            // 
            // ped_formato_entrega
            // 
            ped_formato_entrega.FillWeight = 114.16674F;
            ped_formato_entrega.HeaderText = "Formato de Entrega";
            ped_formato_entrega.MinimumWidth = 6;
            ped_formato_entrega.Name = "ped_formato_entrega";
            ped_formato_entrega.ReadOnly = true;
            // 
            // ped_fecha_entrega
            // 
            ped_fecha_entrega.FillWeight = 117.320549F;
            ped_fecha_entrega.HeaderText = "Fecha entrega";
            ped_fecha_entrega.MinimumWidth = 6;
            ped_fecha_entrega.Name = "ped_fecha_entrega";
            ped_fecha_entrega.ReadOnly = true;
            // 
            // ped_cantidad
            // 
            ped_cantidad.FillWeight = 88.42706F;
            ped_cantidad.HeaderText = "Cantidad";
            ped_cantidad.MinimumWidth = 6;
            ped_cantidad.Name = "ped_cantidad";
            ped_cantidad.ReadOnly = true;
            // 
            // panel_formulario
            // 
            panel_formulario.BackColor = Color.FromArgb(227, 230, 245);
            panel_formulario.Controls.Add(nmdCantidad);
            panel_formulario.Controls.Add(label5);
            panel_formulario.Controls.Add(label4);
            panel_formulario.Controls.Add(dtpFecha);
            panel_formulario.Controls.Add(label3);
            panel_formulario.Controls.Add(cmbFormato);
            panel_formulario.Controls.Add(label8);
            panel_formulario.Controls.Add(cmbIDSesion);
            panel_formulario.Controls.Add(btnCancelar);
            panel_formulario.Controls.Add(btnGuardar);
            panel_formulario.Controls.Add(label2);
            panel_formulario.Dock = DockStyle.Bottom;
            panel_formulario.Location = new Point(0, 215);
            panel_formulario.Name = "panel_formulario";
            panel_formulario.Size = new Size(976, 337);
            panel_formulario.TabIndex = 4;
            panel_formulario.Visible = false;
            // 
            // nmdCantidad
            // 
            nmdCantidad.Location = new Point(531, 190);
            nmdCantidad.Name = "nmdCantidad";
            nmdCantidad.Size = new Size(150, 27);
            nmdCantidad.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 10.8F);
            label5.Location = new Point(563, 163);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 20;
            label5.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.8F);
            label4.Location = new Point(231, 152);
            label4.Name = "label4";
            label4.Size = new Size(141, 24);
            label4.TabIndex = 19;
            label4.Text = "Fecha de entrega";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(190, 192);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 27);
            dtpFecha.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.8F);
            label3.Location = new Point(533, 73);
            label3.Name = "label3";
            label3.Size = new Size(163, 24);
            label3.TabIndex = 17;
            label3.Text = "Formato de entrega";
            // 
            // cmbFormato
            // 
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Items.AddRange(new object[] { "OPALINA", "DIGITAL", "ALBUM", "IMPRESION" });
            cmbFormato.Location = new Point(492, 100);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(247, 28);
            cmbFormato.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Palatino Linotype", 10.8F);
            label8.Location = new Point(254, 73);
            label8.Name = "label8";
            label8.Size = new Size(60, 24);
            label8.TabIndex = 15;
            label8.Text = "Sesión";
            // 
            // cmbIDSesion
            // 
            cmbIDSesion.FormattingEnabled = true;
            cmbIDSesion.Location = new Point(190, 100);
            cmbIDSesion.Name = "cmbIDSesion";
            cmbIDSesion.Size = new Size(194, 28);
            cmbIDSesion.TabIndex = 13;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(617, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(757, 272);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.8F);
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(199, 24);
            label2.TabIndex = 0;
            label2.Text = "👤 Datos de los pedidos";
            // 
            // UC_Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_formulario);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "UC_Pedidos";
            Size = new Size(976, 552);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel_formulario.ResumeLayout(false);
            panel_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel_formulario;
        private Label label8;
        private ComboBox cmbIDSesion;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private TextBox txtApMat;
        private TextBox txtEmail;
        private TextBox txtApPat;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label2;
        private DataGridViewTextBoxColumn ped_id_pedido;
        private DataGridViewTextBoxColumn sf_id_sesion;
        private DataGridViewTextBoxColumn ped_formato_entrega;
        private DataGridViewTextBoxColumn ped_fecha_entrega;
        private DataGridViewTextBoxColumn ped_cantidad;
        private NumericUpDown nmdCantidad;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label3;
        private ComboBox cmbFormato;
    }
}
