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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel7 = new Panel();
            label1 = new Label();
            dataGridView3 = new DataGridView();
            nomCli = new DataGridViewTextBoxColumn();
            formato = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            entrega = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel5 = new Panel();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            nomCliente = new DataGridViewTextBoxColumn();
            fechaC = new DataGridViewTextBoxColumn();
            tipoCl = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            panel6 = new Panel();
            label13 = new Label();
            dataGridView2 = new DataGridView();
            nomFoto = new DataGridViewTextBoxColumn();
            sesiones = new DataGridViewTextBoxColumn();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 146F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.90511F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.09489F));
            tableLayoutPanel1.Size = new Size(1150, 666);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(panel7, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridView3, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 403);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1144, 260);
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
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { nomCli, formato, cantidad, entrega });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 43);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(1138, 214);
            dataGridView3.TabIndex = 4;
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
            tableLayoutPanel2.Size = new Size(1144, 248);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(panel5, 0, 0);
            tableLayoutPanel5.Controls.Add(dataGridView1, 0, 1);
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
            tableLayoutPanel5.Size = new Size(566, 242);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomCliente, fechaC, tipoCl, estado });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.FromArgb(227, 230, 245);
            dataGridView1.Location = new Point(3, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(560, 196);
            dataGridView1.TabIndex = 2;
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
            tableLayoutPanel6.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(575, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(566, 242);
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomFoto, sesiones });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.GridColor = Color.FromArgb(227, 230, 245);
            dataGridView2.Location = new Point(3, 43);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(560, 196);
            dataGridView2.TabIndex = 3;
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 134);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(20, 103);
            label4.Name = "label4";
            label4.Size = new Size(240, 23);
            label4.TabIndex = 2;
            label4.Text = "0 confirmadas | 0 pendientes";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(128, 68);
            label3.Name = "label3";
            label3.Size = new Size(31, 38);
            label3.TabIndex = 1;
            label3.Text = "0";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
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
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(289, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 134);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(120, 68);
            label6.Name = "label6";
            label6.Size = new Size(31, 38);
            label6.TabIndex = 1;
            label6.Text = "0";
            label6.TextAlign = ContentAlignment.MiddleCenter;
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
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(575, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 134);
            panel3.TabIndex = 2;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(128, 72);
            label8.Name = "label8";
            label8.Size = new Size(26, 31);
            label8.TabIndex = 1;
            label8.Text = "0";
            label8.TextAlign = ContentAlignment.MiddleCenter;
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
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(861, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 134);
            panel4.TabIndex = 3;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.Font = new Font("Segoe UI", 9F);
            label12.Location = new Point(46, 103);
            label12.Name = "label12";
            label12.Size = new Size(189, 23);
            label12.TabIndex = 4;
            label12.Text = "0 sesiones confirmadas";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(124, 72);
            label10.Name = "label10";
            label10.Size = new Size(26, 31);
            label10.TabIndex = 1;
            label10.Text = "0";
            label10.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Panel panel4;
        private Label label12;
        private Label label10;
        private Label label9;
        private Panel panel6;
        private Label label13;
        private Panel panel7;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nomCliente;
        private DataGridViewTextBoxColumn fechaC;
        private DataGridViewTextBoxColumn tipoCl;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn nomFoto;
        private DataGridViewTextBoxColumn sesiones;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn nomCli;
        private DataGridViewTextBoxColumn formato;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn entrega;
    }
}
