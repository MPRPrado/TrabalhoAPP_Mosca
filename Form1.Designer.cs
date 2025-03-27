namespace TrabalhoAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ShowSenha = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btLogin = new Button();
            label7 = new Label();
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            pictureBox4 = new PictureBox();
            label12 = new Label();
            usuariotext = new TextBox();
            senhatxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(439, 78);
            label1.Name = "label1";
            label1.Size = new Size(335, 47);
            label1.TabIndex = 1;
            label1.Text = "Entre em sua conta";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(439, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(439, 272);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(427, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 50);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(427, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(362, 50);
            textBox2.TabIndex = 6;
            // 
            // ShowSenha
            // 
            ShowSenha.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatAppearance.BorderSize = 0;
            ShowSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatStyle = FlatStyle.Flat;
            ShowSenha.Image = (Image)resources.GetObject("ShowSenha.Image");
            ShowSenha.Location = new Point(795, 277);
            ShowSenha.Name = "ShowSenha";
            ShowSenha.Size = new Size(30, 27);
            ShowSenha.TabIndex = 7;
            ShowSenha.UseVisualStyleBackColor = true;
            ShowSenha.Click += ShowSenha_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(427, 150);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 8;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(428, 239);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 9;
            label3.Text = "Senha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.HotPink;
            label4.Font = new Font("Leelawadee UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 19);
            label4.Name = "label4";
            label4.Size = new Size(200, 47);
            label4.TabIndex = 10;
            label4.Text = "Bem-vindo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.HotPink;
            label5.Font = new Font("Leelawadee UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 66);
            label5.Name = "label5";
            label5.Size = new Size(165, 47);
            label5.TabIndex = 11;
            label5.Text = "de volta!";
            label5.Click += label5_Click;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.HotPink;
            btLogin.Cursor = Cursors.AppStarting;
            btLogin.FlatAppearance.BorderColor = Color.HotPink;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.HotPink;
            btLogin.FlatAppearance.MouseOverBackColor = Color.HotPink;
            btLogin.FlatStyle = FlatStyle.Popup;
            btLogin.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(483, 344);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(256, 50);
            btLogin.TabIndex = 13;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.HotPink;
            label7.ForeColor = Color.White;
            label7.Location = new Point(38, 457);
            label7.Name = "label7";
            label7.Size = new Size(126, 15);
            label7.TabIndex = 15;
            label7.Text = "Ainda não tem conta? ";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.White;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.HotPink;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.ForeColor = Color.White;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(157, 457);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 15);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Faça seu cadastro aqui!";
            linkLabel1.VisitedLinkColor = Color.White;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.HotPink;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 206);
            label6.Name = "label6";
            label6.Size = new Size(146, 21);
            label6.TabIndex = 17;
            label6.Text = "\" Se quiser guardar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.HotPink;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(37, 222);
            label8.Name = "label8";
            label8.Size = new Size(154, 21);
            label8.TabIndex = 18;
            label8.Text = "um segredo, comece";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.HotPink;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.White;
            label9.Location = new Point(38, 239);
            label9.Name = "label9";
            label9.Size = new Size(161, 21);
            label9.TabIndex = 19;
            label9.Text = "por você mesmo, não";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.HotPink;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = Color.White;
            label10.Location = new Point(37, 256);
            label10.Name = "label10";
            label10.Size = new Size(145, 21);
            label10.TabIndex = 20;
            label10.Text = "conte a ninguem! \"";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.HotPink;
            pictureBox1.Location = new Point(-3, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 519);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.HotPink;
            label11.ForeColor = Color.White;
            label11.Location = new Point(38, 276);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 21;
            label11.Text = "Caroline Castroki";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.HotPink;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(233, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(798, 162);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 23;
            // 
            // usuariotext
            // 
            usuariotext.BorderStyle = BorderStyle.None;
            usuariotext.Font = new Font("Segoe UI", 9.75F);
            usuariotext.Location = new Point(483, 187);
            usuariotext.Name = "usuariotext";
            usuariotext.Size = new Size(291, 18);
            usuariotext.TabIndex = 24;
            usuariotext.TextChanged += user_TextChanged;
            // 
            // senhatxt
            // 
            senhatxt.BorderStyle = BorderStyle.None;
            senhatxt.Font = new Font("Segoe UI", 9.75F);
            senhatxt.Location = new Point(483, 278);
            senhatxt.Name = "senhatxt";
            senhatxt.Size = new Size(291, 18);
            senhatxt.TabIndex = 25;
            senhatxt.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(910, 505);
            Controls.Add(senhatxt);
            Controls.Add(usuariotext);
            Controls.Add(label12);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(btLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(ShowSenha);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Diario Pessoal Automatizado";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ShowSenha;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btLogin;
        private Label label7;
        private LinkLabel linkLabel1;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private PictureBox pictureBox4;
        private Label label12;
        private TextBox usuariotext;
        private TextBox senhatxt;
    }
}
