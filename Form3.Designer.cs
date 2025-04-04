namespace TrabalhoAPP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            criar = new Button();
            diarios = new GroupBox();
            papai = new Button();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            diarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // criar
            // 
            criar.BackColor = Color.HotPink;
            criar.FlatAppearance.BorderSize = 0;
            criar.FlatStyle = FlatStyle.Flat;
            criar.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            criar.ForeColor = Color.White;
            criar.Location = new Point(802, 555);
            criar.Name = "criar";
            criar.Size = new Size(238, 39);
            criar.TabIndex = 0;
            criar.Text = "Novo Segredo";
            criar.UseVisualStyleBackColor = false;
            criar.Click += Criar_Click;
            // 
            // diarios
            // 
            diarios.BackgroundImageLayout = ImageLayout.None;
            diarios.Controls.Add(button1);
            diarios.Controls.Add(papai);
            diarios.FlatStyle = FlatStyle.Flat;
            diarios.Font = new Font("Segoe UI", 12F);
            diarios.ForeColor = Color.HotPink;
            diarios.Location = new Point(12, 151);
            diarios.Name = "diarios";
            diarios.Size = new Size(719, 373);
            diarios.TabIndex = 4;
            diarios.TabStop = false;
            diarios.Text = "Diarios";
            diarios.Enter += groupBox1_Enter;
            // 
            // papai
            // 
            papai.BackColor = Color.White;
            papai.BackgroundImageLayout = ImageLayout.None;
            papai.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            papai.FlatAppearance.BorderSize = 0;
            papai.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 0, 0);
            papai.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 0, 0);
            papai.FlatStyle = FlatStyle.Flat;
            papai.Location = new Point(21, 28);
            papai.Margin = new Padding(0);
            papai.Name = "papai";
            papai.Size = new Size(675, 40);
            papai.TabIndex = 0;
            papai.Text = "Diário Inicial";
            papai.UseVisualStyleBackColor = false;
            papai.Visible = false;
            papai.VisibleChanged += papai_VisibleChanged;
            papai.Click += papai_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.HotPink;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(80, 12);
            label3.Name = "label3";
            label3.Size = new Size(230, 45);
            label3.TabIndex = 5;
            label3.Text = "Diário Digital:";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.HotPink;
            pictureBox2.Location = new Point(-1, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1055, 78);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.HotPink;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LavenderBlush;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.HotPink;
            label4.Location = new Point(10, 92);
            label4.Name = "label4";
            label4.Size = new Size(530, 45);
            label4.TabIndex = 8;
            label4.Text = "Seus segredos estão a salvos aqui:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.HotPink;
            label1.Location = new Point(508, 552);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 9;
            label1.Text = "Criar novo arquivo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(777, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 421);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.HotPink;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(475, 328);
            button1.Name = "button1";
            button1.Size = new Size(238, 39);
            button1.TabIndex = 11;
            button1.Text = "Apagar diário";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1052, 606);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(criar);
            Controls.Add(diarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            diarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criar;
        private GroupBox diarios;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button papai;
        private Button button1;
    }
}