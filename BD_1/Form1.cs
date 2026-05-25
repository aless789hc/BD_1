namespace BD_1
{
    public partial class Login : Form
    {
        private bool mostrandoPwd = false;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrandoPwd = !mostrandoPwd;
            txtPassword.PasswordChar = mostrandoPwd ? '\0' : '*';

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // aqui solo pasa esto si el login es correcto y si el usuario si esta registrado en la BD
            DashBoard nuevo = new DashBoard();
            nuevo.Show();
            this.Hide();
        }
    }
}
