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
            button3 = new Button();
            btnPedido = new Button();
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
            panel_sideBar.Controls.Add(button3);
            panel_sideBar.Controls.Add(btnPedido);
            panel_sideBar.Controls.Add(btnSesion);
            panel_sideBar.Controls.Add(btnFotografo);
            panel_sideBar.Controls.Add(btnClientes);
            panel_sideBar.Controls.Add(btnInicio);
            panel_sideBar.Controls.Add(panel3);
            panel_sideBar.Dock = DockStyle.Left;
            panel_sideBar.Location = new Point(0, 0);
            panel_sideBar.Name = "panel_sideBar";
            panel_sideBar.Size = new Size(220, 666);
            panel_sideBar.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 13, 162);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 275);
            button3.Name = "button3";
            button3.Size = new Size(220, 45);
            button3.TabIndex = 19;
            button3.Text = "⚙️ Administrador";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(50, 13, 162);
            btnPedido.Dock = DockStyle.Top;
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Segoe UI", 13.8F);
            btnPedido.ForeColor = Color.White;
            btnPedido.Location = new Point(0, 230);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(220, 45);
            btnPedido.TabIndex = 18;
            btnPedido.Text = "\U0001f6d2 Pedidos";
            btnPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
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
            btnSesion.Size = new Size(220, 45);
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
            btnFotografo.Size = new Size(220, 45);
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
            btnClientes.Size = new Size(220, 45);
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
            btnInicio.Size = new Size(220, 45);
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
            panel3.Size = new Size(220, 50);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
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
            button6.Location = new Point(159, 0);
            button6.Name = "button6";
            button6.Size = new Size(61, 50);
            button6.TabIndex = 0;
            button6.Text = "≡";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel_Contenido
            // 
            panel_Contenido.Dock = DockStyle.Fill;
            panel_Contenido.Location = new Point(220, 0);
            panel_Contenido.Name = "panel_Contenido";
            panel_Contenido.Size = new Size(999, 666);
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
        private Button button3;
        private Button btnPedido;
        private Button btnSesion;
    }
}