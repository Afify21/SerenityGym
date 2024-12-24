namespace SerenityGym
{
    partial class User
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
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            B_Tracker = new Button();
            B_Notifications = new Button();
            B_transaction = new Button();
            B_Registeration = new Button();
            B_Feedback = new Button();
            Userr = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 530);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(14, 206);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(44, 55);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 136);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 39);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // panel2
            // 
            panel2.Controls.Add(B_Tracker);
            panel2.Controls.Add(B_Notifications);
            panel2.Controls.Add(B_transaction);
            panel2.Controls.Add(B_Registeration);
            panel2.Controls.Add(B_Feedback);
            panel2.Controls.Add(Userr);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(145, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 530);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // B_Tracker
            // 
            B_Tracker.BackColor = Color.FromArgb(41, 128, 185);
            B_Tracker.FlatStyle = FlatStyle.Flat;
            B_Tracker.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Tracker.ForeColor = Color.White;
            B_Tracker.Location = new Point(84, 136);
            B_Tracker.Margin = new Padding(2);
            B_Tracker.Name = "B_Tracker";
            B_Tracker.Size = new Size(368, 41);
            B_Tracker.TabIndex = 12;
            B_Tracker.Text = "Tracker";
            B_Tracker.UseVisualStyleBackColor = false;
            // 
            // B_Notifications
            // 
            B_Notifications.BackColor = Color.FromArgb(41, 128, 185);
            B_Notifications.FlatStyle = FlatStyle.Flat;
            B_Notifications.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Notifications.ForeColor = Color.White;
            B_Notifications.Location = new Point(84, 286);
            B_Notifications.Margin = new Padding(2);
            B_Notifications.Name = "B_Notifications";
            B_Notifications.Size = new Size(368, 41);
            B_Notifications.TabIndex = 11;
            B_Notifications.Text = "Notifications";
            B_Notifications.UseVisualStyleBackColor = false;
            B_Notifications.Click += B_Notifications_Click;
            // 
            // B_transaction
            // 
            B_transaction.BackColor = Color.FromArgb(41, 128, 185);
            B_transaction.FlatStyle = FlatStyle.Flat;
            B_transaction.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_transaction.ForeColor = Color.White;
            B_transaction.Location = new Point(84, 55);
            B_transaction.Margin = new Padding(2);
            B_transaction.Name = "B_transaction";
            B_transaction.Size = new Size(368, 41);
            B_transaction.TabIndex = 10;
            B_transaction.Text = "Transaction History";
            B_transaction.UseVisualStyleBackColor = false;
            // 
            // B_Registeration
            // 
            B_Registeration.BackColor = Color.FromArgb(41, 128, 185);
            B_Registeration.FlatStyle = FlatStyle.Flat;
            B_Registeration.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Registeration.ForeColor = Color.White;
            B_Registeration.Location = new Point(84, 206);
            B_Registeration.Margin = new Padding(2);
            B_Registeration.Name = "B_Registeration";
            B_Registeration.Size = new Size(368, 41);
            B_Registeration.TabIndex = 9;
            B_Registeration.Text = "Registeration";
            B_Registeration.UseVisualStyleBackColor = false;
            // 
            // B_Feedback
            // 
            B_Feedback.BackColor = Color.FromArgb(41, 128, 185);
            B_Feedback.FlatStyle = FlatStyle.Flat;
            B_Feedback.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Feedback.ForeColor = Color.White;
            B_Feedback.Location = new Point(84, 366);
            B_Feedback.Margin = new Padding(2);
            B_Feedback.Name = "B_Feedback";
            B_Feedback.Size = new Size(368, 35);
            B_Feedback.TabIndex = 8;
            B_Feedback.Text = "Submit Feedback";
            B_Feedback.UseVisualStyleBackColor = false;
            B_Feedback.Click += Stafff_Click;
            // 
            // Userr
            // 
            Userr.BackColor = Color.FromArgb(41, 128, 185);
            Userr.FlatStyle = FlatStyle.Flat;
            Userr.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userr.ForeColor = Color.White;
            Userr.Location = new Point(84, 442);
            Userr.Margin = new Padding(2);
            Userr.Name = "Userr";
            Userr.Size = new Size(368, 41);
            Userr.TabIndex = 7;
            Userr.Text = "Update Personal Information";
            Userr.UseVisualStyleBackColor = false;
            Userr.Click += Userr_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(41, 128, 185);
            button1.Location = new Point(565, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(40, 40);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button B_Feedback;
        private Button Userr;
        private Button B_Notifications;
        private Button B_transaction;
        private Button B_Registeration;
        private Button B_Tracker;
    }
}
