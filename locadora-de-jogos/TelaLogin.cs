namespace locadora_de_jogos
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            bool isAdmin = rbIsAdmin.Checked;
            LoginAdministrador loginAdministrador = new LoginAdministrador();

            if (isAdmin)
            {
                // ir para tela de login administrador
                this.Hide();
                loginAdministrador.ShowDialog();
                this.Show();
            } else
            {
                // ir para tela de login usuário.
                MessageBox.Show("Conectar como Usuário normal.");
            }




        }
    }
}
