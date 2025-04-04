namespace TrabalhoAPP
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ok = new Button();
            texto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.HotPink;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 611);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.HotPink;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(8, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(83, 26);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 2;
            label1.Text = "Escreva no espaço abaixo:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 562);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ok
            // 
            ok.BackColor = Color.HotPink;
            ok.FlatStyle = FlatStyle.Flat;
            ok.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            ok.ForeColor = Color.White;
            ok.Location = new Point(886, 562);
            ok.Name = "ok";
            ok.Size = new Size(154, 36);
            ok.TabIndex = 5;
            ok.Text = "Salvar";
            ok.TextAlign = ContentAlignment.TopCenter;
            ok.UseVisualStyleBackColor = false;
            ok.Click += Ok_Click;
            // 
            // texto
            // 
            texto.Location = new Point(112, 80);
            texto.Multiline = true;
            texto.Name = "texto";
            texto.Size = new Size(928, 476);
            texto.TabIndex = 6;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1052, 606);
            Controls.Add(texto);
            Controls.Add(ok);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Button button1;
        private Button ok;
        private TextBox texto;
    }
}