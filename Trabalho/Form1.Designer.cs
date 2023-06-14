namespace Trabalho
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
            pictureBox2 = new PictureBox();
            lbl_BemVindo = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            lbl_Dis4 = new Label();
            lbl_Dis3 = new Label();
            lbl_Dis2 = new Label();
            lbl_Dis1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(257, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_BemVindo
            // 
            lbl_BemVindo.AutoSize = true;
            lbl_BemVindo.BackColor = Color.Transparent;
            lbl_BemVindo.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BemVindo.ForeColor = Color.White;
            lbl_BemVindo.Location = new Point(12, 83);
            lbl_BemVindo.Name = "lbl_BemVindo";
            lbl_BemVindo.Size = new Size(121, 16);
            lbl_BemVindo.TabIndex = 2;
            lbl_BemVindo.Text = "Ola Joao, Bem vindo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 3;
            label2.Text = "Vamos começar o teste";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(36, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 29);
            textBox1.TabIndex = 4;
            textBox1.Text = "asdasd";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(lbl_Dis4);
            groupBox1.Controls.Add(lbl_Dis3);
            groupBox1.Controls.Add(lbl_Dis2);
            groupBox1.Controls.Add(lbl_Dis1);
            groupBox1.Location = new Point(-3, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 348);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(28, 157);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lbl_Dis4
            // 
            lbl_Dis4.AutoSize = true;
            lbl_Dis4.Location = new Point(228, 28);
            lbl_Dis4.Name = "lbl_Dis4";
            lbl_Dis4.Size = new Size(53, 15);
            lbl_Dis4.TabIndex = 3;
            lbl_Dis4.Text = "Desenho";
            // 
            // lbl_Dis3
            // 
            lbl_Dis3.AutoSize = true;
            lbl_Dis3.Location = new Point(170, 28);
            lbl_Dis3.Name = "lbl_Dis3";
            lbl_Dis3.Size = new Size(36, 15);
            lbl_Dis3.TabIndex = 2;
            lbl_Dis3.Text = "Fisica";
            // 
            // lbl_Dis2
            // 
            lbl_Dis2.AutoSize = true;
            lbl_Dis2.Location = new Point(91, 28);
            lbl_Dis2.Name = "lbl_Dis2";
            lbl_Dis2.Size = new Size(52, 15);
            lbl_Dis2.TabIndex = 1;
            lbl_Dis2.Text = "Quimica";
            // 
            // lbl_Dis1
            // 
            lbl_Dis1.AutoSize = true;
            lbl_Dis1.Location = new Point(15, 28);
            lbl_Dis1.Name = "lbl_Dis1";
            lbl_Dis1.Size = new Size(70, 15);
            lbl_Dis1.TabIndex = 0;
            lbl_Dis1.Text = "Matematica";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(15, 143);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(20, 20);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Enabled = false;
            textBox2.Location = new Point(13, 138);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(28, 29);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(306, 519);
            Controls.Add(pictureBox3);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(lbl_BemVindo);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label lbl_BemVindo;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private Label lbl_Dis3;
        private Label lbl_Dis2;
        private Label lbl_Dis1;
        private Label lbl_Dis4;
        private Button button1;
    }
}