namespace SerenityGym
{
    partial class UpdatePersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePersonal));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            TB_Updator2 = new TextBox();
            TB_Update = new TextBox();
            CB_Updator = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            B_Update = new Button();
            labell = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Size = new Size(114, 424);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(11, 168);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 275);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 21);
            label4.TabIndex = 1;
            label4.Text = "Serenity Gym";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(TB_Updator2);
            panel2.Controls.Add(TB_Update);
            panel2.Controls.Add(CB_Updator);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(B_Update);
            panel2.Controls.Add(labell);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(114, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(486, 424);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 30);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // TB_Updator2
            // 
            TB_Updator2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Updator2.ForeColor = Color.FromArgb(41, 128, 185);
            TB_Updator2.Location = new Point(192, 272);
            TB_Updator2.Margin = new Padding(2);
            TB_Updator2.Name = "TB_Updator2";
            TB_Updator2.Size = new Size(200, 28);
            TB_Updator2.TabIndex = 12;
            // 
            // TB_Update
            // 
            TB_Update.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Update.ForeColor = Color.FromArgb(41, 128, 185);
            TB_Update.Location = new Point(192, 221);
            TB_Update.Margin = new Padding(2);
            TB_Update.Name = "TB_Update";
            TB_Update.Size = new Size(200, 28);
            TB_Update.TabIndex = 2;
            // 
            // CB_Updator
            // 
            CB_Updator.FlatStyle = FlatStyle.Flat;
            CB_Updator.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Updator.ForeColor = Color.FromArgb(41, 128, 185);
            CB_Updator.FormattingEnabled = true;
            CB_Updator.Location = new Point(192, 102);
            CB_Updator.Name = "CB_Updator";
            CB_Updator.Size = new Size(200, 28);
            CB_Updator.TabIndex = 11;
            CB_Updator.SelectedIndexChanged += CB_Updator_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 224);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 10;
            label3.Text = "Serenity Gym";
            label3.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 104);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 9;
            label2.Text = "Category";
            label2.Click += label2_Click;
            // 
            // B_Update
            // 
            B_Update.BackColor = Color.FromArgb(41, 128, 185);
            B_Update.FlatStyle = FlatStyle.Flat;
            B_Update.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Update.ForeColor = Color.White;
            B_Update.Location = new Point(150, 354);
            B_Update.Margin = new Padding(2);
            B_Update.Name = "B_Update";
            B_Update.Size = new Size(118, 33);
            B_Update.TabIndex = 8;
            B_Update.Text = "Update";
            B_Update.UseVisualStyleBackColor = false;
            B_Update.Click += B_Update_Click;
            // 
            // labell
            // 
            labell.AutoSize = true;
            labell.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labell.ForeColor = Color.FromArgb(41, 128, 185);
            labell.Location = new Point(23, 47);
            labell.Margin = new Padding(2, 0, 2, 0);
            labell.Name = "labell";
            labell.Size = new Size(403, 23);
            labell.TabIndex = 2;
            labell.Text = "Please choose what you want to update";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(454, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdatePersonal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UpdatePersonal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
        private Label labell;
        private Button B_Update;
        private Label label3;
        private Label label2;
        private ComboBox CB_Updator;
        private TextBox TB_Updator2;
        private TextBox TB_Update;
        private PictureBox pictureBox4;
    }
}
