namespace TrabalhoAPP
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            linkLabel1 = new LinkLabel();
            lblUsuarioCadastro = new Label();
            label3 = new Label();
            label4 = new Label();
            usuariotext = new TextBox();
            email = new TextBox();
            senhatext = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            Showsenha = new Button();
            criarbot = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LavenderBlush;
            pictureBox1.Location = new Point(226, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 481);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LavenderBlush;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(418, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Leelawadee UI", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(332, 111);
            label1.Name = "label1";
            label1.Size = new Size(262, 47);
            label1.TabIndex = 2;
            label1.Text = "Crie sua conta ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(276, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 36);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(276, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 36);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Enabled = false;
            textBox3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(276, 352);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 36);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(119, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Voltar à página inicial";
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblUsuarioCadastro
            // 
            lblUsuarioCadastro.AutoSize = true;
            lblUsuarioCadastro.BackColor = Color.LavenderBlush;
            lblUsuarioCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuarioCadastro.ForeColor = Color.HotPink;
            lblUsuarioCadastro.Location = new Point(276, 161);
            lblUsuarioCadastro.Name = "lblUsuarioCadastro";
            lblUsuarioCadastro.Size = new Size(73, 21);
            lblUsuarioCadastro.TabIndex = 8;
            lblUsuarioCadastro.Text = "Usuário:";
            lblUsuarioCadastro.Click += lblUsuarioCadastro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LavenderBlush;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(276, 244);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 9;
            label3.Text = "E-mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.HotPink;
            label4.Location = new Point(276, 328);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 10;
            label4.Text = "Senha:";
            // 
            // usuariotext
            // 
            usuariotext.BackColor = Color.White;
            usuariotext.BorderStyle = BorderStyle.None;
            usuariotext.Font = new Font("Segoe UI", 9.75F);
            usuariotext.Location = new Point(322, 194);
            usuariotext.Name = "usuariotext";
            usuariotext.Size = new Size(306, 18);
            usuariotext.TabIndex = 25;
            usuariotext.TextChanged += usuariotext_TextChanged;
            // 
            // email
            // 
            email.BackColor = Color.White;
            email.BorderStyle = BorderStyle.None;
            email.Font = new Font("Segoe UI", 9.75F);
            email.Location = new Point(322, 277);
            email.Name = "email";
            email.Size = new Size(316, 18);
            email.TabIndex = 26;
            email.TextChanged += email_TextChanged;
            // 
            // senhatext
            // 
            senhatext.BackColor = Color.White;
            senhatext.BorderStyle = BorderStyle.None;
            senhatext.Font = new Font("Segoe UI", 9.75F);
            senhatext.Location = new Point(322, 361);
            senhatext.Name = "senhatext";
            senhatext.Size = new Size(316, 18);
            senhatext.TabIndex = 27;
            senhatext.TextChanged += senhatext_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(283, 187);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(283, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(283, 269);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // Showsenha
            // 
            Showsenha.BackColor = Color.LavenderBlush;
            Showsenha.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            Showsenha.FlatAppearance.BorderSize = 0;
            Showsenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            Showsenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            Showsenha.FlatStyle = FlatStyle.Flat;
            Showsenha.ForeColor = SystemColors.ControlText;
            Showsenha.Image = (Image)resources.GetObject("Showsenha.Image");
            Showsenha.Location = new Point(656, 356);
            Showsenha.Name = "Showsenha";
            Showsenha.Size = new Size(32, 32);
            Showsenha.TabIndex = 7;
            Showsenha.UseVisualStyleBackColor = true;
            Showsenha.Click += button1_Click_1;
            // 
            // criarbot
            // 
            criarbot.BackColor = Color.HotPink;
            criarbot.Cursor = Cursors.AppStarting;
            criarbot.Enabled = false;
            criarbot.FlatAppearance.BorderColor = Color.HotPink;
            criarbot.FlatAppearance.BorderSize = 0;
            criarbot.FlatAppearance.MouseDownBackColor = Color.HotPink;
            criarbot.FlatAppearance.MouseOverBackColor = Color.HotPink;
            criarbot.FlatStyle = FlatStyle.Popup;
            criarbot.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            criarbot.ForeColor = Color.White;
            criarbot.Location = new Point(338, 421);
            criarbot.Name = "criarbot";
            criarbot.Size = new Size(256, 50);
            criarbot.TabIndex = 33;
            criarbot.Text = "Cadastre-se";
            criarbot.UseVisualStyleBackColor = false;
            criarbot.Click += criarbot_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.HotPink;
            ClientSize = new Size(910, 505);
            Controls.Add(criarbot);
            Controls.Add(usuariotext);
            Controls.Add(email);
            Controls.Add(senhatext);
            Controls.Add(Showsenha);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblUsuarioCadastro);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private LinkLabel linkLabel1;
        private Label lblUsuarioCadastro;
        private Label label3;
        private Label label4;
        private TextBox usuariotext;
        private TextBox email;
        private TextBox senhatext;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button Showsenha;
        private PictureBox pictureBox5;
        private Button ShowSenha;
        private Button criarbot;
    }
}