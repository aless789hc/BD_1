namespace BD_1
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panel_sideBar = new Panel();
            btnCerrarSesion = new Button();
            btnPerfil = new Button();
            btnSesionSistema = new Button();
            btnGestion = new Button();
            btnRol = new Button();
            btnPedido = new Button();
            btnPaquete = new Button();
            btnSesion = new Button();
            btnFotografo = new Button();
            btnClientes = new Button();
            btnInicio = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            panel_Contenido = new Panel();
            animTimer = new System.Windows.Forms.Timer(components);
            panel_sideBar.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_sideBar
            // 
            panel_sideBar.BackColor = Color.FromArgb(50, 13, 162);
            panel_sideBar.Controls.Add(btnCerrarSesion);
            panel_sideBar.Controls.Add(btnPerfil);
            panel_sideBar.Controls.Add(btnSesionSistema);
            panel_sideBar.Controls.Add(btnGestion);
            panel_sideBar.Controls.Add(btnRol);
            panel_sideBar.Controls.Add(btnPedido);
            panel_sideBar.Controls.Add(btnPaquete);
            panel_sideBar.Controls.Add(btnSesion);
            panel_sideBar.Controls.Add(btnFotografo);
            panel_sideBar.Controls.Add(btnClientes);
            panel_sideBar.Controls.Add(btnInicio);
            panel_sideBar.Controls.Add(panel3);
            panel_sideBar.Dock = DockStyle.Left;
            panel_sideBar.Location = new Point(0, 0);
            panel_sideBar.Name = "panel_sideBar";
            panel_sideBar.Size = new Size(225, 666);
            panel_sideBar.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(247, 34, 34);
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 13.8F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 621);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(225, 45);
            btnCerrarSesion.TabIndex = 23;
            btnCerrarSesion.Text = "⛔ Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.BackColor = Color.FromArgb(50, 13, 162);
            btnPerfil.Dock = DockStyle.Top;
            btnPerfil.FlatAppearance.BorderSize = 0;
            btnPerfil.FlatStyle = FlatStyle.Flat;
            btnPerfil.Font = new Font("Segoe UI", 13.8F);
            btnPerfil.ForeColor = Color.White;
            btnPerfil.Location = new Point(0, 526);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(225, 45);
            btnPerfil.TabIndex = 19;
            btnPerfil.Text = "👤Perfil";
            btnPerfil.TextAlign = ContentAlignment.MiddleLeft;
            btnPerfil.UseVisualStyleBackColor = false;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnSesionSistema
            // 
            btnSesionSistema.BackColor = Color.FromArgb(50, 13, 162);
            btnSesionSistema.Dock = DockStyle.Top;
            btnSesionSistema.FlatAppearance.BorderSize = 0;
            btnSesionSistema.FlatStyle = FlatStyle.Flat;
            btnSesionSistema.Font = new Font("Segoe UI", 13.8F);
            btnSesionSistema.ForeColor = Color.White;
            btnSesionSistema.Location = new Point(0, 444);
            btnSesionSistema.Name = "btnSesionSistema";
            btnSesionSistema.Size = new Size(225, 82);
            btnSesionSistema.TabIndex = 22;
            btnSesionSistema.Text = "🔑Sesiones\r\n del sistema";
            btnSesionSistema.TextAlign = ContentAlignment.MiddleLeft;
            btnSesionSistema.UseVisualStyleBackColor = false;
            btnSesionSistema.Click += btnSesionSistema_Click;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.FromArgb(50, 13, 162);
            btnGestion.Dock = DockStyle.Top;
            btnGestion.FlatAppearance.BorderSize = 0;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Segoe UI", 13.8F);
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(0, 371);
            btnGestion.Name = "btnGestion";
            btnGestion.Size = new Size(225, 73);
            btnGestion.TabIndex = 21;
            btnGestion.Text = "🛡️Gestión de Usuarios";
            btnGestion.TextAlign = ContentAlignment.MiddleLeft;
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // btnRol
            // 
            btnRol.BackColor = Color.FromArgb(50, 13, 162);
            btnRol.Dock = DockStyle.Top;
            btnRol.FlatAppearance.BorderSize = 0;
            btnRol.FlatStyle = FlatStyle.Flat;
            btnRol.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRol.ForeColor = Color.White;
            btnRol.Location = new Point(0, 320);
            btnRol.Name = "btnRol";
            btnRol.Size = new Size(225, 51);
            btnRol.TabIndex = 20;
            btnRol.Text = "🔒Roles y permisos";
            btnRol.TextAlign = ContentAlignment.MiddleLeft;
            btnRol.UseVisualStyleBackColor = false;
            btnRol.Click += btnRol_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(50, 13, 162);
            btnPedido.Dock = DockStyle.Top;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 13.8F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(0, 275);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(225, 45);
            btnPedido.TabIndex = 18;
            btnPedido.Text = "\U0001f6d2 Pedidos";
            btnPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // btnPaquete
            // 
            btnPaquete.BackColor = Color.FromArgb(50, 13, 162);
            btnPaquete.Dock = DockStyle.Top;
            btnPaquete.FlatAppearance.BorderSize = 0;
            btnPaquete.FlatStyle = FlatStyle.Flat;
            btnPaquete.Font = new Font("Segoe UI", 13.8F);
            btnPaquete.ForeColor = Color.White;
            btnPaquete.Location = new Point(0, 230);
            btnPaquete.Name = "btnPaquete";
            btnPaquete.Size = new Size(225, 45);
            btnPaquete.TabIndex = 24;
            btnPaquete.Text = "📦 Paquetes";
            btnPaquete.TextAlign = ContentAlignment.MiddleLeft;
            btnPaquete.UseVisualStyleBackColor = false;
            btnPaquete.Click += btnPaquete_Click;
            // 
            // btnSesion
            // 
            btnSesion.BackColor = Color.FromArgb(50, 13, 162);
            btnSesion.Dock = DockStyle.Top;
            btnSesion.FlatAppearance.BorderSize = 0;
            btnSesion.FlatStyle = FlatStyle.Flat;
            btnSesion.Font = new Font("Segoe UI", 13.8F);
            btnSesion.ForeColor = Color.White;
            btnSesion.Location = new Point(0, 185);
            btnSesion.Name = "btnSesion";
            btnSesion.Size = new Size(225, 45);
            btnSesion.TabIndex = 17;
            btnSesion.Text = "🗓️ Sesiones";
            btnSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnSesion.UseVisualStyleBackColor = false;
            btnSesion.Click += btnSesion_Click;
            // 
            // btnFotografo
            // 
            btnFotografo.BackColor = Color.FromArgb(50, 13, 162);
            btnFotografo.Dock = DockStyle.Top;
            btnFotografo.FlatAppearance.BorderSize = 0;
            btnFotografo.FlatStyle = FlatStyle.Flat;
            btnFotografo.Font = new Font("Segoe UI", 13.8F);
            btnFotografo.ForeColor = Color.White;
            btnFotografo.Location = new Point(0, 140);
            btnFotografo.Name = "btnFotografo";
            btnFotografo.Size = new Size(225, 45);
            btnFotografo.TabIndex = 15;
            btnFotografo.Text = "📷 Fotógrafo";
            btnFotografo.TextAlign = ContentAlignment.MiddleLeft;
            btnFotografo.UseVisualStyleBackColor = false;
            btnFotografo.Click += btnFotografo_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(50, 13, 162);
            btnClientes.Dock = DockStyle.Top;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 95);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(225, 45);
            btnClientes.TabIndex = 12;
            btnClientes.Text = "👥 Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.FromArgb(50, 13, 162);
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 14F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 50);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(225, 45);
            btnInicio.TabIndex = 11;
            btnInicio.Text = "🏠 Inicio";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += btnInicio_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button6);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 50);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(50, 13, 162);
            button6.Dock = DockStyle.Right;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(164, 0);
            button6.Name = "button6";
            button6.Size = new Size(61, 50);
            button6.TabIndex = 0;
            button6.Text = "≡";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel_Contenido
            // 
            panel_Contenido.Dock = DockStyle.Fill;
            panel_Contenido.Location = new Point(225, 0);
            panel_Contenido.Name = "panel_Contenido";
            panel_Contenido.Size = new Size(994, 666);
            panel_Contenido.TabIndex = 1;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1219, 666);
            Controls.Add(panel_Contenido);
            Controls.Add(panel_sideBar);
            Name = "DashBoard";
            Text = "DashBoard";
            WindowState = FormWindowState.Maximized;
            Load += DashBoard_Load;
            panel_sideBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sideBar;
        private Panel panel_Contenido;
        private Panel panel3;
        private Button btnFotografo;
        private Button btnClientes;
        private Button btnInicio;
        private Button button6;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer animTimer;
        private Button btnPerfil;
        private Button btnPedido;
        private Button btnSesion;
        private Button btnRol;
        private Button btnGestion;
        private Button btnSesionSistema;
        private Button btnCerrarSesion;
        private Button btnPaquete;
    }
}