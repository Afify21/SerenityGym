namespace SerenityGym
{
    partial class Statistics_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics_table));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            star2 = new PictureBox();
            star3 = new PictureBox();
            star5 = new PictureBox();
            star4 = new PictureBox();
            star1 = new PictureBox();
            pictureBox4 = new PictureBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            Stafff = new Button();
            Userr = new Button();
            button1 = new Button();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(41, 540);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(372, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 33);
            label1.TabIndex = 1;
            label1.Text = "Serenity Gym";
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(star2);
            panel2.Controls.Add(star3);
            panel2.Controls.Add(star5);
            panel2.Controls.Add(star4);
            panel2.Controls.Add(star1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Stafff);
            panel2.Controls.Add(Userr);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(41, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 540);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // star2
            // 
            star2.Image = (Image)resources.GetObject("star2.Image");
            star2.Location = new Point(182, 420);
            star2.Name = "star2";
            star2.Size = new Size(177, 47);
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.TabIndex = 18;
            star2.TabStop = false;
            // 
            // star3
            // 
            star3.Image = (Image)resources.GetObject("star3.Image");
            star3.Location = new Point(182, 420);
            star3.Name = "star3";
            star3.Size = new Size(177, 47);
            star3.SizeMode = PictureBoxSizeMode.StretchImage;
            star3.TabIndex = 17;
            star3.TabStop = false;
            // 
            // star5
            // 
            star5.Image = (Image)resources.GetObject("star5.Image");
            star5.Location = new Point(182, 420);
            star5.Name = "star5";
            star5.Size = new Size(177, 47);
            star5.SizeMode = PictureBoxSizeMode.StretchImage;
            star5.TabIndex = 16;
            star5.TabStop = false;
            // 
            // star4
            // 
            star4.Image = (Image)resources.GetObject("star4.Image");
            star4.Location = new Point(182, 420);
            star4.Name = "star4";
            star4.Size = new Size(177, 47);
            star4.SizeMode = PictureBoxSizeMode.StretchImage;
            star4.TabIndex = 15;
            star4.TabStop = false;
            // 
            // star1
            // 
            star1.Image = (Image)resources.GetObject("star1.Image");
            star1.Location = new Point(182, 420);
            star1.Name = "star1";
            star1.Size = new Size(177, 47);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 14;
            star1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 30);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(891, 262);
            dataGridView1.TabIndex = 13;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(372, 345);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(180, 47);
            button2.TabIndex = 13;
            button2.Text = "show feedbacks";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(165, 366);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 12;
            label2.Text = "Serenity Gym";
            label2.Click += label2_Click;
            // 
            // Stafff
            // 
            Stafff.BackColor = Color.FromArgb(41, 128, 185);
            Stafff.FlatStyle = FlatStyle.Flat;
            Stafff.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stafff.ForeColor = Color.White;
            Stafff.Location = new Point(12, 420);
            Stafff.Margin = new Padding(2);
            Stafff.Name = "Stafff";
            Stafff.Size = new Size(165, 47);
            Stafff.TabIndex = 8;
            Stafff.Text = "view reviews";
            Stafff.UseVisualStyleBackColor = false;
            Stafff.Click += Stafff_Click;
            // 
            // Userr
            // 
            Userr.BackColor = Color.FromArgb(41, 128, 185);
            Userr.FlatStyle = FlatStyle.Flat;
            Userr.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userr.ForeColor = Color.White;
            Userr.Location = new Point(12, 345);
            Userr.Margin = new Padding(2);
            Userr.Name = "Userr";
            Userr.Size = new Size(136, 47);
            Userr.TabIndex = 7;
            Userr.Text = "PROFIT";
            Userr.UseVisualStyleBackColor = false;
            Userr.Click += Userr_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(889, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(394, 433);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 19;
            label3.Text = "Serenity Gym";
            // 
            // Statistics_table
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 540);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Statistics_table";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button Stafff;
        private Button Userr;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox4;
        private Button button2;
        private PictureBox star2;
        private PictureBox star3;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star1;
    }
}
