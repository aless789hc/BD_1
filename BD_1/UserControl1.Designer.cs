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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel_formulario = new Panel();
            txtPrecio = new TextBox();
            nmdHora = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            cmbEstado = new ComboBox();
            cmbTipo = new ComboBox();
            cmbFotografo = new ComboBox();
            cmbCliente = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            fotografo = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            textBox1 = new TextBox();
            panel_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel_formulario
            // 
            panel_formulario.BackColor = Color.FromArgb(227, 230, 245);
            panel_formulario.Controls.Add(txtPrecio);
            panel_formulario.Controls.Add(nmdHora);
            panel_formulario.Controls.Add(dtpFecha);
            panel_formulario.Controls.Add(cmbEstado);
            panel_formulario.Controls.Add(cmbTipo);
            panel_formulario.Controls.Add(cmbFotografo);
            panel_formulario.Controls.Add(cmbCliente);
            panel_formulario.Controls.Add(label9);
            panel_formulario.Controls.Add(label8);
            panel_formulario.Controls.Add(btnCancelar);
            panel_formulario.Controls.Add(btnGuardar);
            panel_formulario.Controls.Add(label7);
            panel_formulario.Controls.Add(label6);
            panel_formulario.Controls.Add(label5);
            panel_formulario.Controls.Add(label4);
            panel_formulario.Controls.Add(label3);
            panel_formulario.Controls.Add(label2);
            panel_formulario.Dock = DockStyle.Bottom;
            panel_formulario.Location = new Point(0, 223);
            panel_formulario.Name = "panel_formulario";
            panel_formulario.Size = new Size(1057, 337);
            panel_formulario.TabIndex = 9;
            panel_formulario.Visible = false;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.5F);
            txtPrecio.Location = new Point(607, 164);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(249, 29);
            txtPrecio.TabIndex = 23;
            // 
            // nmdHora
            // 
            nmdHora.Font = new Font("Segoe UI", 9.5F);
            nmdHora.Location = new Point(90, 165);
            nmdHora.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nmdHora.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmdHora.Name = "nmdHora";
            nmdHora.Size = new Size(150, 29);
            nmdHora.TabIndex = 22;
            nmdHora.TextAlign = HorizontalAlignment.Center;
            nmdHora.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarTitleBackColor = Color.CornflowerBlue;
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Location = new Point(314, 231);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(310, 29);
            dtpFecha.TabIndex = 21;
            // 
            // cmbEstado
            // 
            cmbEstado.Font = new Font("Segoe UI", 9.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos los estados", "Pendiente", "Confirmada", "Cancelada", "Completada" });
            cmbEstado.Location = new Point(602, 85);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(239, 29);
            cmbEstado.TabIndex = 20;
            // 
            // cmbTipo
            // 
            cmbTipo.Font = new Font("Segoe UI", 9.5F);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "RETRATO", "BODA", "PRODUCTO", "NATURALEZA", "EVENTO" });
            cmbTipo.Location = new Point(329, 163);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(249, 29);
            cmbTipo.TabIndex = 17;
            // 
            // cmbFotografo
            // 
            cmbFotografo.Font = new Font("Segoe UI", 9.5F);
            cmbFotografo.FormattingEnabled = true;
            cmbFotografo.Location = new Point(319, 85);
            cmbFotografo.Name = "cmbFotografo";
            cmbFotografo.Size = new Size(252, 29);
            cmbFotografo.TabIndex = 15;
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI", 9.5F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(46, 85);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(252, 29);
            cmbCliente.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(690, 59);
            label9.Name = "label9";
            label9.Size = new Size(61, 23);
            label9.TabIndex = 14;
            label9.Text = "Estado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(655, 136);
            label8.Name = "label8";
            label8.Size = new Size(152, 23);
            label8.TabIndex = 13;
            label8.Text = "Precio del Paquete";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(618, 280);
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
            btnGuardar.Location = new Point(781, 280);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(104, 41);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(442, 205);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 5;
            label7.Text = "Fecha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(394, 136);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 4;
            label6.Text = "Tipo de sesión";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(96, 136);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 3;
            label5.Text = "Duración (Horas)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(403, 59);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 2;
            label4.Text = "Fotógrafo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(133, 59);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 1;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 0;
            label2.Text = "🗓️ Datos de la sesión";
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
            dataGridView1.Location = new Point(0, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1057, 454);
            dataGridView1.TabIndex = 8;
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
            // panel2
            // 
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnAgregar);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 106);
            panel2.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 9.5F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Todos los fotógrafos" });
            comboBox2.Location = new Point(518, 16);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(212, 29);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Todos los estados", "Pendiente", "Confirmada", "Cancelada", "Completada" });
            comboBox1.Location = new Point(275, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 29);
            comboBox1.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(330, 50);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 39);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(518, 50);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(101, 38);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(748, 9);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 38);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "➕ Nueva Sesión";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Location = new Point(17, 16);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Buscar por nombre";
            textBox1.Size = new Size(227, 29);
            textBox1.TabIndex = 1;
            textBox1.Tag = "";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_formulario);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Name = "UserControl1";
            Size = new Size(1057, 560);
            panel_formulario.ResumeLayout(false);
            panel_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_formulario;
        private TextBox txtPrecio;
        private NumericUpDown nmdHora;
        private DateTimePicker dtpFecha;
        private ComboBox cmbEstado;
        private ComboBox cmbTipo;
        private ComboBox cmbFotografo;
        private ComboBox cmbCliente;
        private Label label9;
        private Label label8;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn fotografo;
        private DataGridViewTextBoxColumn horas;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn estado;
        private Panel panel2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox textBox1;
    }
}
