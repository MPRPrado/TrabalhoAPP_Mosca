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
        public string ConteudoNota { get; private set; }
        public Form4()
        {
            InitializeComponent();
            ok.Click += Ok_Click;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
