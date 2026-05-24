namespace BD_1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            txtPassword = new MaskedTextBox();
            btnVer = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(227, 230, 245);
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(50, 252);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "👤Tu nombre de usuario";
            textBox1.Size = new Size(265, 29);
            textBox1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(227, 230, 245);
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(50, 319);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(265, 29);
            txtPassword.TabIndex = 2;
            // 
            // btnVer
            // 
            btnVer.BackColor = Color.FromArgb(103, 148, 226);
            btnVer.FlatStyle = FlatStyle.Flat;
            btnVer.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVer.ForeColor = Color.White;
            btnVer.Location = new Point(271, 319);
            btnVer.Margin = new Padding(0);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(44, 29);
            btnVer.TabIndex = 3;
            btnVer.Text = "👁️";
            btnVer.UseVisualStyleBackColor = false;
            btnVer.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 13, 162);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(101, 379);
            button1.Name = "button1";
            button1.Size = new Size(168, 43);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(50, 214);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(50, 286);
            label2.Name = "label2";
            label2.Size = new Size(118, 28);
            label2.TabIndex = 6;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(227, 230, 245);
            label3.Font = new Font("Goudy Old Style", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(27, 44, 193);
            label3.Location = new Point(19, 451);
            label3.Name = "label3";
            label3.Size = new Size(345, 66);
            label3.TabIndex = 7;
            label3.Text = "             Si no tienes cuenta, \r\n ⚠️        contacta al administrador del sistema \r\n             para que registre tu acceso.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("French Script MT", 22F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(67, 9);
            label4.Name = "label4";
            label4.Size = new Size(248, 42);
            label4.TabIndex = 8;
            label4.Text = "Estudio Fotográfico";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(383, 589);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnVer);
            Controls.Add(txtPassword);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private MaskedTextBox txtPassword;
        private Button btnVer;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
