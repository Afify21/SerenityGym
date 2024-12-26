namespace SerenityGym
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            panel1 = new Panel();
            button3 = new Button();
            upd = new ComboBox();
            Stafff = new Button();
            button2 = new Button();
            Userr = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button7 = new Button();
            label2 = new Label();
            button1 = new Button();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(upd);
            panel1.Controls.Add(Stafff);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(Userr);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 530);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(41, 128, 185);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(14, 329);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(172, 84);
            button3.TabIndex = 11;
            button3.Text = "CLOCK OUT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // upd
            // 
            upd.FormattingEnabled = true;
            upd.Items.AddRange(new object[] { "User", "Self" });
            upd.Location = new Point(26, 109);
            upd.Margin = new Padding(2);
            upd.Name = "upd";
            upd.Size = new Size(152, 33);
            upd.TabIndex = 10;
            // 
            // Stafff
            // 
            Stafff.BackColor = Color.FromArgb(41, 128, 185);
            Stafff.FlatStyle = FlatStyle.Flat;
            Stafff.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stafff.ForeColor = Color.White;
            Stafff.Location = new Point(14, 161);
            Stafff.Margin = new Padding(2);
            Stafff.Name = "Stafff";
            Stafff.Size = new Size(172, 76);
            Stafff.TabIndex = 8;
            Stafff.Text = "SIGN UP USER";
            Stafff.UseVisualStyleBackColor = false;
            Stafff.Click += Stafff_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(14, 242);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(172, 81);
            button2.TabIndex = 9;
            button2.Text = "SEND NOTIFICATION";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Userr
            // 
            Userr.BackColor = Color.FromArgb(41, 128, 185);
            Userr.FlatStyle = FlatStyle.Flat;
            Userr.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userr.ForeColor = Color.White;
            Userr.Location = new Point(14, 34);
            Userr.Margin = new Padding(2);
            Userr.Name = "Userr";
            Userr.Size = new Size(172, 70);
            Userr.TabIndex = 7;
            Userr.Text = "UPDATE";
            Userr.UseVisualStyleBackColor = false;
            Userr.Click += Userr_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(62, 132);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(209, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 530);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 128, 185);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 486);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(126, 41);
            button7.TabIndex = 19;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(99, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 2;
            label2.Text = "Receptionist";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(499, 2);
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
            pictureBox4.Location = new Point(0, 10);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 37);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_1;
            // 
            // Receptionist
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Receptionist";
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
        private Button button1;
        private Label label2;
        private Button Stafff;
        private Button Userr;
        private Button button7;
        private ComboBox upd;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox4;
    }
}
