﻿namespace SerenityGym
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button3 = new Button();
            Login = new Button();
            panel4 = new Panel();
            TB_Pass = new TextBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            TB_id = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 235);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 39);
            label1.TabIndex = 1;
            label1.Text = "Serenity Gym";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(95, 56);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(41, 128, 185);
            button3.Location = new Point(221, 362);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(198, 56);
            button3.TabIndex = 6;
            button3.Text = "Forgot Password?";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(41, 128, 185);
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(35, 362);
            Login.Margin = new Padding(2);
            Login.Name = "Login";
            Login.Size = new Size(148, 56);
            Login.TabIndex = 5;
            Login.Text = "LOGIN";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(TB_Pass);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(0, 256);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 48);
            panel4.TabIndex = 4;
            // 
            // TB_Pass
            // 
            TB_Pass.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Pass.Location = new Point(48, 6);
            TB_Pass.Margin = new Padding(2);
            TB_Pass.Name = "TB_Pass";
            TB_Pass.Size = new Size(370, 32);
            TB_Pass.TabIndex = 5;
            TB_Pass.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, 10);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 71);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(TB_id);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 185);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(450, 48);
            panel3.TabIndex = 3;
            // 
            // TB_id
            // 
            TB_id.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_id.ForeColor = Color.FromArgb(41, 128, 185);
            TB_id.Location = new Point(48, 6);
            TB_id.Margin = new Padding(2);
            TB_id.Name = "TB_id";
            TB_id.Size = new Size(370, 32);
            TB_id.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 10);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 71);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(24, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(361, 39);
            label2.TabIndex = 2;
            label2.Text = "Login to your account";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(410, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 37);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "StaffLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox TB_id;
        private TextBox TB_Pass;
        private Button Login;
        private Button button3;
        private PictureBox pictureBox4;
    }
}
