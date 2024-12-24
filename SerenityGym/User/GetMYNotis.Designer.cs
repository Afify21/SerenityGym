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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            TB_NOTIS = new TextBox();
            B_Next = new Button();
            L_Text = new Label();
            B_Prev = new Button();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(TB_NOTIS);
            panel2.Controls.Add(B_Next);
            panel2.Controls.Add(L_Text);
            panel2.Controls.Add(B_Prev);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(112, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 424);
            panel2.TabIndex = 1;
            // 
            // TB_NOTIS
            // 
            TB_NOTIS.Enabled = false;
            TB_NOTIS.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TB_NOTIS.ForeColor = Color.FromArgb(41, 128, 185);
            TB_NOTIS.Location = new Point(50, 106);
            TB_NOTIS.Margin = new Padding(2);
            TB_NOTIS.Multiline = true;
            TB_NOTIS.Name = "TB_NOTIS";
            TB_NOTIS.Size = new Size(388, 233);
            TB_NOTIS.TabIndex = 12;
            TB_NOTIS.TextChanged += Userid_TextChanged;
            // 
            // B_Next
            // 
            B_Next.BackColor = Color.FromArgb(41, 128, 185);
            B_Next.FlatStyle = FlatStyle.Flat;
            B_Next.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Next.ForeColor = Color.White;
            B_Next.Location = new Point(320, 362);
            B_Next.Margin = new Padding(2);
            B_Next.Name = "B_Next";
            B_Next.Size = new Size(118, 28);
            B_Next.TabIndex = 11;
            B_Next.Text = "Next";
            B_Next.UseVisualStyleBackColor = false;
            // 
            // L_Text
            // 
            L_Text.AutoSize = true;
            L_Text.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Text.Location = new Point(248, 58);
            L_Text.Margin = new Padding(2, 0, 2, 0);
            L_Text.Name = "L_Text";
            L_Text.Size = new Size(96, 21);
            L_Text.TabIndex = 10;
            L_Text.Text = "Category";
            // 
            // B_Prev
            // 
            B_Prev.BackColor = Color.FromArgb(41, 128, 185);
            B_Prev.FlatStyle = FlatStyle.Flat;
            B_Prev.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Prev.ForeColor = Color.White;
            B_Prev.Location = new Point(50, 362);
            B_Prev.Margin = new Padding(2);
            B_Prev.Name = "B_Prev";
            B_Prev.Size = new Size(118, 28);
            B_Prev.TabIndex = 7;
            B_Prev.Text = "Prevoius";
            B_Prev.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(50, 46);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(178, 33);
            label2.TabIndex = 2;
            label2.Text = "Notifications";
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
            // GetMYNotis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Button B_Prev;
        private Button B_Next;
        private Label L_Text;
        private TextBox TB_NOTIS;
    }
}
