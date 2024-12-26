namespace SerenityGym
{
    partial class RecReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecReg));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            userid = new Panel();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            payment = new ComboBox();
            userd = new TextBox();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            B_T8 = new Button();
            B_T9 = new Button();
            B_T7 = new Button();
            B_T1 = new Button();
            CB_Trainers = new ComboBox();
            L_Trainer = new Label();
            B_T6 = new Button();
            B_T4 = new Button();
            B_T5 = new Button();
            B_T3 = new Button();
            B_T2 = new Button();
            CB_SesType = new ComboBox();
            label1 = new Label();
            B_Master = new Button();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            userid.SuspendLayout();
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
            // userid
            // 
            userid.Controls.Add(comboBox1);
            userid.Controls.Add(label5);
            userid.Controls.Add(label4);
            userid.Controls.Add(payment);
            userid.Controls.Add(userd);
            userid.Controls.Add(label3);
            userid.Controls.Add(pictureBox4);
            userid.Controls.Add(B_T8);
            userid.Controls.Add(B_T9);
            userid.Controls.Add(B_T7);
            userid.Controls.Add(B_T1);
            userid.Controls.Add(CB_Trainers);
            userid.Controls.Add(L_Trainer);
            userid.Controls.Add(B_T6);
            userid.Controls.Add(B_T4);
            userid.Controls.Add(B_T5);
            userid.Controls.Add(B_T3);
            userid.Controls.Add(B_T2);
            userid.Controls.Add(CB_SesType);
            userid.Controls.Add(label1);
            userid.Controls.Add(B_Master);
            userid.Controls.Add(label2);
            userid.Controls.Add(button1);
            userid.Dock = DockStyle.Fill;
            userid.Location = new Point(112, 0);
            userid.Margin = new Padding(2);
            userid.Name = "userid";
            userid.Size = new Size(488, 424);
            userid.TabIndex = 1;
            userid.Paint += panel2_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.FromArgb(41, 128, 185);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(222, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 26);
            comboBox1.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 145);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 35;
            label5.Text = "Membership Type";
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 22);
            label4.TabIndex = 34;
            label4.Text = "Payment Method";
            // 
            // payment
            // 
            payment.FlatStyle = FlatStyle.Flat;
            payment.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment.ForeColor = Color.FromArgb(41, 128, 185);
            payment.FormattingEnabled = true;
            payment.Items.AddRange(new object[] { "Cash", "Credit" });
            payment.Location = new Point(222, 70);
            payment.Name = "payment";
            payment.Size = new Size(200, 26);
            payment.TabIndex = 33;
            // 
            // userd
            // 
            userd.Location = new Point(222, 178);
            userd.Name = "userd";
            userd.Size = new Size(125, 27);
            userd.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 183);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 22);
            label3.TabIndex = 31;
            label3.Text = "User ID";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 30);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // B_T8
            // 
            B_T8.BackColor = Color.FromArgb(41, 128, 185);
            B_T8.FlatStyle = FlatStyle.Flat;
            B_T8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T8.ForeColor = Color.White;
            B_T8.Location = new Point(148, 311);
            B_T8.Margin = new Padding(2);
            B_T8.Name = "B_T8";
            B_T8.Size = new Size(159, 35);
            B_T8.TabIndex = 29;
            B_T8.Text = "22:00-23:00";
            B_T8.UseVisualStyleBackColor = false;
            B_T8.Click += B_T8_Click;
            // 
            // B_T9
            // 
            B_T9.BackColor = Color.FromArgb(41, 128, 185);
            B_T9.FlatStyle = FlatStyle.Flat;
            B_T9.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T9.ForeColor = Color.White;
            B_T9.Location = new Point(311, 311);
            B_T9.Margin = new Padding(2);
            B_T9.Name = "B_T9";
            B_T9.Size = new Size(120, 35);
            B_T9.TabIndex = 28;
            B_T9.Text = "23:00-24:00";
            B_T9.UseVisualStyleBackColor = false;
            B_T9.Click += B_T9_Click;
            // 
            // B_T7
            // 
            B_T7.BackColor = Color.FromArgb(41, 128, 185);
            B_T7.FlatStyle = FlatStyle.Flat;
            B_T7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T7.ForeColor = Color.White;
            B_T7.Location = new Point(24, 311);
            B_T7.Margin = new Padding(2);
            B_T7.Name = "B_T7";
            B_T7.Size = new Size(120, 35);
            B_T7.TabIndex = 27;
            B_T7.Text = "21:00-22:00";
            B_T7.UseVisualStyleBackColor = false;
            B_T7.Click += B_T7_Click;
            // 
            // B_T1
            // 
            B_T1.BackColor = Color.FromArgb(41, 128, 185);
            B_T1.FlatStyle = FlatStyle.Flat;
            B_T1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T1.ForeColor = Color.White;
            B_T1.Location = new Point(24, 233);
            B_T1.Margin = new Padding(2);
            B_T1.Name = "B_T1";
            B_T1.Size = new Size(120, 35);
            B_T1.TabIndex = 26;
            B_T1.Text = "15:00-16:00";
            B_T1.UseVisualStyleBackColor = false;
            B_T1.Click += B_T1_Click;
            // 
            // CB_Trainers
            // 
            CB_Trainers.FlatStyle = FlatStyle.Flat;
            CB_Trainers.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_Trainers.ForeColor = Color.FromArgb(41, 128, 185);
            CB_Trainers.FormattingEnabled = true;
            CB_Trainers.Location = new Point(222, 138);
            CB_Trainers.Name = "CB_Trainers";
            CB_Trainers.Size = new Size(200, 26);
            CB_Trainers.TabIndex = 23;
            CB_Trainers.SelectedIndexChanged += CB_Trainers_SelectedIndexChanged;
            // 
            // L_Trainer
            // 
            L_Trainer.AutoSize = true;
            L_Trainer.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            L_Trainer.Location = new Point(50, 145);
            L_Trainer.Margin = new Padding(2, 0, 2, 0);
            L_Trainer.Name = "L_Trainer";
            L_Trainer.Size = new Size(68, 22);
            L_Trainer.TabIndex = 22;
            L_Trainer.Text = "Trainer";
            // 
            // B_T6
            // 
            B_T6.BackColor = Color.FromArgb(41, 128, 185);
            B_T6.FlatStyle = FlatStyle.Flat;
            B_T6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T6.ForeColor = Color.White;
            B_T6.Location = new Point(311, 272);
            B_T6.Margin = new Padding(2);
            B_T6.Name = "B_T6";
            B_T6.Size = new Size(120, 35);
            B_T6.TabIndex = 21;
            B_T6.Text = "20:00-21:00";
            B_T6.UseVisualStyleBackColor = false;
            B_T6.Click += B_T6_Click;
            // 
            // B_T4
            // 
            B_T4.BackColor = Color.FromArgb(41, 128, 185);
            B_T4.FlatStyle = FlatStyle.Flat;
            B_T4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T4.ForeColor = Color.White;
            B_T4.Location = new Point(24, 272);
            B_T4.Margin = new Padding(2);
            B_T4.Name = "B_T4";
            B_T4.Size = new Size(120, 35);
            B_T4.TabIndex = 20;
            B_T4.Text = "18:00-19:00";
            B_T4.UseVisualStyleBackColor = false;
            B_T4.Click += B_T4_Click;
            // 
            // B_T5
            // 
            B_T5.BackColor = Color.FromArgb(41, 128, 185);
            B_T5.FlatStyle = FlatStyle.Flat;
            B_T5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T5.ForeColor = Color.White;
            B_T5.Location = new Point(148, 272);
            B_T5.Margin = new Padding(2);
            B_T5.Name = "B_T5";
            B_T5.Size = new Size(159, 35);
            B_T5.TabIndex = 19;
            B_T5.Text = "19:00-20:00";
            B_T5.UseVisualStyleBackColor = false;
            B_T5.Click += B_T5_Click;
            // 
            // B_T3
            // 
            B_T3.BackColor = Color.FromArgb(41, 128, 185);
            B_T3.FlatStyle = FlatStyle.Flat;
            B_T3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T3.ForeColor = Color.White;
            B_T3.Location = new Point(311, 233);
            B_T3.Margin = new Padding(2);
            B_T3.Name = "B_T3";
            B_T3.Size = new Size(120, 35);
            B_T3.TabIndex = 18;
            B_T3.Text = "17:00-18:00";
            B_T3.UseVisualStyleBackColor = false;
            B_T3.Click += B_T3_Click;
            // 
            // B_T2
            // 
            B_T2.BackColor = Color.FromArgb(41, 128, 185);
            B_T2.FlatStyle = FlatStyle.Flat;
            B_T2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_T2.ForeColor = Color.White;
            B_T2.Location = new Point(148, 233);
            B_T2.Margin = new Padding(2);
            B_T2.Name = "B_T2";
            B_T2.Size = new Size(159, 35);
            B_T2.TabIndex = 17;
            B_T2.Text = "16:00-17:00";
            B_T2.UseVisualStyleBackColor = false;
            B_T2.Click += B_T2_Click;
            // 
            // CB_SesType
            // 
            CB_SesType.FlatStyle = FlatStyle.Flat;
            CB_SesType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CB_SesType.ForeColor = Color.FromArgb(41, 128, 185);
            CB_SesType.FormattingEnabled = true;
            CB_SesType.Location = new Point(222, 102);
            CB_SesType.Name = "CB_SesType";
            CB_SesType.Size = new Size(200, 26);
            CB_SesType.TabIndex = 13;
            CB_SesType.SelectedIndexChanged += CB_Updator_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 12;
            label1.Text = "Session";
            // 
            // B_Master
            // 
            B_Master.BackColor = Color.FromArgb(41, 128, 185);
            B_Master.FlatStyle = FlatStyle.Flat;
            B_Master.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Master.ForeColor = Color.White;
            B_Master.Location = new Point(212, 367);
            B_Master.Margin = new Padding(2);
            B_Master.Name = "B_Master";
            B_Master.Size = new Size(219, 35);
            B_Master.TabIndex = 7;
            B_Master.Text = "Confirm Registeration";
            B_Master.UseVisualStyleBackColor = false;
            B_Master.Click += Userr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(126, 27);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 2;
            label2.Text = "Registeration";
            label2.Click += label2_Click;
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
            // RecReg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
            ControlBox = false;
            Controls.Add(userid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "RecReg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            userid.ResumeLayout(false);
            userid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel userid;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Button B_Master;
        private ComboBox CB_SesType;
        private Label label1;
        private ComboBox CB_Trainers;
        private Label L_Trainer;
        private Button B_T6;
        private Button B_T4;
        private Button B_T5;
        private Button B_T3;
        private Button B_T2;
        private Button B_T1;
        private Button B_T8;
        private Button B_T9;
        private Button B_T7;
        private PictureBox pictureBox4;
        private TextBox userd;
        private Label label3;
        private Label label4;
        private ComboBox payment;
        private ComboBox comboBox1;
        private Label label5;
    }
}
