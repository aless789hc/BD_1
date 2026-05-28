namespace BD_1
{
    partial class UC_Gestion
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbRol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnMostrarNueva = new Button();
            txtPwd = new TextBox();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            dgvGestion = new DataGridView();
            usr_id = new DataGridViewTextBoxColumn();
            usr_nombre = new DataGridViewTextBoxColumn();
            usr_creado = new DataGridViewTextBoxColumn();
            usr_rol = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestion).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1094, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(435, 14);
            label4.Name = "label4";
            label4.Size = new Size(224, 31);
            label4.TabIndex = 12;
            label4.Text = "Gestión de usuarios";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(cmbRol, 2, 1);
            tableLayoutPanel2.Controls.Add(label1, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(btnAgregar, 2, 2);
            tableLayoutPanel2.Controls.Add(txtNombre, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 2, 0);
            tableLayoutPanel2.Controls.Add(panel1, 1, 1);
            tableLayoutPanel2.Controls.Add(button1, 1, 2);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 46.9879532F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 53.0120468F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(1094, 137);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbRol.BackColor = Color.FromArgb(227, 230, 245);
            cmbRol.Font = new Font("Segoe UI", 9.5F);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(731, 56);
            cmbRol.Margin = new Padding(3, 3, 50, 3);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(313, 29);
            cmbRol.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(497, 11);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 29;
            label1.Text = "Contraseña";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(148, 11);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 17;
            label2.Text = "Usuario";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(731, 99);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(128, 35);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(227, 230, 245);
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(50, 56);
            txtNombre.Margin = new Padding(50, 3, 20, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre de usuario";
            txtNombre.Size = new Size(294, 29);
            txtNombre.TabIndex = 18;
            txtNombre.Tag = "";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(894, 11);
            label3.Name = "label3";
            label3.Size = new Size(34, 23);
            label3.TabIndex = 30;
            label3.Text = "Rol";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMostrarNueva);
            panel1.Controls.Add(txtPwd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(367, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 45);
            panel1.TabIndex = 28;
            // 
            // btnMostrarNueva
            // 
            btnMostrarNueva.Anchor = AnchorStyles.None;
            btnMostrarNueva.BackColor = Color.FromArgb(103, 148, 226);
            btnMostrarNueva.FlatStyle = FlatStyle.Flat;
            btnMostrarNueva.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarNueva.ForeColor = Color.White;
            btnMostrarNueva.Location = new Point(303, 3);
            btnMostrarNueva.Name = "btnMostrarNueva";
            btnMostrarNueva.Size = new Size(52, 32);
            btnMostrarNueva.TabIndex = 27;
            btnMostrarNueva.Text = "👁️";
            btnMostrarNueva.UseVisualStyleBackColor = false;
            btnMostrarNueva.Click += btnMostrarNueva_Click;
            // 
            // txtPwd
            // 
            txtPwd.Anchor = AnchorStyles.None;
            txtPwd.BackColor = Color.FromArgb(227, 230, 245);
            txtPwd.Font = new Font("Segoe UI", 9.5F);
            txtPwd.Location = new Point(3, 5);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(294, 29);
            txtPwd.TabIndex = 25;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Tomato;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(570, 99);
            button1.Margin = new Padding(50, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(155, 35);
            button1.TabIndex = 31;
            button1.Text = "✖️ Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(227, 230, 245);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 124F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tableLayoutPanel3.Controls.Add(txtBuscar, 0, 0);
            tableLayoutPanel3.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnEditar, 2, 0);
            tableLayoutPanel3.Controls.Add(btnEliminar, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 197);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1094, 59);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(30, 15);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(566, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.Tag = "";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(619, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(774, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(898, 3);
            btnEliminar.Margin = new Padding(3, 3, 50, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvGestion
            // 
            dgvGestion.AllowUserToAddRows = false;
            dgvGestion.AllowUserToDeleteRows = false;
            dgvGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestion.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvGestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvGestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestion.Columns.AddRange(new DataGridViewColumn[] { usr_id, usr_nombre, usr_creado, usr_rol });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvGestion.DefaultCellStyle = dataGridViewCellStyle2;
            dgvGestion.Dock = DockStyle.Fill;
            dgvGestion.GridColor = Color.FromArgb(227, 230, 245);
            dgvGestion.Location = new Point(0, 256);
            dgvGestion.Name = "dgvGestion";
            dgvGestion.ReadOnly = true;
            dgvGestion.RowHeadersVisible = false;
            dgvGestion.RowHeadersWidth = 51;
            dgvGestion.Size = new Size(1094, 368);
            dgvGestion.TabIndex = 25;
            // 
            // usr_id
            // 
            usr_id.FillWeight = 68.4491959F;
            usr_id.HeaderText = "ID";
            usr_id.MinimumWidth = 6;
            usr_id.Name = "usr_id";
            usr_id.ReadOnly = true;
            // 
            // usr_nombre
            // 
            usr_nombre.FillWeight = 112.506271F;
            usr_nombre.HeaderText = "Usuario";
            usr_nombre.MinimumWidth = 6;
            usr_nombre.Name = "usr_nombre";
            usr_nombre.ReadOnly = true;
            // 
            // usr_creado
            // 
            usr_creado.FillWeight = 117.320549F;
            usr_creado.HeaderText = "Fecha de creación";
            usr_creado.MinimumWidth = 6;
            usr_creado.Name = "usr_creado";
            usr_creado.ReadOnly = true;
            // 
            // usr_rol
            // 
            usr_rol.HeaderText = "Rol";
            usr_rol.MinimumWidth = 6;
            usr_rol.Name = "usr_rol";
            usr_rol.ReadOnly = true;
            // 
            // UC_Gestion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvGestion);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Gestion";
            Size = new Size(1094, 624);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnAgregar;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnEditar;
        private Button btnEliminar;
        private DataGridView dgvGestion;
        private DataGridViewTextBoxColumn usr_id;
        private DataGridViewTextBoxColumn usr_nombre;
        private DataGridViewTextBoxColumn usr_creado;
        private DataGridViewTextBoxColumn usr_rol;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtPwd;
        private Panel panel1;
        private Button btnMostrarNueva;
        private Label label1;
        private ComboBox cmbRol;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}
