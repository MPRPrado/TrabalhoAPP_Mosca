namespace TrabalhoAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btlogin.Enabled = false;
            senhatxt.PasswordChar = '*';
        }
        private bool Login(string usuario, string senha, string arquivo) //receber a informação de login
        {
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(';');
                if (partes[0] == usuario && partes[1] == senha)
                {
                    return true; // Login correto
                }
            }
            return false; // Nenhuma correspondência encontrada
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowSenha_Click(object sender, EventArgs e)
        {
            if (true)
            {
                senhatxt.PasswordChar = '\0'; //deixa a senha visivel
            }
            else
            {
                senhatxt.PasswordChar = '*';
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
