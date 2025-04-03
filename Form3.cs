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

        public Form3()
        {
            InitializeComponent();
            criar.Click += Criar_Click;
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
            using (Form4 novaNota = new Form4()) // Criar um novo Form4
            {
                if (novaNota.ShowDialog() == DialogResult.OK) // Espera o Form4 ser fechado
                {
                    if (!string.IsNullOrWhiteSpace(novaNota.ConteudoNota))
                    {
                        AdicionarBotaoNota(novaNota.ConteudoNota); // Adiciona um botão para a anotação
                    }
                }
            }
        }
        private void AdicionarBotaoNota(string conteudo)
        {
            Button botaoNota = new Button();
            botaoNota.Text = "Anotação " + contadorNotas++;
            botaoNota.Width = 150;
            botaoNota.Click += (s, e) => MessageBox.Show(conteudo, "Conteúdo da Anotação");

            lay.Controls.Add(botaoNota);
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
    }
}
