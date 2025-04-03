namespace TrabalhoAPP
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            ShowSenha = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 20.25F);
            textBox1.Location = new Point(37, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 36);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(135, 369);
            button1.Name = "button1";
            button1.Size = new Size(174, 36);
            button1.TabIndex = 4;
            button1.Text = "Criar senha";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.HotPink;
            label2.Location = new Point(31, 190);
            label2.Name = "label2";
            label2.Size = new Size(386, 40);
            label2.TabIndex = 1;
            label2.Text = "para trancar seus segredos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(180, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 21.75F, FontStyle.Bold);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(73, 150);
            label1.Name = "label1";
            label1.Size = new Size(304, 40);
            label1.TabIndex = 0;
            label1.Text = "Crie uma nova senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(37, 250);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 5;
            label3.Text = "Nova senha:";
            // 
            // ShowSenha
            // 
            ShowSenha.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatAppearance.BorderSize = 0;
            ShowSenha.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            ShowSenha.FlatStyle = FlatStyle.Flat;
            ShowSenha.Image = (Image)resources.GetObject("ShowSenha.Image");
            ShowSenha.Location = new Point(403, 279);
            ShowSenha.Name = "ShowSenha";
            ShowSenha.Size = new Size(30, 27);
            ShowSenha.TabIndex = 9;
            ShowSenha.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.Location = new Point(37, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 18);
            textBox2.TabIndex = 10;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(458, 442);
            Controls.Add(textBox2);
            Controls.Add(ShowSenha);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Button ShowSenha;
        private TextBox textBox2;
    }
}