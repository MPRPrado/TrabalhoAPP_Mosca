
namespace TrabalhoAPP

{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Certifique-se de que os controles estão habilitados
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsuarioCadastro_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuariotext_TextChanged(object sender, EventArgs e)
        {
            if (usuariotext.TextLength == 0 || senhatext.TextLength == 0 || email.TextLength == 0)
            {
                criarbot.Enabled = false;

            }
            else
            {
                criarbot.Enabled = true;
            }
        }

        private void senhatext_TextChanged(object sender, EventArgs e)
        {

            if (usuariotext.TextLength == 0 || senhatext.TextLength == 0 || email.TextLength == 0)
            {
                criarbot.Enabled = false;

            }
            else
            {
                criarbot.Enabled = true;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

            if (usuariotext.TextLength == 0 || senhatext.TextLength == 0 || email.TextLength == 0)
            {
                criarbot.Enabled = false;

            }
            else
            {
                criarbot.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            senhatext.UseSystemPasswordChar = !senhatext.UseSystemPasswordChar;
        }

        private void criarbot_Click(object sender, EventArgs e)
        {
            string arquivo = ("arquivo.txt");
            StreamWriter writer;
            writer = File.AppendText(arquivo);
            writer.WriteLine(usuariotext.Text + ";" +senhatext.Text);
            writer.Close();
            MessageBox.Show("Cadastrado com sucesso","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();
        }
    }
}