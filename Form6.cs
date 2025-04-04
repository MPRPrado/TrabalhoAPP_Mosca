using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoAPP
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = ("senha.txt");
            StreamWriter writer;
            writer = File.AppendText(senha);
            writer.WriteLine(textBox2.Text);
            writer.Close();
            MessageBox.Show("Cadastrado com sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowSenha_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
            
        }
    }
}
