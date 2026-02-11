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
            // verificar se o usuário marcou que vai logar como um administrador, caso seja o caso terá um IF
            // logo abaixo que abre a tela de login de administrador ao invés da tela normal.


            bool loginAdmin = rbIsAdmin.Checked;
            LoginAdministrador loginAdministrador = new LoginAdministrador();
            LoginUsuario loginUsuario = new LoginUsuario();

            if (loginAdmin)
            {
                // ir para tela de login administrador.
                // login: Admin
                // senha: 1234
                loginAdministrador.ShowDialog();
            }
            else
            {
                // ir para tela de login usuário.
                loginUsuario.ShowDialog();
            }




        }

        private void lblLoginAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
