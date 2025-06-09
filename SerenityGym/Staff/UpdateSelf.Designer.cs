namespace SerenityGym
{
    partial class UpdateSelf
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
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            confirm = new TextBox();
            num = new TextBox();
            pass = new TextBox();
            add = new TextBox();
            fname = new TextBox();
            Address = new Label();
            lname = new TextBox();
            button1 = new Button();
            Stafff = new Button();
            Userr = new Button();
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
            pictureBox1.Location = new Point(11, 174);
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
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(50, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 31);
            label1.TabIndex = 1;
            label1.Text = "Update your Information";
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(confirm);
            panel2.Controls.Add(num);
            panel2.Controls.Add(pass);
            panel2.Controls.Add(add);
            panel2.Controls.Add(fname);
            panel2.Controls.Add(Address);
            panel2.Controls.Add(lname);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(Stafff);
            panel2.Controls.Add(Userr);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(112, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 424);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 259);
            label6.Name = "label6";
            label6.Size = new Size(222, 20);
            label6.TabIndex = 19;
            label6.Text = "Confirm your previous password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(343, 205);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 18;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 205);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 17;
            label4.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 125);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 16;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 125);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 15;
            label2.Text = "First Name";
            // 
            // confirm
            // 
            confirm.Location = new Point(188, 282);
            confirm.Name = "confirm";
            confirm.PasswordChar = '*';
            confirm.Size = new Size(125, 27);
            confirm.TabIndex = 14;
            // 
            // num
            // 
            num.Location = new Point(57, 228);
            num.Name = "num";
            num.Size = new Size(125, 27);
            num.TabIndex = 13;
            // 
            // pass
            // 
            pass.Location = new Point(326, 228);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(125, 27);
            pass.TabIndex = 12;
            pass.TextChanged += pass_TextChanged;
            // 
            // add
            // 
            add.Location = new Point(188, 107);
            add.Name = "add";
            add.Size = new Size(125, 27);
            add.TabIndex = 11;
            // 
            // fname
            // 
            fname.Location = new Point(57, 148);
            fname.Name = "fname";
            fname.Size = new Size(125, 27);
            fname.TabIndex = 10;
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Location = new Point(223, 84);
            Address.Name = "Address";
            Address.Size = new Size(62, 20);
            Address.TabIndex = 9;
            Address.Text = "Address";
            // 
            // lname
            // 
            lname.Location = new Point(326, 148);
            lname.Name = "lname";
            lname.Size = new Size(125, 27);
            lname.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(445, 11);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Stafff
            // 
            Stafff.BackColor = Color.FromArgb(41, 128, 185);
            Stafff.FlatStyle = FlatStyle.Flat;
            Stafff.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stafff.ForeColor = Color.White;
            Stafff.Location = new Point(289, 357);
            Stafff.Margin = new Padding(2);
            Stafff.Name = "Stafff";
            Stafff.Size = new Size(118, 28);
            Stafff.TabIndex = 8;
            Stafff.Text = "UPDATE";
            Stafff.UseVisualStyleBackColor = false;
            Stafff.Click += Stafff_Click;
            // 
            // Userr
            // 
            Userr.BackColor = Color.FromArgb(41, 128, 185);
            Userr.FlatStyle = FlatStyle.Flat;
            Userr.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userr.ForeColor = Color.White;
            Userr.Location = new Point(64, 357);
            Userr.Margin = new Padding(2);
            Userr.Name = "Userr";
            Userr.Size = new Size(118, 28);
            Userr.TabIndex = 7;
            Userr.Text = "BACK";
            Userr.UseVisualStyleBackColor = false;
            Userr.Click += Userr_Click;
            // 
            // UpdateSelf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UpdateSelf";
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
        private Label label1;
        private Button button1;
        private Button Stafff;
        private Button Userr;
        private Label Address;
        private TextBox lname;
        private TextBox confirm;
        private TextBox num;
        private TextBox pass;
        private TextBox add;
        private TextBox fname;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
