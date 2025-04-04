using System.IO;
namespace TrabalhoAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
            if (usuariotext.TextLength == 0 || senhatxt.TextLength == 0)
            {
                btLogin.Enabled = false;
            }
            else
            {
                btLogin.Enabled = true;
            }
        }

        private void ShowSenha_Click(object sender, EventArgs e)
        {
            senhatxt.UseSystemPasswordChar = !senhatxt.UseSystemPasswordChar;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string senha = senhatxt.Text;
            string usuario = usuariotext.Text;
            string arquivo = "./arquivo.txt";
            bool autenticado = Login(usuario, senha, arquivo);
            if (autenticado)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void senhatxt_TextChanged(object sender, EventArgs e)
        {

            if (usuariotext.TextLength == 0 || senhatxt.TextLength == 0)
            {
                btLogin.Enabled = false;
            }
            else
            {
                btLogin.Enabled = true;
            }
        }
    }
}
