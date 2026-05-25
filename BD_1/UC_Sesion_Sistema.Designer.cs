namespace BD_1
{
    partial class UC_Sesion_Sistema
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnCerrar = new Button();
            dgvGestion = new DataGridView();
            ses_id = new DataGridViewTextBoxColumn();
            ses_usuario = new DataGridViewTextBoxColumn();
            ses_IP = new DataGridViewTextBoxColumn();
            ses_inicio = new DataGridViewTextBoxColumn();
            ses_ultima_actividad = new DataGridViewTextBoxColumn();
            ses_fin = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(970, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(369, 14);
            label4.Name = "label4";
            label4.Size = new Size(232, 31);
            label4.TabIndex = 12;
            label4.Text = "Sesiones del sistema";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(227, 230, 245);
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 139F));
            tableLayoutPanel3.Controls.Add(txtBuscar, 0, 0);
            tableLayoutPanel3.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnCerrar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 60);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(970, 59);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(30, 15);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(442, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.Tag = "";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(495, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Tomato;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(650, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(178, 39);
            btnCerrar.TabIndex = 9;
            btnCerrar.Text = "⛔ Cerrar Sesión";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // dgvGestion
            // 
            dgvGestion.AllowUserToAddRows = false;
            dgvGestion.AllowUserToDeleteRows = false;
            dgvGestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGestion.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGestion.Columns.AddRange(new DataGridViewColumn[] { ses_id, ses_usuario, ses_IP, ses_inicio, ses_ultima_actividad, ses_fin });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGestion.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGestion.Dock = DockStyle.Fill;
            dgvGestion.GridColor = Color.FromArgb(227, 230, 245);
            dgvGestion.Location = new Point(0, 119);
            dgvGestion.Name = "dgvGestion";
            dgvGestion.ReadOnly = true;
            dgvGestion.RowHeadersVisible = false;
            dgvGestion.RowHeadersWidth = 51;
            dgvGestion.Size = new Size(970, 478);
            dgvGestion.TabIndex = 26;
            // 
            // ses_id
            // 
            ses_id.FillWeight = 68.4491959F;
            ses_id.HeaderText = "ID";
            ses_id.MinimumWidth = 6;
            ses_id.Name = "ses_id";
            ses_id.ReadOnly = true;
            // 
            // ses_usuario
            // 
            ses_usuario.FillWeight = 112.506271F;
            ses_usuario.HeaderText = "Usuario";
            ses_usuario.MinimumWidth = 6;
            ses_usuario.Name = "ses_usuario";
            ses_usuario.ReadOnly = true;
            // 
            // ses_IP
            // 
            ses_IP.HeaderText = "Rol";
            ses_IP.MinimumWidth = 6;
            ses_IP.Name = "ses_IP";
            ses_IP.ReadOnly = true;
            // 
            // ses_inicio
            // 
            ses_inicio.HeaderText = "Inicio";
            ses_inicio.MinimumWidth = 6;
            ses_inicio.Name = "ses_inicio";
            ses_inicio.ReadOnly = true;
            // 
            // ses_ultima_actividad
            // 
            ses_ultima_actividad.FillWeight = 117.320549F;
            ses_ultima_actividad.HeaderText = "Última Actividad";
            ses_ultima_actividad.MinimumWidth = 6;
            ses_ultima_actividad.Name = "ses_ultima_actividad";
            ses_ultima_actividad.ReadOnly = true;
            // 
            // ses_fin
            // 
            ses_fin.HeaderText = "Fin";
            ses_fin.MinimumWidth = 6;
            ses_fin.Name = "ses_fin";
            ses_fin.ReadOnly = true;
            // 
            // UC_Sesion_Sistema
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvGestion);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Sesion_Sistema";
            Size = new Size(970, 597);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGestion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnCerrar;
        private DataGridView dgvGestion;
        private DataGridViewTextBoxColumn ses_id;
        private DataGridViewTextBoxColumn ses_usuario;
        private DataGridViewTextBoxColumn ses_IP;
        private DataGridViewTextBoxColumn ses_inicio;
        private DataGridViewTextBoxColumn ses_ultima_actividad;
        private DataGridViewTextBoxColumn ses_fin;
    }
}
