namespace BD_1
{
    partial class UC_Roles
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnEditar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            dgvRoles = new DataGridView();
            rol_id = new DataGridViewTextBoxColumn();
            rol_nombre = new DataGridViewTextBoxColumn();
            rol_creado = new DataGridViewTextBoxColumn();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            panel2 = new Panel();
            dgvPermisos = new DataGridView();
            rol = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewCheckBoxColumn();
            registrar_Clientes = new DataGridViewCheckBoxColumn();
            editar_Clientes = new DataGridViewCheckBoxColumn();
            eliminar_Clientes = new DataGridViewCheckBoxColumn();
            ver_Fotografos = new DataGridViewCheckBoxColumn();
            registrar_Fotografos = new DataGridViewCheckBoxColumn();
            editar_Fotografos = new DataGridViewCheckBoxColumn();
            eliminar_Fotografos = new DataGridViewCheckBoxColumn();
            ver_sesiones_fotos = new DataGridViewCheckBoxColumn();
            registrar_sesiones = new DataGridViewCheckBoxColumn();
            editar_sesiones = new DataGridViewCheckBoxColumn();
            cancelar_sesiones = new DataGridViewCheckBoxColumn();
            ver_pedidos = new DataGridViewCheckBoxColumn();
            registrar_pedidos = new DataGridViewCheckBoxColumn();
            editar_pedidos = new DataGridViewCheckBoxColumn();
            eliminar_pedidos = new DataGridViewCheckBoxColumn();
            ver_roles = new DataGridViewCheckBoxColumn();
            crear_roles = new DataGridViewCheckBoxColumn();
            editar_roles = new DataGridViewCheckBoxColumn();
            eliminar_roles = new DataGridViewCheckBoxColumn();
            ver_permisos = new DataGridViewCheckBoxColumn();
            asignar_permisos = new DataGridViewCheckBoxColumn();
            ver_sesiones_sistema = new DataGridViewCheckBoxColumn();
            cerrar_sesiones = new DataGridViewCheckBoxColumn();
            exportar_reportes = new DataGridViewCheckBoxColumn();
            importar_datos = new DataGridViewCheckBoxColumn();
            admin_total = new DataGridViewCheckBoxColumn();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnGuardar = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new Size(1202, 61);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(565, 15);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 12;
            label1.Text = "Roles";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 61);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.39909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56.60091F));
            tableLayoutPanel2.Size = new Size(1202, 659);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(dgvRoles);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1196, 280);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 398F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 317F));
            tableLayoutPanel4.Controls.Add(btnEditar, 2, 0);
            tableLayoutPanel4.Controls.Add(btnAgregar, 1, 0);
            tableLayoutPanel4.Controls.Add(txtNombre, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(0, 239);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1196, 41);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Silver;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(882, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(110, 35);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "📝 Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(50, 13, 162);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(484, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(185, 35);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "➕ Nuevo rol";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Right;
            txtNombre.Font = new Font("Segoe UI", 9.5F);
            txtNombre.Location = new Point(220, 6);
            txtNombre.Margin = new Padding(120, 3, 20, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre del rol";
            txtNombre.Size = new Size(241, 29);
            txtNombre.TabIndex = 11;
            txtNombre.Tag = "";
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Columns.AddRange(new DataGridViewColumn[] { rol_id, rol_nombre, rol_creado });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle6;
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.GridColor = Color.FromArgb(227, 230, 245);
            dgvRoles.Location = new Point(0, 56);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(1196, 224);
            dgvRoles.TabIndex = 24;
            // 
            // rol_id
            // 
            rol_id.FillWeight = 68.4491959F;
            rol_id.HeaderText = "ID";
            rol_id.MinimumWidth = 6;
            rol_id.Name = "rol_id";
            rol_id.ReadOnly = true;
            // 
            // rol_nombre
            // 
            rol_nombre.FillWeight = 112.506271F;
            rol_nombre.HeaderText = "Nombre";
            rol_nombre.MinimumWidth = 6;
            rol_nombre.Name = "rol_nombre";
            rol_nombre.ReadOnly = true;
            // 
            // rol_creado
            // 
            rol_creado.FillWeight = 117.320549F;
            rol_creado.HeaderText = "Fecha de creación";
            rol_creado.MinimumWidth = 6;
            rol_creado.Name = "rol_creado";
            rol_creado.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 274F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 323F));
            tableLayoutPanel3.Controls.Add(txtBuscar, 0, 0);
            tableLayoutPanel3.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel3.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1196, 56);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 9.5F);
            txtBuscar.Location = new Point(30, 13);
            txtBuscar.Margin = new Padding(30, 3, 20, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(549, 29);
            txtBuscar.TabIndex = 10;
            txtBuscar.Tag = "";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(50, 13, 162);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(602, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(124, 38);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "🔍 Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Tomato;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(876, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(118, 39);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "🗑️ Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvPermisos);
            panel2.Controls.Add(tableLayoutPanel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 289);
            panel2.Name = "panel2";
            panel2.Size = new Size(1196, 367);
            panel2.TabIndex = 1;
            // 
            // dgvPermisos
            // 
            dgvPermisos.AllowUserToAddRows = false;
            dgvPermisos.AllowUserToDeleteRows = false;
            dgvPermisos.BackgroundColor = Color.White;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPermisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Columns.AddRange(new DataGridViewColumn[] { rol, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, registrar_Clientes, editar_Clientes, eliminar_Clientes, ver_Fotografos, registrar_Fotografos, editar_Fotografos, eliminar_Fotografos, ver_sesiones_fotos, registrar_sesiones, editar_sesiones, cancelar_sesiones, ver_pedidos, registrar_pedidos, editar_pedidos, eliminar_pedidos, ver_roles, crear_roles, editar_roles, eliminar_roles, ver_permisos, asignar_permisos, ver_sesiones_sistema, cerrar_sesiones, exportar_reportes, importar_datos, admin_total });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPermisos.DefaultCellStyle = dataGridViewCellStyle8;
            dgvPermisos.Dock = DockStyle.Fill;
            dgvPermisos.GridColor = Color.FromArgb(227, 230, 245);
            dgvPermisos.Location = new Point(0, 0);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.ReadOnly = true;
            dgvPermisos.RowHeadersVisible = false;
            dgvPermisos.RowHeadersWidth = 51;
            dgvPermisos.Size = new Size(1196, 293);
            dgvPermisos.TabIndex = 25;
            // 
            // rol
            // 
            rol.FillWeight = 68.4491959F;
            rol.Frozen = true;
            rol.HeaderText = "Rol";
            rol.MinimumWidth = 6;
            rol.Name = "rol";
            rol.ReadOnly = true;
            rol.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 112.506271F;
            dataGridViewTextBoxColumn2.HeaderText = "Login";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 114.16674F;
            dataGridViewTextBoxColumn3.HeaderText = "Ver Perfil";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 117.320549F;
            dataGridViewTextBoxColumn4.HeaderText = "Cambiar Password";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn4.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 88.42706F;
            dataGridViewTextBoxColumn5.HeaderText = "Ver Clientes";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn5.Width = 110;
            // 
            // registrar_Clientes
            // 
            registrar_Clientes.HeaderText = "Registrar Clientes";
            registrar_Clientes.MinimumWidth = 6;
            registrar_Clientes.Name = "registrar_Clientes";
            registrar_Clientes.ReadOnly = true;
            registrar_Clientes.Resizable = DataGridViewTriState.True;
            registrar_Clientes.SortMode = DataGridViewColumnSortMode.Automatic;
            registrar_Clientes.Width = 130;
            // 
            // editar_Clientes
            // 
            editar_Clientes.HeaderText = "Editar Clientes";
            editar_Clientes.MinimumWidth = 6;
            editar_Clientes.Name = "editar_Clientes";
            editar_Clientes.ReadOnly = true;
            editar_Clientes.Resizable = DataGridViewTriState.True;
            editar_Clientes.SortMode = DataGridViewColumnSortMode.Automatic;
            editar_Clientes.Width = 110;
            // 
            // eliminar_Clientes
            // 
            eliminar_Clientes.HeaderText = "Eliminar Clientes";
            eliminar_Clientes.MinimumWidth = 6;
            eliminar_Clientes.Name = "eliminar_Clientes";
            eliminar_Clientes.ReadOnly = true;
            eliminar_Clientes.Resizable = DataGridViewTriState.True;
            eliminar_Clientes.SortMode = DataGridViewColumnSortMode.Automatic;
            eliminar_Clientes.Width = 125;
            // 
            // ver_Fotografos
            // 
            ver_Fotografos.HeaderText = "Ver Fotografos";
            ver_Fotografos.MinimumWidth = 6;
            ver_Fotografos.Name = "ver_Fotografos";
            ver_Fotografos.ReadOnly = true;
            ver_Fotografos.Width = 125;
            // 
            // registrar_Fotografos
            // 
            registrar_Fotografos.HeaderText = "Registrar Fotógrafos";
            registrar_Fotografos.MinimumWidth = 6;
            registrar_Fotografos.Name = "registrar_Fotografos";
            registrar_Fotografos.ReadOnly = true;
            registrar_Fotografos.Width = 125;
            // 
            // editar_Fotografos
            // 
            editar_Fotografos.HeaderText = "Editar Fotógrafos";
            editar_Fotografos.MinimumWidth = 6;
            editar_Fotografos.Name = "editar_Fotografos";
            editar_Fotografos.ReadOnly = true;
            editar_Fotografos.Width = 125;
            // 
            // eliminar_Fotografos
            // 
            eliminar_Fotografos.HeaderText = "Eliminar Fotógrafos";
            eliminar_Fotografos.MinimumWidth = 6;
            eliminar_Fotografos.Name = "eliminar_Fotografos";
            eliminar_Fotografos.ReadOnly = true;
            eliminar_Fotografos.Width = 125;
            // 
            // ver_sesiones_fotos
            // 
            ver_sesiones_fotos.HeaderText = "Ver Sesiones Fotos";
            ver_sesiones_fotos.MinimumWidth = 6;
            ver_sesiones_fotos.Name = "ver_sesiones_fotos";
            ver_sesiones_fotos.ReadOnly = true;
            ver_sesiones_fotos.Width = 125;
            // 
            // registrar_sesiones
            // 
            registrar_sesiones.HeaderText = "Registrar Sesiones";
            registrar_sesiones.MinimumWidth = 6;
            registrar_sesiones.Name = "registrar_sesiones";
            registrar_sesiones.ReadOnly = true;
            registrar_sesiones.Width = 125;
            // 
            // editar_sesiones
            // 
            editar_sesiones.HeaderText = "Editar Sesiones";
            editar_sesiones.MinimumWidth = 6;
            editar_sesiones.Name = "editar_sesiones";
            editar_sesiones.ReadOnly = true;
            editar_sesiones.Width = 125;
            // 
            // cancelar_sesiones
            // 
            cancelar_sesiones.HeaderText = "Cancelar Sesiones";
            cancelar_sesiones.MinimumWidth = 6;
            cancelar_sesiones.Name = "cancelar_sesiones";
            cancelar_sesiones.ReadOnly = true;
            cancelar_sesiones.Width = 125;
            // 
            // ver_pedidos
            // 
            ver_pedidos.HeaderText = "Ver Pedidos";
            ver_pedidos.MinimumWidth = 6;
            ver_pedidos.Name = "ver_pedidos";
            ver_pedidos.ReadOnly = true;
            ver_pedidos.Width = 125;
            // 
            // registrar_pedidos
            // 
            registrar_pedidos.HeaderText = "Registrar Pedidos";
            registrar_pedidos.MinimumWidth = 6;
            registrar_pedidos.Name = "registrar_pedidos";
            registrar_pedidos.ReadOnly = true;
            registrar_pedidos.Width = 125;
            // 
            // editar_pedidos
            // 
            editar_pedidos.HeaderText = "Editar Pedidos";
            editar_pedidos.MinimumWidth = 6;
            editar_pedidos.Name = "editar_pedidos";
            editar_pedidos.ReadOnly = true;
            editar_pedidos.Width = 125;
            // 
            // eliminar_pedidos
            // 
            eliminar_pedidos.HeaderText = "Eliminar Pedidos";
            eliminar_pedidos.MinimumWidth = 6;
            eliminar_pedidos.Name = "eliminar_pedidos";
            eliminar_pedidos.ReadOnly = true;
            eliminar_pedidos.Width = 125;
            // 
            // ver_roles
            // 
            ver_roles.HeaderText = "Ver Roles";
            ver_roles.MinimumWidth = 6;
            ver_roles.Name = "ver_roles";
            ver_roles.ReadOnly = true;
            ver_roles.Width = 125;
            // 
            // crear_roles
            // 
            crear_roles.HeaderText = "Crear Roles";
            crear_roles.MinimumWidth = 6;
            crear_roles.Name = "crear_roles";
            crear_roles.ReadOnly = true;
            crear_roles.Width = 125;
            // 
            // editar_roles
            // 
            editar_roles.HeaderText = "Editar Roles";
            editar_roles.MinimumWidth = 6;
            editar_roles.Name = "editar_roles";
            editar_roles.ReadOnly = true;
            editar_roles.Width = 125;
            // 
            // eliminar_roles
            // 
            eliminar_roles.HeaderText = "Eliminar Roles";
            eliminar_roles.MinimumWidth = 6;
            eliminar_roles.Name = "eliminar_roles";
            eliminar_roles.ReadOnly = true;
            eliminar_roles.Width = 125;
            // 
            // ver_permisos
            // 
            ver_permisos.HeaderText = "Ver Permisos";
            ver_permisos.MinimumWidth = 6;
            ver_permisos.Name = "ver_permisos";
            ver_permisos.ReadOnly = true;
            ver_permisos.Width = 125;
            // 
            // asignar_permisos
            // 
            asignar_permisos.HeaderText = "Asignar Permisos";
            asignar_permisos.MinimumWidth = 6;
            asignar_permisos.Name = "asignar_permisos";
            asignar_permisos.ReadOnly = true;
            asignar_permisos.Width = 125;
            // 
            // ver_sesiones_sistema
            // 
            ver_sesiones_sistema.HeaderText = "Ver Sesiones Sistema";
            ver_sesiones_sistema.MinimumWidth = 6;
            ver_sesiones_sistema.Name = "ver_sesiones_sistema";
            ver_sesiones_sistema.ReadOnly = true;
            ver_sesiones_sistema.Width = 125;
            // 
            // cerrar_sesiones
            // 
            cerrar_sesiones.HeaderText = "Cerrar Sesiones";
            cerrar_sesiones.MinimumWidth = 6;
            cerrar_sesiones.Name = "cerrar_sesiones";
            cerrar_sesiones.ReadOnly = true;
            cerrar_sesiones.Width = 125;
            // 
            // exportar_reportes
            // 
            exportar_reportes.HeaderText = "Exportar Reportes";
            exportar_reportes.MinimumWidth = 6;
            exportar_reportes.Name = "exportar_reportes";
            exportar_reportes.ReadOnly = true;
            exportar_reportes.Width = 125;
            // 
            // importar_datos
            // 
            importar_datos.HeaderText = "Importar Datos";
            importar_datos.MinimumWidth = 6;
            importar_datos.Name = "importar_datos";
            importar_datos.ReadOnly = true;
            importar_datos.Width = 125;
            // 
            // admin_total
            // 
            admin_total.HeaderText = "Admin Total";
            admin_total.MinimumWidth = 6;
            admin_total.Name = "admin_total";
            admin_total.ReadOnly = true;
            admin_total.Width = 125;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnGuardar, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Bottom;
            tableLayoutPanel5.Location = new Point(0, 293);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1196, 74);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(50, 13, 162);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1034, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(159, 48);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // UC_Roles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Roles";
            Size = new Size(1202, 720);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dgvRoles;
        private DataGridView dgvPermisos;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn registrar_Clientes;
        private DataGridViewCheckBoxColumn editar_Clientes;
        private DataGridViewCheckBoxColumn eliminar_Clientes;
        private DataGridViewCheckBoxColumn ver_Fotografos;
        private DataGridViewCheckBoxColumn registrar_Fotografos;
        private DataGridViewCheckBoxColumn editar_Fotografos;
        private DataGridViewCheckBoxColumn eliminar_Fotografos;
        private DataGridViewCheckBoxColumn ver_sesiones_fotos;
        private DataGridViewCheckBoxColumn registrar_sesiones;
        private DataGridViewCheckBoxColumn editar_sesiones;
        private DataGridViewCheckBoxColumn cancelar_sesiones;
        private DataGridViewCheckBoxColumn ver_pedidos;
        private DataGridViewCheckBoxColumn registrar_pedidos;
        private DataGridViewCheckBoxColumn editar_pedidos;
        private DataGridViewCheckBoxColumn eliminar_pedidos;
        private DataGridViewCheckBoxColumn ver_roles;
        private DataGridViewCheckBoxColumn crear_roles;
        private DataGridViewCheckBoxColumn editar_roles;
        private DataGridViewCheckBoxColumn eliminar_roles;
        private DataGridViewCheckBoxColumn ver_permisos;
        private DataGridViewCheckBoxColumn asignar_permisos;
        private DataGridViewCheckBoxColumn ver_sesiones_sistema;
        private DataGridViewCheckBoxColumn cerrar_sesiones;
        private DataGridViewCheckBoxColumn exportar_reportes;
        private DataGridViewCheckBoxColumn importar_datos;
        private DataGridViewCheckBoxColumn admin_total;
        private DataGridViewTextBoxColumn rol_id;
        private DataGridViewTextBoxColumn rol_nombre;
        private DataGridViewTextBoxColumn rol_creado;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtNombre;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}
