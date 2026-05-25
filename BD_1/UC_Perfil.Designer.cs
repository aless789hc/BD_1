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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            btnGuardar = new Button();
            txtFecha = new TextBox();
            label3 = new Label();
            txtActual = new TextBox();
            txtNuevaP = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtConfirmarP = new TextBox();
            btnMostrarNueva = new Button();
            btnConfirmarContra = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.34265757F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0839157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.5734253F));
            tableLayoutPanel1.Size = new Size(934, 593);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 13, 162);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 37);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtUsuario);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(txtFecha);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtActual);
            panel2.Controls.Add(txtNuevaP);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtConfirmarP);
            panel2.Controls.Add(btnMostrarNueva);
            panel2.Controls.Add(btnConfirmarContra);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 138);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 50, 0, 0);
            panel2.Size = new Size(934, 438);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(413, 0);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 29;
            label1.Text = "Mi perfil";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(213, 107);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 16;
            label2.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(227, 230, 245);
            txtUsuario.Location = new Point(66, 131);
            txtUsuario.Margin = new Padding(40, 3, 40, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(362, 27);
            txtUsuario.TabIndex = 18;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(395, 394);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(151, 41);
            btnGuardar.TabIndex = 28;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.None;
            txtFecha.BackColor = Color.FromArgb(227, 230, 245);
            txtFecha.Location = new Point(514, 131);
            txtFecha.Margin = new Padding(40, 3, 40, 3);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(364, 27);
            txtFecha.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(625, 107);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 17;
            label3.Text = "Fecha de registro";
            // 
            // txtActual
            // 
            txtActual.Anchor = AnchorStyles.None;
            txtActual.BackColor = Color.FromArgb(227, 230, 245);
            txtActual.Location = new Point(293, 213);
            txtActual.Name = "txtActual";
            txtActual.PasswordChar = '*';
            txtActual.Size = new Size(353, 27);
            txtActual.TabIndex = 23;
            // 
            // txtNuevaP
            // 
            txtNuevaP.Anchor = AnchorStyles.None;
            txtNuevaP.BackColor = Color.FromArgb(227, 230, 245);
            txtNuevaP.Location = new Point(293, 281);
            txtNuevaP.Name = "txtNuevaP";
            txtNuevaP.PasswordChar = '*';
            txtNuevaP.Size = new Size(353, 27);
            txtNuevaP.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(394, 249);
            label5.Name = "label5";
            label5.Size = new Size(151, 23);
            label5.TabIndex = 21;
            label5.Text = "Nueva Contraseña";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(395, 181);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 20;
            label4.Text = "Contraseña actual";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(354, 317);
            label6.Name = "label6";
            label6.Size = new Size(226, 23);
            label6.TabIndex = 22;
            label6.Text = "Confirmar nueva contraseña";
            // 
            // txtConfirmarP
            // 
            txtConfirmarP.Anchor = AnchorStyles.None;
            txtConfirmarP.BackColor = Color.FromArgb(227, 230, 245);
            txtConfirmarP.Location = new Point(289, 349);
            txtConfirmarP.Name = "txtConfirmarP";
            txtConfirmarP.PasswordChar = '*';
            txtConfirmarP.Size = new Size(357, 27);
            txtConfirmarP.TabIndex = 25;
            // 
            // btnMostrarNueva
            // 
            btnMostrarNueva.Anchor = AnchorStyles.None;
            btnMostrarNueva.BackColor = Color.FromArgb(103, 148, 226);
            btnMostrarNueva.FlatStyle = FlatStyle.Flat;
            btnMostrarNueva.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrarNueva.ForeColor = Color.White;
            btnMostrarNueva.Location = new Point(652, 281);
            btnMostrarNueva.Name = "btnMostrarNueva";
            btnMostrarNueva.Size = new Size(52, 32);
            btnMostrarNueva.TabIndex = 26;
            btnMostrarNueva.Text = "👁️";
            btnMostrarNueva.UseVisualStyleBackColor = false;
            btnMostrarNueva.Click += btnMostrarNueva_Click;
            // 
            // btnConfirmarContra
            // 
            btnConfirmarContra.Anchor = AnchorStyles.None;
            btnConfirmarContra.BackColor = Color.FromArgb(103, 148, 226);
            btnConfirmarContra.FlatStyle = FlatStyle.Flat;
            btnConfirmarContra.Font = new Font("Segoe UI Emoji", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmarContra.ForeColor = Color.White;
            btnConfirmarContra.Location = new Point(652, 348);
            btnConfirmarContra.Name = "btnConfirmarContra";
            btnConfirmarContra.Size = new Size(52, 28);
            btnConfirmarContra.TabIndex = 27;
            btnConfirmarContra.Text = "👁️";
            btnConfirmarContra.UseVisualStyleBackColor = false;
            btnConfirmarContra.Click += btnConfirmarContra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(0, 80, 0, 30);
            pictureBox1.Size = new Size(928, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // UC_Perfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Perfil";
            Size = new Size(934, 593);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label label2;
        private TextBox txtUsuario;
        private Button btnGuardar;
        private TextBox txtFecha;
        private Label label3;
        private TextBox txtActual;
        private TextBox txtNuevaP;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtConfirmarP;
        private Button btnMostrarNueva;
        private Button btnConfirmarContra;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
