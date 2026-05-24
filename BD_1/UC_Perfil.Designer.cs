namespace BD_1
{
    partial class UC_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Perfil));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel_formulario = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtTelefono = new TextBox();
            txtApMat = new TextBox();
            txtEmail = new TextBox();
            txtApPat = new TextBox();
            txtNombre = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_formulario.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel_formulario, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40.8602142F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 59.1397858F));
            tableLayoutPanel1.Size = new Size(934, 558);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 222);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(346, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 13, 162);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 38);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 187);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 1;
            label1.Text = "Mi perfil";
            // 
            // panel_formulario
            // 
            panel_formulario.BackColor = Color.FromArgb(227, 230, 245);
            panel_formulario.Controls.Add(btnCancelar);
            panel_formulario.Controls.Add(btnGuardar);
            panel_formulario.Controls.Add(txtTelefono);
            panel_formulario.Controls.Add(txtApMat);
            panel_formulario.Controls.Add(txtEmail);
            panel_formulario.Controls.Add(txtApPat);
            panel_formulario.Controls.Add(txtNombre);
            panel_formulario.Controls.Add(label7);
            panel_formulario.Controls.Add(label6);
            panel_formulario.Controls.Add(label5);
            panel_formulario.Controls.Add(label4);
            panel_formulario.Controls.Add(label3);
            panel_formulario.Controls.Add(label2);
            panel_formulario.Dock = DockStyle.Fill;
            panel_formulario.Location = new Point(3, 231);
            panel_formulario.Name = "panel_formulario";
            panel_formulario.Size = new Size(928, 324);
            panel_formulario.TabIndex = 10;
            panel_formulario.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(671, 266);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 41);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(821, 266);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 9.5F);
            txtTelefono.Location = new Point(567, 204);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(216, 29);
            txtTelefono.TabIndex = 10;
            // 
            // txtApMat
            // 
            txtApMat.Font = new Font("Segoe UI", 9.5F);
            txtApMat.Location = new Point(688, 122);
            txtApMat.Name = "txtApMat";
            txtApMat.Size = new Size(226, 29);
            txtApMat.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(81, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(409, 29);
            txtEmail.TabIndex = 8;
            // 
            // txtApPat
            // 
            txtApPat.Font = new Font("Segoe UI", 9.5F);
            txtApPat.Location = new Point(381, 122);
            txtApPat.Name = "txtApPat";
            txtApPat.Size = new Size(228, 29);
            txtApPat.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(81, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(230, 29);
            txtNombre.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(261, 178);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 5;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(642, 178);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 4;
            label6.Text = "Teléfono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(730, 95);
            label5.Name = "label5";
            label5.Size = new Size(142, 23);
            label5.TabIndex = 3;
            label5.Text = "Apellido Materno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(436, 95);
            label4.Name = "label4";
            label4.Size = new Size(136, 23);
            label4.TabIndex = 2;
            label4.Text = "Apellido Paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(160, 95);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(188, 25);
            label2.TabIndex = 0;
            label2.Text = "👤 Datos del Cliente";
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Perfil";
            Size = new Size(934, 558);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_formulario.ResumeLayout(false);
            panel_formulario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Panel panel_formulario;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtTelefono;
        private TextBox txtApMat;
        private TextBox txtEmail;
        private TextBox txtApPat;
        private TextBox txtNombre;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
