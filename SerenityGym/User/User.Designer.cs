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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            B_Cancel = new Button();
            button7 = new Button();
            pictureBox4 = new PictureBox();
            B_Tracker = new Button();
            B_Notifications = new Button();
            B_Registeration = new Button();
            B_Feedback = new Button();
            Userr = new Button();
            button1 = new Button();
            B_MyD = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Size = new Size(116, 424);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sports_Dumbbell_icon;
            pictureBox1.Location = new Point(11, 165);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User;
            pictureBox2.Location = new Point(28, 35);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 33);
            label2.TabIndex = 2;
            label2.Text = "User";
            // 
            // panel2
            // 
            panel2.Controls.Add(B_MyD);
            panel2.Controls.Add(B_Cancel);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(B_Tracker);
            panel2.Controls.Add(B_Notifications);
            panel2.Controls.Add(B_Registeration);
            panel2.Controls.Add(B_Feedback);
            panel2.Controls.Add(Userr);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(116, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 424);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // B_Cancel
            // 
            B_Cancel.BackColor = Color.FromArgb(41, 128, 185);
            B_Cancel.FlatStyle = FlatStyle.Flat;
            B_Cancel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Cancel.ForeColor = Color.White;
            B_Cancel.Location = new Point(67, 189);
            B_Cancel.Margin = new Padding(2);
            B_Cancel.Name = "B_Cancel";
            B_Cancel.Size = new Size(351, 36);
            B_Cancel.TabIndex = 21;
            B_Cancel.Text = "Cancel Registeration";
            B_Cancel.UseVisualStyleBackColor = false;
            B_Cancel.Click += B_Cancel_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 128, 185);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 391);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(101, 33);
            button7.TabIndex = 20;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(2, 2);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 30);
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // B_Tracker
            // 
            B_Tracker.BackColor = Color.FromArgb(41, 128, 185);
            B_Tracker.FlatStyle = FlatStyle.Flat;
            B_Tracker.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Tracker.ForeColor = Color.White;
            B_Tracker.Location = new Point(67, 35);
            B_Tracker.Margin = new Padding(2);
            B_Tracker.Name = "B_Tracker";
            B_Tracker.Size = new Size(351, 33);
            B_Tracker.TabIndex = 12;
            B_Tracker.Text = "Tracker";
            B_Tracker.UseVisualStyleBackColor = false;
            B_Tracker.Click += B_Tracker_Click;
            // 
            // B_Notifications
            // 
            B_Notifications.BackColor = Color.FromArgb(41, 128, 185);
            B_Notifications.FlatStyle = FlatStyle.Flat;
            B_Notifications.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Notifications.ForeColor = Color.White;
            B_Notifications.Location = new Point(67, 242);
            B_Notifications.Margin = new Padding(2);
            B_Notifications.Name = "B_Notifications";
            B_Notifications.Size = new Size(351, 33);
            B_Notifications.TabIndex = 11;
            B_Notifications.Text = "Notifications";
            B_Notifications.UseVisualStyleBackColor = false;
            B_Notifications.Click += B_Notifications_Click;
            // 
            // B_Registeration
            // 
            B_Registeration.BackColor = Color.FromArgb(41, 128, 185);
            B_Registeration.FlatStyle = FlatStyle.Flat;
            B_Registeration.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Registeration.ForeColor = Color.White;
            B_Registeration.Location = new Point(67, 90);
            B_Registeration.Margin = new Padding(2);
            B_Registeration.Name = "B_Registeration";
            B_Registeration.Size = new Size(351, 36);
            B_Registeration.TabIndex = 9;
            B_Registeration.Text = "New Registeration";
            B_Registeration.UseVisualStyleBackColor = false;
            B_Registeration.Click += B_Registeration_Click;
            // 
            // B_Feedback
            // 
            B_Feedback.BackColor = Color.FromArgb(41, 128, 185);
            B_Feedback.FlatStyle = FlatStyle.Flat;
            B_Feedback.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_Feedback.ForeColor = Color.White;
            B_Feedback.Location = new Point(67, 293);
            B_Feedback.Margin = new Padding(2);
            B_Feedback.Name = "B_Feedback";
            B_Feedback.Size = new Size(351, 34);
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
            Userr.Location = new Point(67, 346);
            Userr.Margin = new Padding(2);
            Userr.Name = "Userr";
            Userr.Size = new Size(351, 33);
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
            button1.Location = new Point(452, 0);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(32, 32);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // B_MyD
            // 
            B_MyD.BackColor = Color.FromArgb(41, 128, 185);
            B_MyD.FlatStyle = FlatStyle.Flat;
            B_MyD.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            B_MyD.ForeColor = Color.White;
            B_MyD.Location = new Point(67, 144);
            B_MyD.Margin = new Padding(2);
            B_MyD.Name = "B_MyD";
            B_MyD.Size = new Size(351, 28);
            B_MyD.TabIndex = 22;
            B_MyD.Text = "My Details";
            B_MyD.UseVisualStyleBackColor = false;
            B_MyD.Click += B_MyD_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Button B_Registeration;
        private Button B_Tracker;
        private PictureBox pictureBox4;
        private Button button7;
        private Button B_Cancel;
        private Button B_MyD;
    }
}
