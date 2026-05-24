namespace BD_1
{
    partial class UC_Sesiones
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
            textBox2 = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            fotografo = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            label2 = new Label();
            tlpFormulario = new TableLayoutPanel();
            cmbCliente = new ComboBox();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            cmbFotografo = new ComboBox();
            cmbEstado = new ComboBox();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            nmdHora = new NumericUpDown();
            label6 = new Label();
            label8 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tlpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel2.Size = new Size(930, 59);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Font = new Font("Segoe UI", 9.5F);
            textBox2.Location = new Point(35, 15);
            textBox2.Margin = new Padding(30, 3, 20, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Buscar por nombre";
            textBox2.Size = new Size(423, 29);
            textBox2.TabIndex = 2;
            textBox2.Tag = "";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(481, 8);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "➕ Nueva sesión";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(810, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 39);
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
            btnEditar.Location = new Point(672, 8);
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
            tableLayoutPanel1.Size = new Size(930, 57);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 13);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 11;
            label1.Text = "Sesiones";
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, fecha, tipo, cliente, fotografo, horas, precio, estado });
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
            dataGridView1.Size = new Size(930, 152);
            dataGridView1.TabIndex = 19;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo";
            tipo.MinimumWidth = 6;
            tipo.Name = "tipo";
            tipo.ReadOnly = true;
            // 
            // cliente
            // 
            cliente.HeaderText = "Cliente";
            cliente.MinimumWidth = 6;
            cliente.Name = "cliente";
            cliente.ReadOnly = true;
            // 
            // fotografo
            // 
            fotografo.HeaderText = "Fotógrafo";
            fotografo.MinimumWidth = 6;
            fotografo.Name = "fotografo";
            fotografo.ReadOnly = true;
            // 
            // horas
            // 
            horas.HeaderText = "Horas";
            horas.MinimumWidth = 6;
            horas.Name = "horas";
            horas.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 1;
            label2.Text = "🗓️ Datos de la sesión";
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
            tlpFormulario.Controls.Add(cmbCliente, 0, 2);
            tlpFormulario.Controls.Add(dtpFecha, 0, 6);
            tlpFormulario.Controls.Add(label3, 0, 1);
            tlpFormulario.Controls.Add(cmbFotografo, 1, 2);
            tlpFormulario.Controls.Add(cmbEstado, 2, 2);
            tlpFormulario.Controls.Add(label4, 1, 1);
            tlpFormulario.Controls.Add(label9, 2, 1);
            tlpFormulario.Controls.Add(label5, 0, 3);
            tlpFormulario.Controls.Add(nmdHora, 0, 4);
            tlpFormulario.Controls.Add(label6, 1, 3);
            tlpFormulario.Controls.Add(label8, 2, 3);
            tlpFormulario.Controls.Add(txtPrecio, 2, 4);
            tlpFormulario.Controls.Add(label7, 0, 5);
            tlpFormulario.Controls.Add(panel1, 2, 7);
            tlpFormulario.Controls.Add(textBox1, 1, 4);
            tlpFormulario.Dock = DockStyle.Bottom;
            tlpFormulario.Location = new Point(0, 268);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.Padding = new Padding(20);
            tlpFormulario.RowCount = 8;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 44.2622948F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 55.7377052F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.Size = new Size(930, 313);
            tlpFormulario.TabIndex = 18;
            // 
            // cmbCliente
            // 
            cmbCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCliente.Font = new Font("Segoe UI", 9.5F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(23, 77);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(290, 29);
            cmbCliente.TabIndex = 28;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.CalendarTitleBackColor = Color.CornflowerBlue;
            tlpFormulario.SetColumnSpan(dtpFecha, 2);
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Location = new Point(161, 202);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(310, 29);
            dtpFecha.TabIndex = 39;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(136, 46);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 29;
            label3.Text = "Cliente";
            // 
            // cmbFotografo
            // 
            cmbFotografo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbFotografo.Font = new Font("Segoe UI", 9.5F);
            cmbFotografo.FormattingEnabled = true;
            cmbFotografo.Location = new Point(319, 77);
            cmbFotografo.Name = "cmbFotografo";
            cmbFotografo.Size = new Size(290, 29);
            cmbFotografo.TabIndex = 36;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.Font = new Font("Segoe UI", 9.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos los estados", "Pendiente", "Confirmada", "Cancelada", "Completada" });
            cmbEstado.Location = new Point(615, 77);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(292, 29);
            cmbEstado.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(422, 46);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 30;
            label4.Text = "Fotógrafo";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(730, 46);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 35;
            label9.Text = "Estado";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(99, 113);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 31;
            label5.Text = "Duración (Horas)";
            // 
            // nmdHora
            // 
            nmdHora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nmdHora.Font = new Font("Segoe UI", 9.5F);
            nmdHora.Location = new Point(23, 144);
            nmdHora.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nmdHora.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmdHora.Name = "nmdHora";
            nmdHora.Size = new Size(290, 29);
            nmdHora.TabIndex = 40;
            nmdHora.TextAlign = HorizontalAlignment.Center;
            nmdHora.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(404, 113);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 32;
            label6.Text = "Tipo de sesión";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(685, 113);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 34;
            label8.Text = "Precio del Paquete";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Font = new Font("Segoe UI", 9.5F);
            txtPrecio.Location = new Point(615, 144);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(292, 29);
            txtPrecio.TabIndex = 41;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            tlpFormulario.SetColumnSpan(label7, 2);
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(289, 179);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 33;
            label7.Text = "Fecha";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(615, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 52);
            panel1.TabIndex = 42;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(15, 3);
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
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(319, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 43;
            // 
            // UC_Sesiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(tlpFormulario);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Sesiones";
            Size = new Size(930, 581);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn fotografo;
        private DataGridViewTextBoxColumn horas;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn estado;
        private Label label2;
        private TableLayoutPanel tlpFormulario;
        private ComboBox cmbCliente;
        private ComboBox cmbEstado;
        private Label label8;
        private DateTimePicker dtpFecha;
        private Label label5;
        private Label label3;
        private NumericUpDown nmdHora;
        private Label label7;
        private Label label4;
        private Label label6;
        private TextBox txtPrecio;
        private Label label9;
        private ComboBox cmbFotografo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox textBox1;
    }
}
