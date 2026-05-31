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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvSesiones = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            horas = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            cliente = new DataGridViewTextBoxColumn();
            fotografo = new DataGridViewTextBoxColumn();
            paquete = new DataGridViewTextBoxColumn();
            tlpFormulario = new TableLayoutPanel();
            label2 = new Label();
            cmbCliente = new ComboBox();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            cmbFotografo = new ComboBox();
            cmbEstado = new ComboBox();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            nmdHora = new NumericUpDown();
            label7 = new Label();
            cmbPaquete = new ComboBox();
            label8 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tabPage2 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            dgv_sesionesCompletadas = new DataGridView();
            v_Cliente = new DataGridViewTextBoxColumn();
            v_Fotografo = new DataGridViewTextBoxColumn();
            v_Fecha = new DataGridViewTextBoxColumn();
            v_Paquete = new DataGridViewTextBoxColumn();
            v_Estado = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            panel3 = new Panel();
            dgv_sesionesPremium = new DataGridView();
            vC_fecha = new DataGridViewTextBoxColumn();
            vC_cliente = new DataGridViewTextBoxColumn();
            vC_fotografo = new DataGridViewTextBoxColumn();
            vC_paquete = new DataGridViewTextBoxColumn();
            vC_precioFinal = new DataGridViewTextBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            tlpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sesionesCompletadas).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_sesionesPremium).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 581);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvSesiones);
            tabPage1.Controls.Add(tlpFormulario);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 548);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSesiones
            // 
            dgvSesiones.AllowUserToAddRows = false;
            dgvSesiones.AllowUserToDeleteRows = false;
            dgvSesiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSesiones.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesiones.Columns.AddRange(new DataGridViewColumn[] { id, fecha, horas, estado, cliente, fotografo, paquete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSesiones.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSesiones.Dock = DockStyle.Fill;
            dgvSesiones.GridColor = Color.FromArgb(227, 230, 245);
            dgvSesiones.Location = new Point(3, 119);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.ReadOnly = true;
            dgvSesiones.RowHeadersVisible = false;
            dgvSesiones.RowHeadersWidth = 51;
            dgvSesiones.Size = new Size(916, 113);
            dgvSesiones.TabIndex = 27;
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
            // horas
            // 
            horas.HeaderText = "Horas";
            horas.MinimumWidth = 6;
            horas.Name = "horas";
            horas.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
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
            // paquete
            // 
            paquete.HeaderText = "Paquete";
            paquete.MinimumWidth = 6;
            paquete.Name = "paquete";
            paquete.ReadOnly = true;
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
            tlpFormulario.Controls.Add(label7, 2, 4);
            tlpFormulario.Controls.Add(cmbPaquete, 1, 4);
            tlpFormulario.Controls.Add(label8, 1, 3);
            tlpFormulario.Controls.Add(panel1, 2, 6);
            tlpFormulario.Dock = DockStyle.Bottom;
            tlpFormulario.Location = new Point(3, 232);
            tlpFormulario.Name = "tlpFormulario";
            tlpFormulario.Padding = new Padding(20);
            tlpFormulario.RowCount = 7;
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 52.38095F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 47.61905F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tlpFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpFormulario.Size = new Size(916, 313);
            tlpFormulario.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(196, 25);
            label2.TabIndex = 1;
            label2.Text = "🗓️ Datos de la sesión";
            // 
            // cmbCliente
            // 
            cmbCliente.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbCliente.Font = new Font("Segoe UI", 9.5F);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(23, 92);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(285, 29);
            cmbCliente.TabIndex = 28;
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.None;
            dtpFecha.CalendarTitleBackColor = Color.CornflowerBlue;
            tlpFormulario.SetColumnSpan(dtpFecha, 2);
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Location = new Point(156, 242);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(310, 29);
            dtpFecha.TabIndex = 39;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(134, 56);
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
            cmbFotografo.Location = new Point(314, 92);
            cmbFotografo.Name = "cmbFotografo";
            cmbFotografo.Size = new Size(285, 29);
            cmbFotografo.TabIndex = 36;
            // 
            // cmbEstado
            // 
            cmbEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbEstado.Font = new Font("Segoe UI", 9.5F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Todos los estados", "Pendiente", "Confirmada", "Cancelada", "Completada" });
            cmbEstado.Location = new Point(605, 92);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(288, 29);
            cmbEstado.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(414, 56);
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
            label9.Location = new Point(718, 56);
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
            label5.Location = new Point(96, 132);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 31;
            label5.Text = "Duración (Horas)";
            // 
            // nmdHora
            // 
            nmdHora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nmdHora.Font = new Font("Segoe UI", 9.5F);
            nmdHora.Location = new Point(23, 163);
            nmdHora.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nmdHora.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmdHora.Name = "nmdHora";
            nmdHora.Size = new Size(285, 29);
            nmdHora.TabIndex = 40;
            nmdHora.TextAlign = HorizontalAlignment.Center;
            nmdHora.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            tlpFormulario.SetColumnSpan(label7, 2);
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(284, 198);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 33;
            label7.Text = "Fecha";
            // 
            // cmbPaquete
            // 
            cmbPaquete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbPaquete.FormattingEnabled = true;
            cmbPaquete.Location = new Point(314, 163);
            cmbPaquete.Name = "cmbPaquete";
            cmbPaquete.Size = new Size(285, 28);
            cmbPaquete.TabIndex = 43;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(420, 132);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 34;
            label8.Text = "Paquete";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(605, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 52);
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
            btnCancelar.Click += btnCancelar_Click_1;
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
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 163F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel2.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel2.Controls.Add(txtBuscar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEliminar, 4, 0);
            tableLayoutPanel2.Controls.Add(btnEditar, 3, 0);
            tableLayoutPanel2.Controls.Add(btnAgregar, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 60);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(916, 59);
            tableLayoutPanel2.TabIndex = 25;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(367, 8);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(35, 15);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(309, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.Tag = "";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(782, 8);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 39);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(662, 8);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 38);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(499, 8);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(157, 38);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "➕ Nueva sesión";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(916, 57);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(405, 13);
            label1.Name = "label1";
            label1.Size = new Size(106, 31);
            label1.TabIndex = 11;
            label1.Text = "Sesiones";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 548);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Completadas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Controls.Add(panel3, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(916, 542);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_sesionesCompletadas);
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 265);
            panel2.TabIndex = 0;
            // 
            // dgv_sesionesCompletadas
            // 
            dgv_sesionesCompletadas.AllowUserToAddRows = false;
            dgv_sesionesCompletadas.AllowUserToDeleteRows = false;
            dgv_sesionesCompletadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sesionesCompletadas.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_sesionesCompletadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_sesionesCompletadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sesionesCompletadas.Columns.AddRange(new DataGridViewColumn[] { v_Cliente, v_Fotografo, v_Fecha, v_Paquete, v_Estado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_sesionesCompletadas.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_sesionesCompletadas.Dock = DockStyle.Fill;
            dgv_sesionesCompletadas.GridColor = Color.FromArgb(227, 230, 245);
            dgv_sesionesCompletadas.Location = new Point(0, 57);
            dgv_sesionesCompletadas.Name = "dgv_sesionesCompletadas";
            dgv_sesionesCompletadas.ReadOnly = true;
            dgv_sesionesCompletadas.RowHeadersVisible = false;
            dgv_sesionesCompletadas.RowHeadersWidth = 51;
            dgv_sesionesCompletadas.Size = new Size(910, 208);
            dgv_sesionesCompletadas.TabIndex = 30;
            // 
            // v_Cliente
            // 
            v_Cliente.HeaderText = "Cliente";
            v_Cliente.MinimumWidth = 6;
            v_Cliente.Name = "v_Cliente";
            v_Cliente.ReadOnly = true;
            // 
            // v_Fotografo
            // 
            v_Fotografo.HeaderText = "Fotógrafo";
            v_Fotografo.MinimumWidth = 6;
            v_Fotografo.Name = "v_Fotografo";
            v_Fotografo.ReadOnly = true;
            // 
            // v_Fecha
            // 
            v_Fecha.HeaderText = "Fecha";
            v_Fecha.MinimumWidth = 6;
            v_Fecha.Name = "v_Fecha";
            v_Fecha.ReadOnly = true;
            // 
            // v_Paquete
            // 
            v_Paquete.HeaderText = "Tipo de paquete";
            v_Paquete.MinimumWidth = 6;
            v_Paquete.Name = "v_Paquete";
            v_Paquete.ReadOnly = true;
            // 
            // v_Estado
            // 
            v_Estado.HeaderText = "Estado";
            v_Estado.MinimumWidth = 6;
            v_Estado.Name = "v_Estado";
            v_Estado.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(910, 57);
            tableLayoutPanel4.TabIndex = 29;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(329, 13);
            label6.Name = "label6";
            label6.Size = new Size(251, 31);
            label6.TabIndex = 11;
            label6.Text = "Sesiones Completadas";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_sesionesPremium);
            panel3.Controls.Add(tableLayoutPanel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 274);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 265);
            panel3.TabIndex = 1;
            // 
            // dgv_sesionesPremium
            // 
            dgv_sesionesPremium.AllowUserToAddRows = false;
            dgv_sesionesPremium.AllowUserToDeleteRows = false;
            dgv_sesionesPremium.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sesionesPremium.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_sesionesPremium.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_sesionesPremium.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sesionesPremium.Columns.AddRange(new DataGridViewColumn[] { vC_fecha, vC_cliente, vC_fotografo, vC_paquete, vC_precioFinal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_sesionesPremium.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_sesionesPremium.Dock = DockStyle.Fill;
            dgv_sesionesPremium.GridColor = Color.FromArgb(227, 230, 245);
            dgv_sesionesPremium.Location = new Point(0, 57);
            dgv_sesionesPremium.Name = "dgv_sesionesPremium";
            dgv_sesionesPremium.ReadOnly = true;
            dgv_sesionesPremium.RowHeadersVisible = false;
            dgv_sesionesPremium.RowHeadersWidth = 51;
            dgv_sesionesPremium.Size = new Size(910, 208);
            dgv_sesionesPremium.TabIndex = 30;
            // 
            // vC_fecha
            // 
            vC_fecha.HeaderText = "Fecha";
            vC_fecha.MinimumWidth = 6;
            vC_fecha.Name = "vC_fecha";
            vC_fecha.ReadOnly = true;
            // 
            // vC_cliente
            // 
            vC_cliente.HeaderText = "Cliente";
            vC_cliente.MinimumWidth = 6;
            vC_cliente.Name = "vC_cliente";
            vC_cliente.ReadOnly = true;
            // 
            // vC_fotografo
            // 
            vC_fotografo.HeaderText = "Fotógrafo";
            vC_fotografo.MinimumWidth = 6;
            vC_fotografo.Name = "vC_fotografo";
            vC_fotografo.ReadOnly = true;
            // 
            // vC_paquete
            // 
            vC_paquete.HeaderText = "Paquete";
            vC_paquete.MinimumWidth = 6;
            vC_paquete.Name = "vC_paquete";
            vC_paquete.ReadOnly = true;
            // 
            // vC_precioFinal
            // 
            vC_precioFinal.HeaderText = "Precio final";
            vC_precioFinal.MinimumWidth = 6;
            vC_precioFinal.Name = "vC_precioFinal";
            vC_precioFinal.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.FromArgb(50, 13, 162);
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(label10, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Top;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(910, 57);
            tableLayoutPanel5.TabIndex = 29;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(350, 13);
            label10.Name = "label10";
            label10.Size = new Size(210, 31);
            label10.TabIndex = 11;
            label10.Text = "Sesiones Premium";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Sesiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "UC_Sesiones";
            Size = new Size(930, 581);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdHora).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_sesionesCompletadas).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_sesionesPremium).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvSesiones;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn horas;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn cliente;
        private DataGridViewTextBoxColumn fotografo;
        private DataGridViewTextBoxColumn paquete;
        private TableLayoutPanel tlpFormulario;
        private Label label2;
        private ComboBox cmbCliente;
        private DateTimePicker dtpFecha;
        private Label label3;
        private ComboBox cmbFotografo;
        private ComboBox cmbEstado;
        private Label label4;
        private Label label9;
        private Label label5;
        private NumericUpDown nmdHora;
        private Label label7;
        private ComboBox cmbPaquete;
        private Label label8;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button btnBuscar;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private DataGridView dgv_sesionesCompletadas;
        private DataGridViewTextBoxColumn v_Cliente;
        private DataGridViewTextBoxColumn v_Fotografo;
        private DataGridViewTextBoxColumn v_Fecha;
        private DataGridViewTextBoxColumn v_Paquete;
        private DataGridViewTextBoxColumn v_Estado;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label6;
        private Panel panel3;
        private DataGridView dgv_sesionesPremium;
        private DataGridViewTextBoxColumn vC_fecha;
        private DataGridViewTextBoxColumn vC_cliente;
        private DataGridViewTextBoxColumn vC_fotografo;
        private DataGridViewTextBoxColumn vC_paquete;
        private DataGridViewTextBoxColumn vC_precioFinal;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label10;
    }
}
