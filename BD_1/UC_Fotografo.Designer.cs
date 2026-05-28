namespace BD_1
{
    partial class UC_Fotografo
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
            tableLayoutPanel2 = new TableLayoutPanel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dgvFotografos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apPat = new DataGridViewTextBoxColumn();
            apMat = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            tlpFormulario = new TableLayoutPanel();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtApMat = new TextBox();
            txtApPat = new TextBox();
            txtNombre = new TextBox();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label8 = new Label();
            cmbEspecialidad = new ComboBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label12 = new Label();
            txtMotificado = new TextBox();
            txtFechaModi = new TextBox();
            label11 = new Label();
            label9 = new Label();
            txtCreado = new TextBox();
            txtFechaC = new TextBox();
            label10 = new Label();
            label7 = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFotografos).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tlpFormulario.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel2.Controls.Add(txtBuscar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnAgregar, 2, 0);
            tableLayoutPanel2.Controls.Add(btnEliminar, 4, 0);
            tableLayoutPanel2.Controls.Add(btnEditar, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 57);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(938, 59);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(30, 15);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(376, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.Tag = "";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(429, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(559, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(815, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(697, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
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
            tableLayoutPanel1.Size = new Size(938, 57);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(408, 13);
            label1.Name = "label1";
            label1.Size = new Size(121, 31);
            label1.TabIndex = 11;
            label1.Text = "Fotógrafo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvFotografos
            // 
            dgvFotografos.AllowUserToAddRows = false;
            dgvFotografos.AllowUserToDeleteRows = false;
            dgvFotografos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFotografos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFotografos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFotografos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFotografos.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apPat, apMat, telefono, especialidad });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFotografos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFotografos.Dock = DockStyle.Fill;
            dgvFotografos.GridColor = Color.FromArgb(227, 230, 245);
            dgvFotografos.Location = new Point(0, 116);
            dgvFotografos.Name = "dgvFotografos";
            dgvFotografos.ReadOnly = true;
            dgvFotografos.RowHeadersVisible = false;
            dgvFotografos.RowHeadersWidth = 51;
            dgvFotografos.Size = new Size(938, 522);
            dgvFotografos.TabIndex = 15;
            // 
            // id
            // 
            id.FillWeight = 68.4491959F;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.FillWeight = 112.506271F;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apPat
            // 
            apPat.FillWeight = 114.16674F;
            apPat.HeaderText = "Ap. paterno";
            apPat.MinimumWidth = 6;
            apPat.Name = "apPat";
            apPat.ReadOnly = true;
            // 
            // apMat
            // 
            apMat.FillWeight = 117.320549F;
            apMat.HeaderText = "Ap. materno";
            apMat.MinimumWidth = 6;
            apMat.Name = "apMat";
            apMat.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.FillWeight = 88.42706F;
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // especialidad
            // 
            especialidad.FillWeight = 86.12268F;
            especialidad.HeaderText = "Especialidad";
            especialidad.MinimumWidth = 6;
            especialidad.Name = "especialidad";
            especialidad.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tlpFormulario, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Bottom;
            tableLayoutPanel3.Location = new Point(0, 177);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 58.35141F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 41.64859F));
            tableLayoutPanel3.Size = new Size(938, 461);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.FromArgb(227, 230, 245);
            tlpFormulario.ColumnCount = 3;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormulario.Controls.Add(label2, 0, 0);
            tlpFormulario.Controls.Add(label5, 2, 1);
            tlpFormulario.Controls.Add(label3, 0, 1);
            tlpFormulario.Controls.Add(label4, 1, 1);
            tlpFormulario.Controls.Add(txtApMat, 2, 2);
            tlpFormulario.Controls.Add(txtApPat, 1, 2);
            tlpFormulario.Controls.Add(txtNombre, 0, 2);
            tlpFormulario.Controls.Add(panel1, 2, 5);
            tlpFormulario.Controls.Add(label8, 0, 3);
            tlpFormulario.Controls.Add(cmbEspecialidad, 0, 4);
            tlpFormulario.Controls.Add(label6, 1, 3);
            tlpFormulario.Controls.Add(txtTelefono, 1, 4);
            tlpFormulario.Dock = DockStyle.Bottom;
            tlpFormulario.Location = new Point(3, 3);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.Padding = new Padding(20);
            tlpFormulario.RowCount = 6;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 56.1797752F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 43.8202248F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.Size = new Size(932, 263);
            tlpFormulario.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(210, 25);
            label2.TabIndex = 1;
            label2.Text = "👤 Datos del fotógrafo";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(692, 47);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 18;
            label5.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(132, 47);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(397, 47);
            label4.Name = "label4";
            label4.Size = new Size(136, 21);
            label4.TabIndex = 17;
            label4.Text = "Apellido Paterno";
            // 
            // txtApMat
            // 
            txtApMat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApMat.Font = new Font("Segoe UI", 9.5F);
            txtApMat.Location = new Point(664, 74);
            txtApMat.Margin = new Padding(50, 3, 50, 3);
            txtApMat.Name = "txtApMat";
            txtApMat.Size = new Size(198, 29);
            txtApMat.TabIndex = 23;
            // 
            // txtApPat
            // 
            txtApPat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApPat.Font = new Font("Segoe UI", 9.5F);
            txtApPat.Location = new Point(367, 74);
            txtApPat.Margin = new Padding(50, 3, 50, 3);
            txtApPat.Name = "txtApPat";
            txtApPat.Size = new Size(197, 29);
            txtApPat.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(70, 74);
            txtNombre.Margin = new Padding(50, 3, 50, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 29);
            txtNombre.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(617, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 61);
            panel1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(18, 6);
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
            btnGuardar.Location = new Point(171, 6);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 41);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(117, 114);
            label8.Name = "label8";
            label8.Size = new Size(103, 23);
            label8.TabIndex = 20;
            label8.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEspecialidad.Font = new Font("Segoe UI", 9.5F);
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "RETRATO", "BODA", "PRODUCTO", "NATURALEZA", "EVENTO" });
            cmbEspecialidad.Location = new Point(23, 145);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(291, 29);
            cmbEspecialidad.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(428, 114);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 19;
            label6.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Font = new Font("Segoe UI", 9.5F);
            txtTelefono.Location = new Point(367, 145);
            txtTelefono.Margin = new Padding(50, 3, 50, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(197, 29);
            txtTelefono.TabIndex = 24;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label12, 0, 0);
            tableLayoutPanel4.Controls.Add(txtMotificado, 0, 4);
            tableLayoutPanel4.Controls.Add(txtFechaModi, 1, 4);
            tableLayoutPanel4.Controls.Add(label11, 1, 3);
            tableLayoutPanel4.Controls.Add(label9, 0, 3);
            tableLayoutPanel4.Controls.Add(txtCreado, 0, 2);
            tableLayoutPanel4.Controls.Add(txtFechaC, 1, 2);
            tableLayoutPanel4.Controls.Add(label10, 1, 1);
            tableLayoutPanel4.Controls.Add(label7, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 272);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel4.Size = new Size(932, 186);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(203, 25);
            label12.TabIndex = 29;
            label12.Text = "📋 Datos de Auditoría";
            // 
            // txtMotificado
            // 
            txtMotificado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMotificado.BackColor = Color.FromArgb(227, 230, 245);
            txtMotificado.Font = new Font("Segoe UI", 9.5F);
            txtMotificado.Location = new Point(50, 141);
            txtMotificado.Margin = new Padding(50, 3, 50, 3);
            txtMotificado.Name = "txtMotificado";
            txtMotificado.ReadOnly = true;
            txtMotificado.Size = new Size(366, 29);
            txtMotificado.TabIndex = 23;
            // 
            // txtFechaModi
            // 
            txtFechaModi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFechaModi.BackColor = Color.FromArgb(227, 230, 245);
            txtFechaModi.Font = new Font("Segoe UI", 9.5F);
            txtFechaModi.Location = new Point(516, 141);
            txtFechaModi.Margin = new Padding(50, 3, 50, 3);
            txtFechaModi.Name = "txtFechaModi";
            txtFechaModi.ReadOnly = true;
            txtFechaModi.Size = new Size(366, 29);
            txtFechaModi.TabIndex = 28;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(607, 102);
            label11.Name = "label11";
            label11.Size = new Size(184, 23);
            label11.TabIndex = 26;
            label11.Text = "Fecha de modificación:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(168, 102);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 24;
            label9.Text = "Modificado por:";
            // 
            // txtCreado
            // 
            txtCreado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCreado.BackColor = Color.FromArgb(227, 230, 245);
            txtCreado.Font = new Font("Segoe UI", 9.5F);
            txtCreado.Location = new Point(50, 68);
            txtCreado.Margin = new Padding(50, 3, 50, 3);
            txtCreado.Name = "txtCreado";
            txtCreado.ReadOnly = true;
            txtCreado.Size = new Size(366, 29);
            txtCreado.TabIndex = 22;
            // 
            // txtFechaC
            // 
            txtFechaC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFechaC.BackColor = Color.FromArgb(227, 230, 245);
            txtFechaC.Font = new Font("Segoe UI", 9.5F);
            txtFechaC.Location = new Point(516, 68);
            txtFechaC.Margin = new Padding(50, 3, 50, 3);
            txtFechaC.Name = "txtFechaC";
            txtFechaC.ReadOnly = true;
            txtFechaC.Size = new Size(366, 29);
            txtFechaC.TabIndex = 27;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(623, 40);
            label10.Name = "label10";
            label10.Size = new Size(151, 23);
            label10.TabIndex = 25;
            label10.Text = "Fecha de creación:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(183, 40);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 17;
            label7.Text = "Creado por:";
            // 
            // UC_Fotografo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dgvFotografos);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Fotografo";
            Size = new Size(938, 638);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFotografos).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dgvFotografos;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apPat;
        private DataGridViewTextBoxColumn apMat;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn especialidad;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label12;
        private TextBox txtMotificado;
        private TextBox txtFechaModi;
        private Label label11;
        private Label label9;
        private TextBox txtCreado;
        private TextBox txtFechaC;
        private Label label10;
        private Label label7;
        private TableLayoutPanel tlpFormulario;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txtApMat;
        private TextBox txtApPat;
        private TextBox txtNombre;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label8;
        private ComboBox cmbEspecialidad;
        private Label label6;
        private TextBox txtTelefono;
    }
}
