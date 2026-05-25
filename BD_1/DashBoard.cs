namespace BD_1
{
    public partial class DashBoard : Form
    {
        // Hazaaam dependiendo del rol, en cada UC tendras que ocultar ya sea paneles, componentes
        // y si es tableLayout y quieres ocultar solo una fila
        // primero ocultas los componentes que no podra ver y luego contraes la fila del tableLayout que quieres ocultar
        private bool sidebarExpanded = true;
        public DashBoard()
        {
            InitializeComponent();
        }
        private void CargarVista(UserControl vista)
        {
            panel_Contenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            panel_Contenido.Controls.Add(vista);
            vista.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void DashBoard_Load(object sender, EventArgs e)
        {
            /* animTimer.Interval = 10;
             animTimer.Tick += animTimer_Tick;*/
            CargarVista(new UC_Inicio());
        }


        /*private void button6_Click(object sender, EventArgs e)
        {
            sidebarExpanded = !sidebarExpanded;
            animTimer.Start();
        }*/

        /*private void animTimer_Tick(object sender, EventArgs e)
        {
            int target = sidebarExpanded ? 220 : 52;
            int step = 8;

            panel_Contenido.SuspendLayout();

            if (panel_sideBar.Width < target)
                panel_sideBar.Width = Math.Min(panel_sideBar.Width + step, target);
            else if (panel_sideBar.Width > target)
                panel_sideBar.Width = Math.Max(panel_sideBar.Width - step, target);
            else
            {
                animTimer.Stop();
                panel_Contenido.ResumeLayout();
                return;
            }

            panel_Contenido.ResumeLayout(false);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        */


        private void btnSesion_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Sesiones());
        }

        private void btnFotografo_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Fotografo());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Inicio());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Cliente());
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Pedidos());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            CargarVista(new UC_Perfil());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarVista(new UC_Roles());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
