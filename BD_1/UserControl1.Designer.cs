namespace BD_1
{
    partial class UserControl1
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
            tlpFormulario.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tlpFormulario.Location = new Point(0, 288);
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
            tlpFormulario.Size = new Size(1057, 272);
            tlpFormulario.TabIndex = 15;
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
            label5.Location = new Point(796, 53);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 18;
            label5.Text = "Apellido Materno";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(153, 53);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(460, 53);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 17;
            label4.Text = "Apellido Paterno";
            // 
            // txtApMat
            // 
            txtApMat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApMat.Font = new Font("Segoe UI", 9.5F);
            txtApMat.Location = new Point(748, 83);
            txtApMat.Margin = new Padding(50, 3, 50, 3);
            txtApMat.Name = "txtApMat";
            txtApMat.Size = new Size(239, 29);
            txtApMat.TabIndex = 23;
            // 
            // txtApPat
            // 
            txtApPat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtApPat.Font = new Font("Segoe UI", 9.5F);
            txtApPat.Location = new Point(409, 83);
            txtApPat.Margin = new Padding(50, 3, 50, 3);
            txtApPat.Name = "txtApPat";
            txtApPat.Size = new Size(239, 29);
            txtApPat.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(70, 83);
            txtNombre.Margin = new Padding(50, 3, 50, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(239, 29);
            txtNombre.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(701, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 61);
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
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(138, 123);
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
            cmbEspecialidad.Location = new Point(23, 154);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(333, 29);
            cmbEspecialidad.TabIndex = 27;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(491, 123);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 19;
            label6.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTelefono.Font = new Font("Segoe UI", 9.5F);
            txtTelefono.Location = new Point(409, 154);
            txtTelefono.Margin = new Padding(50, 3, 50, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(239, 29);
            txtTelefono.TabIndex = 24;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpFormulario);
            Name = "UserControl1";
            Size = new Size(1057, 560);
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
