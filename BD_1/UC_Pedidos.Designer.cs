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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tlpFormulario = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            dtpFecha = new DateTimePicker();
            label8 = new Label();
            cmbIDSesion = new ComboBox();
            nmdCantidad = new NumericUpDown();
            label5 = new Label();
            cmbFormato = new ComboBox();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox2 = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ped_id_pedido = new DataGridViewTextBoxColumn();
            sf_id_sesion = new DataGridViewTextBoxColumn();
            ped_formato_entrega = new DataGridViewTextBoxColumn();
            ped_fecha_entrega = new DataGridViewTextBoxColumn();
            ped_cantidad = new DataGridViewTextBoxColumn();
            tlpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdCantidad).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.FromArgb(227, 230, 245);
            tlpFormulario.ColumnCount = 2;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormulario.Controls.Add(label3, 1, 1);
            tlpFormulario.Controls.Add(label2, 0, 0);
            tlpFormulario.Controls.Add(label4, 0, 3);
            tlpFormulario.Controls.Add(dtpFecha, 0, 4);
            tlpFormulario.Controls.Add(label8, 0, 1);
            tlpFormulario.Controls.Add(cmbIDSesion, 0, 2);
            tlpFormulario.Controls.Add(nmdCantidad, 1, 4);
            tlpFormulario.Controls.Add(label5, 1, 3);
            tlpFormulario.Controls.Add(cmbFormato, 1, 2);
            tlpFormulario.Controls.Add(panel1, 1, 5);
            tlpFormulario.Dock = DockStyle.Bottom;
            tlpFormulario.Location = new Point(0, 287);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.Padding = new Padding(20);
            tlpFormulario.RowCount = 6;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 38.57143F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 61.42857F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.Size = new Size(976, 265);
            tlpFormulario.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(641, 48);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 27;
            label3.Text = "Formato de entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(219, 22);
            label2.TabIndex = 1;
            label2.Text = "📦 Datos de los pedidos";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(183, 121);
            label4.Name = "label4";
            label4.Size = new Size(142, 23);
            label4.TabIndex = 29;
            label4.Text = "Fecha de entrega";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Location = new Point(98, 156);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(311, 29);
            dtpFecha.TabIndex = 28;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(224, 48);
            label8.Name = "label8";
            label8.Size = new Size(59, 23);
            label8.TabIndex = 25;
            label8.Text = "Sesión";
            // 
            // cmbIDSesion
            // 
            cmbIDSesion.Anchor = AnchorStyles.None;
            cmbIDSesion.Font = new Font("Segoe UI", 9.5F);
            cmbIDSesion.FormattingEnabled = true;
            cmbIDSesion.Location = new Point(128, 81);
            cmbIDSesion.Name = "cmbIDSesion";
            cmbIDSesion.Size = new Size(252, 29);
            cmbIDSesion.TabIndex = 24;
            // 
            // nmdCantidad
            // 
            nmdCantidad.Anchor = AnchorStyles.None;
            nmdCantidad.Font = new Font("Segoe UI", 9.5F);
            nmdCantidad.Location = new Point(647, 156);
            nmdCantidad.Name = "nmdCantidad";
            nmdCantidad.Size = new Size(150, 29);
            nmdCantidad.TabIndex = 31;
            nmdCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(682, 121);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 30;
            label5.Text = "Cantidad";
            // 
            // cmbFormato
            // 
            cmbFormato.Anchor = AnchorStyles.None;
            cmbFormato.Font = new Font("Segoe UI", 9.5F);
            cmbFormato.FormattingEnabled = true;
            cmbFormato.Items.AddRange(new object[] { "OPALINA", "DIGITAL", "ALBUM", "IMPRESION" });
            cmbFormato.Location = new Point(598, 81);
            cmbFormato.Name = "cmbFormato";
            cmbFormato.Size = new Size(247, 29);
            cmbFormato.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(491, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 49);
            panel1.TabIndex = 42;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(199, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(355, 8);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 41);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAgregar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnEliminar, 3, 0);
            tableLayoutPanel2.Controls.Add(btnEditar, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 57);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(976, 59);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 9.5F);
            textBox2.Location = new Point(35, 15);
            textBox2.Margin = new Padding(30, 3, 20, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Buscar por nombre";
            textBox2.Size = new Size(469, 29);
            textBox2.TabIndex = 2;
            textBox2.Tag = "";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(527, 8);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "➕ Nuevo pedido";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(856, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(718, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(976, 57);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(439, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 11;
            label1.Text = "Pedidos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ped_id_pedido, sf_id_sesion, ped_formato_entrega, ped_fecha_entrega, ped_cantidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(227, 230, 245);
            dataGridView1.Location = new Point(0, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(976, 171);
            dataGridView1.TabIndex = 23;
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
            // UC_Pedidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(tlpFormulario);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Pedidos";
            Size = new Size(976, 552);
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdCantidad).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTelefono;
        private TextBox txtApMat;
        private TextBox txtEmail;
        private TextBox txtApPat;
        private TextBox txtNombre;
        private TableLayoutPanel tlpFormulario;
        private Label label2;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ped_id_pedido;
        private DataGridViewTextBoxColumn sf_id_sesion;
        private DataGridViewTextBoxColumn ped_formato_entrega;
        private DataGridViewTextBoxColumn ped_fecha_entrega;
        private DataGridViewTextBoxColumn ped_cantidad;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFecha;
        private Label label8;
        private ComboBox cmbIDSesion;
        private NumericUpDown nmdCantidad;
        private Label label5;
        private ComboBox cmbFormato;
    }
}
