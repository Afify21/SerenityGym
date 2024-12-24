namespace SerenityGym
{
    partial class UpdatePlans
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
            dietplan = new Label();
            trainplan = new Label();
            FoodSplit = new ComboBox();
            TrainSplit = new ComboBox();
            name = new Label();
            label3 = new Label();
            Userid = new TextBox();
            DietCheckBox = new CheckBox();
            TrainCheckBox = new CheckBox();
            Stafff = new Button();
            submit = new Button();
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
            panel2.Controls.Add(dietplan);
            panel2.Controls.Add(trainplan);
            panel2.Controls.Add(FoodSplit);
            panel2.Controls.Add(TrainSplit);
            panel2.Controls.Add(name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(Userid);
            panel2.Controls.Add(DietCheckBox);
            panel2.Controls.Add(TrainCheckBox);
            panel2.Controls.Add(Stafff);
            panel2.Controls.Add(submit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(140, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 530);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dietplan
            // 
            dietplan.AutoSize = true;
            dietplan.Location = new Point(438, 236);
            dietplan.Name = "dietplan";
            dietplan.Size = new Size(82, 25);
            dietplan.TabIndex = 17;
            dietplan.Text = "Diet Plan";
            // 
            // trainplan
            // 
            trainplan.AutoSize = true;
            trainplan.Location = new Point(241, 236);
            trainplan.Name = "trainplan";
            trainplan.Size = new Size(111, 25);
            trainplan.TabIndex = 16;
            trainplan.Text = "Training Plan";
            // 
            // FoodSplit
            // 
            FoodSplit.FormattingEnabled = true;
            FoodSplit.Items.AddRange(new object[] { "Low-Carb", "High-Carb", "Keto", "PSMF" });
            FoodSplit.Location = new Point(428, 293);
            FoodSplit.Name = "FoodSplit";
            FoodSplit.Size = new Size(118, 33);
            FoodSplit.TabIndex = 15;
            // 
            // TrainSplit
            // 
            TrainSplit.FormattingEnabled = true;
            TrainSplit.Items.AddRange(new object[] { "Arnold", "General", "Upper-Lower", "Push-Pull Leg" });
            TrainSplit.Location = new Point(234, 293);
            TrainSplit.Name = "TrainSplit";
            TrainSplit.Size = new Size(118, 33);
            TrainSplit.TabIndex = 14;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(93, 184);
            name.Name = "name";
            name.Size = new Size(59, 25);
            name.TabIndex = 13;
            name.Text = "Name";
            name.Click += name_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 128);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 12;
            label3.Text = "USER ID";
            // 
            // Userid
            // 
            Userid.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Userid.ForeColor = Color.FromArgb(41, 128, 185);
            Userid.Location = new Point(151, 121);
            Userid.Margin = new Padding(2);
            Userid.Name = "Userid";
            Userid.Size = new Size(118, 32);
            Userid.TabIndex = 11;
            // 
            // DietCheckBox
            // 
            DietCheckBox.AutoSize = true;
            DietCheckBox.BackColor = SystemColors.Control;
            DietCheckBox.FlatAppearance.BorderSize = 0;
            DietCheckBox.ForeColor = Color.FromArgb(41, 128, 185);
            DietCheckBox.Location = new Point(438, 180);
            DietCheckBox.Name = "DietCheckBox";
            DietCheckBox.Size = new Size(108, 29);
            DietCheckBox.TabIndex = 10;
            DietCheckBox.Text = "Diet Plan";
            DietCheckBox.UseVisualStyleBackColor = false;
            DietCheckBox.CheckedChanged += DietCheckBox_CheckedChanged;
            // 
            // TrainCheckBox
            // 
            TrainCheckBox.AutoSize = true;
            TrainCheckBox.BackColor = SystemColors.Control;
            TrainCheckBox.FlatAppearance.BorderSize = 0;
            TrainCheckBox.ForeColor = Color.FromArgb(41, 128, 185);
            TrainCheckBox.Location = new Point(241, 180);
            TrainCheckBox.Name = "TrainCheckBox";
            TrainCheckBox.Size = new Size(137, 29);
            TrainCheckBox.TabIndex = 9;
            TrainCheckBox.Text = "Training Plan";
            TrainCheckBox.UseVisualStyleBackColor = false;
            TrainCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Stafff
            // 
            Stafff.BackColor = Color.FromArgb(41, 128, 185);
            Stafff.FlatStyle = FlatStyle.Flat;
            Stafff.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stafff.ForeColor = Color.White;
            Stafff.Location = new Point(462, 495);
            Stafff.Margin = new Padding(2);
            Stafff.Name = "Stafff";
            Stafff.Size = new Size(148, 35);
            Stafff.TabIndex = 8;
            Stafff.Text = "STAFF";
            Stafff.UseVisualStyleBackColor = false;
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(41, 128, 185);
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit.ForeColor = Color.White;
            submit.Location = new Point(340, 121);
            submit.Margin = new Padding(2);
            submit.Name = "submit";
            submit.Size = new Size(148, 35);
            submit.TabIndex = 7;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(41, 128, 185);
            label2.Location = new Point(30, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 39);
            label2.TabIndex = 2;
            label2.Text = "Update Plans";
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
            // UpdatePlans
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "UpdatePlans";
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
        private Button Stafff;
        private Button submit;
        private CheckBox TrainCheckBox;
        private CheckBox DietCheckBox;
        private TextBox Userid;
        private Label label3;
        private Label name;
        private ComboBox FoodSplit;
        private ComboBox TrainSplit;
        private Label dietplan;
        private Label trainplan;
    }
}
