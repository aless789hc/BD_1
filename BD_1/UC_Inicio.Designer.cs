namespace BD_1
{
    partial class UC_Inicio
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            label1 = new Label();
            dgvPedidos = new DataGridView();
            nomCli = new DataGridViewTextBoxColumn();
            formato = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            entrega = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            label11 = new Label();
            dgvSesiones = new DataGridView();
            nomCliente = new DataGridViewTextBoxColumn();
            fechaC = new DataGridViewTextBoxColumn();
            tipoCl = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel6 = new Panel();
            label13 = new Label();
            dgvFotografos = new DataGridView();
            nomFoto = new DataGridViewTextBoxColumn();
            sesiones = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            lblSesiones = new Label();
            lblNumSesiones = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblClientes = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblPedidos = new Label();
            label7 = new Label();
            panel4 = new Panel();
            lblIngresos = new Label();
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFotografos).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel8, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.90511F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.09489F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tableLayoutPanel1.Size = new Size(1150, 666);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnCancelar);
            panel8.Controls.Add(btnGuardar);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 611);
            panel8.Margin = new Padding(3, 3, 50, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(1097, 52);
            panel8.TabIndex = 43;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(227, 230, 245);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(703, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(202, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "📤Exportar reportes";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(922, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(167, 41);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "📥 Importar datos";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvPedidos, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 375);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1144, 230);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(50, 13, 162);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(1138, 34);
            panel7.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(484, 4);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 1;
            label1.Text = "Últimos pedidos";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { nomCli, formato, cantidad, entrega });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPedidos.Dock = DockStyle.Fill;
            dgvPedidos.GridColor = Color.FromArgb(227, 230, 245);
            dgvPedidos.Location = new Point(3, 43);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersVisible = false;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1138, 184);
            dgvPedidos.TabIndex = 4;
            // 
            // nomCli
            // 
            nomCli.HeaderText = "Cliente";
            nomCli.MinimumWidth = 6;
            nomCli.Name = "nomCli";
            nomCli.ReadOnly = true;
            // 
            // formato
            // 
            formato.HeaderText = "Formato";
            formato.MinimumWidth = 6;
            formato.Name = "formato";
            formato.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            // 
            // entrega
            // 
            entrega.HeaderText = "Entrega";
            entrega.MinimumWidth = 6;
            entrega.Name = "entrega";
            entrega.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 149);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1144, 220);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel5, 0, 0);
            tableLayoutPanel5.Controls.Add(dgvSesiones, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(566, 214);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 13, 162);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(560, 34);
            panel5.TabIndex = 1;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.FlatStyle = FlatStyle.Popup;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(190, 4);
            label11.Name = "label11";
            label11.Size = new Size(178, 25);
            label11.TabIndex = 1;
            label11.Text = " Próximas sesiones";
            // 
            // dgvSesiones
            // 
            dgvSesiones.AllowUserToAddRows = false;
            dgvSesiones.AllowUserToDeleteRows = false;
            dgvSesiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSesiones.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvSesiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvSesiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSesiones.Columns.AddRange(new DataGridViewColumn[] { nomCliente, fechaC, tipoCl, estado });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvSesiones.DefaultCellStyle = dataGridViewCellStyle10;
            dgvSesiones.Dock = DockStyle.Fill;
            dgvSesiones.GridColor = Color.FromArgb(227, 230, 245);
            dgvSesiones.Location = new Point(3, 43);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.ReadOnly = true;
            dgvSesiones.RowHeadersVisible = false;
            dgvSesiones.RowHeadersWidth = 51;
            dgvSesiones.Size = new Size(560, 168);
            dgvSesiones.TabIndex = 2;
            // 
            // nomCliente
            // 
            nomCliente.HeaderText = "Nombre";
            nomCliente.MinimumWidth = 6;
            nomCliente.Name = "nomCliente";
            nomCliente.ReadOnly = true;
            // 
            // fechaC
            // 
            fechaC.HeaderText = "Fecha";
            fechaC.MinimumWidth = 6;
            fechaC.Name = "fechaC";
            fechaC.ReadOnly = true;
            // 
            // tipoCl
            // 
            tipoCl.HeaderText = "Tipo";
            tipoCl.MinimumWidth = 6;
            tipoCl.Name = "tipoCl";
            tipoCl.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 6;
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(panel6, 0, 0);
            tableLayoutPanel6.Controls.Add(dgvFotografos, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(575, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(566, 214);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 13, 162);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label13);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(560, 34);
            panel6.TabIndex = 2;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.FlatStyle = FlatStyle.Popup;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(192, 4);
            label13.Name = "label13";
            label13.Size = new Size(176, 25);
            label13.TabIndex = 1;
            label13.Text = "Fotógrafos activos";
            // 
            // dgvFotografos
            // 
            dgvFotografos.AllowUserToAddRows = false;
            dgvFotografos.AllowUserToDeleteRows = false;
            dgvFotografos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFotografos.BackgroundColor = Color.White;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Control;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvFotografos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvFotografos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFotografos.Columns.AddRange(new DataGridViewColumn[] { nomFoto, sesiones });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Window;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle12.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvFotografos.DefaultCellStyle = dataGridViewCellStyle12;
            dgvFotografos.Dock = DockStyle.Fill;
            dgvFotografos.GridColor = Color.FromArgb(227, 230, 245);
            dgvFotografos.Location = new Point(3, 43);
            dgvFotografos.Name = "dgvFotografos";
            dgvFotografos.ReadOnly = true;
            dgvFotografos.RowHeadersVisible = false;
            dgvFotografos.RowHeadersWidth = 51;
            dgvFotografos.Size = new Size(560, 168);
            dgvFotografos.TabIndex = 3;
            // 
            // nomFoto
            // 
            nomFoto.HeaderText = "Nombre";
            nomFoto.MinimumWidth = 6;
            nomFoto.Name = "nomFoto";
            nomFoto.ReadOnly = true;
            // 
            // sesiones
            // 
            sesiones.HeaderText = "Sesiones pendientes";
            sesiones.MinimumWidth = 6;
            sesiones.Name = "sesiones";
            sesiones.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(panel1, 0, 0);
            tableLayoutPanel4.Controls.Add(panel2, 1, 0);
            tableLayoutPanel4.Controls.Add(panel3, 2, 0);
            tableLayoutPanel4.Controls.Add(panel4, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(1144, 140);
            tableLayoutPanel4.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(227, 230, 245);
            panel1.Controls.Add(lblSesiones);
            panel1.Controls.Add(lblNumSesiones);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 134);
            panel1.TabIndex = 0;
            // 
            // lblSesiones
            // 
            lblSesiones.Anchor = AnchorStyles.None;
            lblSesiones.Font = new Font("Segoe UI", 9F);
            lblSesiones.Location = new Point(20, 103);
            lblSesiones.Name = "lblSesiones";
            lblSesiones.Size = new Size(240, 23);
            lblSesiones.TabIndex = 2;
            lblSesiones.Text = "0 confirmadas | 0 pendientes";
            lblSesiones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumSesiones
            // 
            lblNumSesiones.Anchor = AnchorStyles.None;
            lblNumSesiones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumSesiones.Location = new Point(128, 68);
            lblNumSesiones.Name = "lblNumSesiones";
            lblNumSesiones.Size = new Size(31, 38);
            lblNumSesiones.TabIndex = 1;
            lblNumSesiones.Text = "0";
            lblNumSesiones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(79, 29);
            label2.Name = "label2";
            label2.Size = new Size(128, 27);
            label2.TabIndex = 0;
            label2.Text = "Sesiones hoy";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(227, 230, 245);
            panel2.Controls.Add(lblClientes);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(289, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 134);
            panel2.TabIndex = 1;
            // 
            // lblClientes
            // 
            lblClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClientes.Location = new Point(120, 68);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(31, 38);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "0";
            lblClientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(56, 29);
            label5.Name = "label5";
            label5.Size = new Size(158, 27);
            label5.TabIndex = 0;
            label5.Text = "Clientes Activos";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 230, 245);
            panel3.Controls.Add(lblPedidos);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(575, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 134);
            panel3.TabIndex = 2;
            // 
            // lblPedidos
            // 
            lblPedidos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPedidos.Location = new Point(128, 72);
            lblPedidos.Name = "lblPedidos";
            lblPedidos.Size = new Size(26, 31);
            lblPedidos.TabIndex = 1;
            lblPedidos.Text = "0";
            lblPedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label7.Location = new Point(46, 27);
            label7.Name = "label7";
            label7.Size = new Size(188, 27);
            label7.TabIndex = 0;
            label7.Text = "Pedidos pendientes";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(227, 230, 245);
            panel4.Controls.Add(lblIngresos);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(861, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 134);
            panel4.TabIndex = 3;
            // 
            // lblIngresos
            // 
            lblIngresos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblIngresos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIngresos.Location = new Point(124, 72);
            lblIngresos.Name = "lblIngresos";
            lblIngresos.Size = new Size(26, 31);
            lblIngresos.TabIndex = 1;
            lblIngresos.Text = "0";
            lblIngresos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label9.Location = new Point(61, 27);
            label9.Name = "label9";
            label9.Size = new Size(153, 27);
            label9.TabIndex = 0;
            label9.Text = "Ingresos al mes";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Inicio";
            Size = new Size(1150, 666);
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFotografos).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel5;
        private Label label11;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel1;
        private Label lblSesiones;
        private Label lblNumSesiones;
        private Label label2;
        private Panel panel2;
        private Label lblClientes;
        private Label label5;
        private Panel panel3;
        private Label lblPedidos;
        private Label label7;
        private Panel panel4;
        private Label label12;
        private Label lblIngresos;
        private Label label9;
        private Panel panel6;
        private Label label13;
        private Panel panel7;
        private Label label1;
        private DataGridView dgvSesiones;
        private DataGridView dgvFotografos;
        private DataGridViewTextBoxColumn nomCliente;
        private DataGridViewTextBoxColumn fechaC;
        private DataGridViewTextBoxColumn tipoCl;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn nomFoto;
        private DataGridViewTextBoxColumn sesiones;
        private DataGridView dgvPedidos;
        private DataGridViewTextBoxColumn nomCli;
        private DataGridViewTextBoxColumn formato;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn entrega;
        private Panel panel8;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}
