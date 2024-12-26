namespace SerenityGym
{
    partial class Updatestaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updatestaff));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            deletebutton = new Button();
            B_Update = new Button();
            staffidbox = new TextBox();
            label2 = new Label();
            CB_Updator = new ComboBox();
            label4 = new Label();
            TB_Update = new TextBox();
            label3 = new Label();
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
            panel1.Size = new Size(112, 424);
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 33);
            label1.TabIndex = 1;
            label1.Text = "Update Staff";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(deletebutton);
            panel2.Controls.Add(B_Update);
            panel2.Controls.Add(staffidbox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CB_Updator);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TB_Update);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(112, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 424);
            panel2.TabIndex = 1;
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
            // deletebutton
            // 
            deletebutton.BackColor = Color.FromArgb(41, 128, 185);
            deletebutton.FlatStyle = FlatStyle.Flat;
            deletebutton.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(334, 81);
            deletebutton.Margin = new Padding(2);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(118, 33);
            deletebutton.TabIndex = 20;
            deletebutton.Text = "Delete staff";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // B_Update
            // 
            B_Update.BackColor = Color.FromArgb(41, 128, 185);
            B_Update.FlatStyle = FlatStyle.Flat;
            B_Update.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Update.ForeColor = Color.White;
            B_Update.Location = new Point(150, 364);
            B_Update.Margin = new Padding(2);
            B_Update.Name = "B_Update";
            B_Update.Size = new Size(118, 33);
            B_Update.TabIndex = 19;
            B_Update.Text = "Update";
            B_Update.UseVisualStyleBackColor = false;
            B_Update.Click += B_Update_Click;
            // 
            // staffidbox
            // 
            staffidbox.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffidbox.ForeColor = Color.FromArgb(41, 128, 185);
            staffidbox.Location = new Point(92, 81);
            staffidbox.Margin = new Padding(2);
            staffidbox.Name = "staffidbox";
            staffidbox.Size = new Size(200, 28);
            staffidbox.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(4, 84);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 17;
            label2.Text = "StaffID";
            // 
            // CB_Updator
            // 
            CB_Updator.FlatStyle = FlatStyle.Flat;
            CB_Updator.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Updator.ForeColor = Color.FromArgb(41, 128, 185);
            CB_Updator.FormattingEnabled = true;
            CB_Updator.Location = new Point(105, 166);
            CB_Updator.Name = "CB_Updator";
            CB_Updator.Size = new Size(144, 28);
            CB_Updator.TabIndex = 15;
            CB_Updator.SelectedIndexChanged += CB_Updator_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 173);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 14;
            label4.Text = "Category";
            label4.Click += label4_Click;
            // 
            // TB_Update
            // 
            TB_Update.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_Update.ForeColor = Color.FromArgb(41, 128, 185);
            TB_Update.Location = new Point(186, 265);
            TB_Update.Margin = new Padding(2);
            TB_Update.Name = "TB_Update";
            TB_Update.Size = new Size(200, 28);
            TB_Update.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 268);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 13;
            label3.Text = "Serenity Gym";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(456, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Updatestaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Updatestaff";
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
        private Label label1;
        private Button button1;
        private TextBox TB_Update;
        private Label label3;
        private ComboBox CB_Updator;
        private Label label4;
        private TextBox staffidbox;
        private Label label2;
        private Button B_Update;
        private Button deletebutton;
        private PictureBox pictureBox4;
    }
}
