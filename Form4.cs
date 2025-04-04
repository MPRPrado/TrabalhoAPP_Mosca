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
    public partial class Form4 : Form
    {
        public string ConteudoNota { get; set; }
        //public string ConteudoNota { get; private set; }
        public Form4()
        {
            InitializeComponent();
            ConteudoNota = string.Empty; // Inicializa a propriedade com um valor não nulo
            //ok.Click += Ok_Click;
        }/*Clicar salvar vai criar o arquivo de texto e se ja existir uma senha para esse arquivo ele só salva*/
        private bool Login(string arquivo) //receber a informação de login  
        {
            string senha = @"C:\Users\alunos\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\senha.txt";
            return File.Exists(senha);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            texto.Text = ConteudoNota; // Define o conteúdo da TextBox

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            ConteudoNota = texto.Text;
            if (!string.IsNullOrWhiteSpace(ConteudoNota))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Digite algo antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            string arquivo = "Diario.txt";
           // string senhanova = senha.Text; // Supondo que você tenha um TextBox para a senha
            string textoConteudo = texto.Text;
            string senha = @"C:\Users\alunos\source\repos\TrabalhoAPP_Mosca\bin\Debug\net8.0-windows\senha";
            
                // Verifica se a senha está correta
                if (Login(senha))
                {
                SalvarConteudo(arquivo, textoConteudo);
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
                MessageBox.Show("Conteúdo salvo com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Salva o conteúdo no arquivo
                    
            }
            else
            {
                SalvarConteudo(arquivo, textoConteudo);
                MessageBox.Show("Conteúdo salvo com sucesso.", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();

            }
        }



        private void SalvarConteudo(string arquivo, string conteudo)
        {
            using (StreamWriter writer = new StreamWriter(arquivo, false)) // 'false' para sobrescrever o conteúdo
            {
                writer.WriteLine(conteudo);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
