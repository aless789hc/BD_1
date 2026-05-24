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
            DashBoard nuevo = new DashBoard();
            nuevo.Show();
        }
    }
}
