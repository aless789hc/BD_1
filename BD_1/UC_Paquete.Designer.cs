namespace BD_1
{
    partial class UC_Paquete
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvPaquetes = new DataGridView();
            paq_id = new DataGridViewTextBoxColumn();
            paq_nombre = new DataGridViewTextBoxColumn();
            paq_precio_base = new DataGridViewTextBoxColumn();
            paq_num_fotos = new DataGridViewTextBoxColumn();
            paq_fecha_contrato = new DataGridViewTextBoxColumn();
            paq_descuento = new DataGridViewTextBoxColumn();
            tlpFormulario = new TableLayoutPanel();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nmdDescuento = new NumericUpDown();
            label9 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            nmdFotos = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).BeginInit();
            tlpFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdDescuento).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmdFotos).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPaquetes
            // 
            dgvPaquetes.AllowUserToAddRows = false;
            dgvPaquetes.AllowUserToDeleteRows = false;
            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPaquetes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPaquetes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPaquetes.Columns.AddRange(new DataGridViewColumn[] { paq_id, paq_nombre, paq_precio_base, paq_num_fotos, paq_fecha_contrato, paq_descuento });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvPaquetes.DefaultCellStyle = dataGridViewCellStyle4;
            dgvPaquetes.Dock = DockStyle.Fill;
            dgvPaquetes.GridColor = Color.FromArgb(227, 230, 245);
            dgvPaquetes.Location = new Point(0, 116);
            dgvPaquetes.Name = "dgvPaquetes";
            dgvPaquetes.ReadOnly = true;
            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.RowHeadersWidth = 51;
            dgvPaquetes.Size = new Size(930, 152);
            dgvPaquetes.TabIndex = 23;
            // 
            // paq_id
            // 
            paq_id.HeaderText = "ID";
            paq_id.MinimumWidth = 6;
            paq_id.Name = "paq_id";
            paq_id.ReadOnly = true;
            // 
            // paq_nombre
            // 
            paq_nombre.HeaderText = "Nombre";
            paq_nombre.MinimumWidth = 6;
            paq_nombre.Name = "paq_nombre";
            paq_nombre.ReadOnly = true;
            // 
            // paq_precio_base
            // 
            paq_precio_base.HeaderText = "Precio base";
            paq_precio_base.MinimumWidth = 6;
            paq_precio_base.Name = "paq_precio_base";
            paq_precio_base.ReadOnly = true;
            // 
            // paq_num_fotos
            // 
            paq_num_fotos.HeaderText = "Numero de fotos";
            paq_num_fotos.MinimumWidth = 6;
            paq_num_fotos.Name = "paq_num_fotos";
            paq_num_fotos.ReadOnly = true;
            // 
            // paq_fecha_contrato
            // 
            paq_fecha_contrato.HeaderText = "Fecha de Contrato";
            paq_fecha_contrato.MinimumWidth = 6;
            paq_fecha_contrato.Name = "paq_fecha_contrato";
            paq_fecha_contrato.ReadOnly = true;
            // 
            // paq_descuento
            // 
            paq_descuento.HeaderText = "Descuento";
            paq_descuento.MinimumWidth = 6;
            paq_descuento.Name = "paq_descuento";
            paq_descuento.ReadOnly = true;
            // 
            // tlpFormulario
            // 
            tlpFormulario.BackColor = Color.FromArgb(227, 230, 245);
            tlpFormulario.ColumnCount = 2;
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpFormulario.Controls.Add(label2, 0, 0);
            tlpFormulario.Controls.Add(dtpFecha, 0, 6);
            tlpFormulario.Controls.Add(label3, 0, 1);
            tlpFormulario.Controls.Add(label4, 1, 1);
            tlpFormulario.Controls.Add(label5, 0, 3);
            tlpFormulario.Controls.Add(nmdDescuento, 0, 4);
            tlpFormulario.Controls.Add(label9, 1, 3);
            tlpFormulario.Controls.Add(label7, 0, 5);
            tlpFormulario.Controls.Add(panel1, 1, 6);
            tlpFormulario.Controls.Add(txtNombre, 0, 2);
            tlpFormulario.Controls.Add(txtPrecio, 1, 2);
            tlpFormulario.Controls.Add(nmdFotos, 1, 4);
            tlpFormulario.Dock = DockStyle.Bottom;
            tlpFormulario.Location = new Point(0, 268);
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
            tlpFormulario.Size = new Size(930, 313);
            tlpFormulario.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(230, 25);
            label2.TabIndex = 1;
            label2.Text = "🗓️ Datos de los paquetes";
            // 
            // dtpFecha
            // 
            dtpFecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpFecha.CalendarTitleBackColor = Color.CornflowerBlue;
            dtpFecha.Font = new Font("Segoe UI", 9.5F);
            dtpFecha.Location = new Point(23, 242);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(439, 29);
            dtpFecha.TabIndex = 39;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(158, 56);
            label3.Name = "label3";
            label3.Size = new Size(169, 23);
            label3.TabIndex = 29;
            label3.Text = "Nombre del paquete";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(639, 56);
            label4.Name = "label4";
            label4.Size = new Size(97, 23);
            label4.TabIndex = 30;
            label4.Text = "Precio base";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(197, 132);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 31;
            label5.Text = "Descuento";
            // 
            // nmdDescuento
            // 
            nmdDescuento.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nmdDescuento.Font = new Font("Segoe UI", 9.5F);
            nmdDescuento.Location = new Point(23, 163);
            nmdDescuento.Name = "nmdDescuento";
            nmdDescuento.Size = new Size(439, 29);
            nmdDescuento.TabIndex = 40;
            nmdDescuento.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(617, 132);
            label9.Name = "label9";
            label9.Size = new Size(140, 23);
            label9.TabIndex = 35;
            label9.Text = "Numero de fotos";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(215, 198);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 33;
            label7.Text = "Fecha";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Location = new Point(468, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 47);
            panel1.TabIndex = 42;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(70, 92);
            txtNombre.Margin = new Padding(50, 3, 50, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 29);
            txtNombre.TabIndex = 43;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Font = new Font("Segoe UI", 9.5F);
            txtPrecio.Location = new Point(515, 92);
            txtPrecio.Margin = new Padding(50, 3, 50, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(345, 29);
            txtPrecio.TabIndex = 44;
            // 
            // nmdFotos
            // 
            nmdFotos.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nmdFotos.Font = new Font("Segoe UI", 9.5F);
            nmdFotos.Location = new Point(468, 163);
            nmdFotos.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nmdFotos.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmdFotos.Name = "nmdFotos";
            nmdFotos.Size = new Size(439, 29);
            nmdFotos.TabIndex = 45;
            nmdFotos.TextAlign = HorizontalAlignment.Center;
            nmdFotos.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 191F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 118F));
            tableLayoutPanel2.Controls.Add(txtBuscar, 0, 0);
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
            tableLayoutPanel2.TabIndex = 21;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(35, 15);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(423, 29);
            txtBuscar.TabIndex = 2;
            txtBuscar.Tag = "";
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
            btnAgregar.Text = "➕ Nuevo Paquete";
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
            tableLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(410, 13);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 11;
            label1.Text = "Paquetes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UC_Paquete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvPaquetes);
            Controls.Add(tlpFormulario);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Paquete";
            Size = new Size(930, 581);
            ((System.ComponentModel.ISupportInitialize)dgvPaquetes).EndInit();
            tlpFormulario.ResumeLayout(false);
            tlpFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmdDescuento).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmdFotos).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPaquetes;
        private TableLayoutPanel tlpFormulario;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label5;
        private NumericUpDown nmdDescuento;
        private Label label7;
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
        private DataGridViewTextBoxColumn paq_id;
        private DataGridViewTextBoxColumn paq_nombre;
        private DataGridViewTextBoxColumn paq_precio_base;
        private DataGridViewTextBoxColumn paq_num_fotos;
        private DataGridViewTextBoxColumn paq_fecha_contrato;
        private DataGridViewTextBoxColumn paq_descuento;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private NumericUpDown nmdFotos;
    }
}
