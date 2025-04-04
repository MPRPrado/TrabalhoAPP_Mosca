using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;

namespace TrabalhoAPP
{
    public partial class Form3 : Form
    {
        private int contadorNotas = 1;

        private bool papai1(string caminhoArquivo) //receber a informação de login  
        {
            return File.Exists(caminhoArquivo);
        }



        public Form3()
        {
            InitializeComponent();
            //criar.Click += Criar_Click;
            papai.Visible = false; // Inicialmente invisível
            string caminhoArquivo = @"C:\Users\mathe\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\Diario.txt";
            if (papai1(caminhoArquivo))
            {
                papai.Visible = true; // Torna o botão visível

            }
            else
            {
                papai.Visible = false; // Torna o botão invisível
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void criar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNota_Click(object sender, EventArgs e)
        {

        }

        private void Criar_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void papai_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void papai_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string caminhoArquivo = @"C:\Users\mathe\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\Diario.txt";
            string senha = @"C:\Users\mathe\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\senha.txt";
            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
                File.Delete(senha);
                MessageBox.Show("Diario foi apagado com sucesso.");
                papai.Visible = false; // Torna o botão invisível   

            }
            else
            {
                MessageBox.Show("Diario não encontrado.");
            }
        }
    }
}
