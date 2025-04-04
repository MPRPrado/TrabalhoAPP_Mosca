using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrabalhoAPP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            ConteudoNota = string.Empty; // Inicializa a propriedade não anulável
        }
        private bool Login(string senha, string arquivo) //receber a informação de login
        {
            foreach (string linha in File.ReadAllLines(arquivo))
            {
                string[] partes = linha.Split(';');
                if (partes[0] == senha)
                {
                    return true; // Login correto
                }
            }
            return false; // Nenhuma correspondência encontrada
        }
        public string ConteudoNota { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = @"C:\Users\mathe\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\Diario.txt";
            if (File.Exists(caminhoArquivo))
            {
                string conteudo = File.ReadAllText(caminhoArquivo);

                string senha = senhaD.Text;
                string arquivo = @"C:\Users\mathe\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\senha.txt";

                bool autenticado = Login(senha, arquivo);
                if (autenticado)
                {
                    Form4 form4 = new Form4();
                    form4.ConteudoNota = conteudo;
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSenha_Click(object sender, EventArgs e)
        {
            senhaD.UseSystemPasswordChar = !senhaD.UseSystemPasswordChar;
            
        }
    }
}
