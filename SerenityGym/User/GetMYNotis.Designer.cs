namespace SerenityGym
{
    partial class GetMYNotis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetMYNotis));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            L_Date = new Label();
            TB_NOTIS = new TextBox();
            B_prev = new Button();
            B_Nextt = new Button();
            label2 = new Label();
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
            panel1.Size = new Size(140, 530);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(14, 210);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(L_Date);
            panel2.Controls.Add(TB_NOTIS);
            panel2.Controls.Add(B_prev);
            panel2.Controls.Add(B_Nextt);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(140, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 530);
            panel2.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(28, 37);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // L_Date
            // 
            L_Date.AutoSize = true;
            L_Date.BackColor = Color.Transparent;
            L_Date.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Date.Location = new Point(241, 375);
            L_Date.Margin = new Padding(2, 0, 2, 0);
            L_Date.Name = "L_Date";
            L_Date.Size = new Size(116, 25);
            L_Date.TabIndex = 13;
            L_Date.Text = "Category";
            // 
            // TB_NOTIS
            // 
            TB_NOTIS.Enabled = false;
            TB_NOTIS.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_NOTIS.ForeColor = Color.FromArgb(41, 128, 185);
            TB_NOTIS.Location = new Point(62, 128);
            TB_NOTIS.Margin = new Padding(2);
            TB_NOTIS.Multiline = true;
            TB_NOTIS.Name = "TB_NOTIS";
            TB_NOTIS.Size = new Size(484, 290);
            TB_NOTIS.TabIndex = 12;
            TB_NOTIS.TextChanged += Userid_TextChanged;
            // 
            // B_prev
            // 
            B_prev.BackColor = Color.FromArgb(41, 128, 185);
            B_prev.FlatStyle = FlatStyle.Flat;
            B_prev.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_prev.ForeColor = Color.White;
            B_prev.Location = new Point(400, 452);
            B_prev.Margin = new Padding(2);
            B_prev.Name = "B_prev";
            B_prev.Size = new Size(148, 35);
            B_prev.TabIndex = 11;
            B_prev.Text = "Previous";
            B_prev.UseVisualStyleBackColor = false;
            B_prev.Click += B_Next_Click;
            // 
            // B_Nextt
            // 
            B_Nextt.BackColor = Color.FromArgb(41, 128, 185);
            B_Nextt.FlatStyle = FlatStyle.Flat;
            B_Nextt.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Nextt.ForeColor = Color.White;
            B_Nextt.Location = new Point(62, 452);
            B_Nextt.Margin = new Padding(2);
            B_Nextt.Name = "B_Nextt";
            B_Nextt.Size = new Size(148, 35);
            B_Nextt.TabIndex = 7;
            B_Nextt.Text = "Next";
            B_Nextt.UseVisualStyleBackColor = false;
            B_Nextt.Click += B_Prev_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(62, 58);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 39);
            label2.TabIndex = 2;
            label2.Text = "Notifications";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(570, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GetMYNotis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "GetMYNotis";
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
        private Button B_Nextt;
        private Button B_prev;
        private TextBox TB_NOTIS;
        private Label L_Date;
        private PictureBox pictureBox4;
    }
}
