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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePlans));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            comboBox1 = new ComboBox();
            pictureBox4 = new PictureBox();
            dietplan = new Label();
            trainplan = new Label();
            FoodSplit = new ComboBox();
            TrainSplit = new ComboBox();
            name = new Label();
            label3 = new Label();
            DietCheckBox = new CheckBox();
            TrainCheckBox = new CheckBox();
            update = new Button();
            submit = new Button();
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
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(dietplan);
            panel2.Controls.Add(trainplan);
            panel2.Controls.Add(FoodSplit);
            panel2.Controls.Add(TrainSplit);
            panel2.Controls.Add(name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(DietCheckBox);
            panel2.Controls.Add(TrainCheckBox);
            panel2.Controls.Add(update);
            panel2.Controls.Add(submit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(112, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 424);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 100);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 28);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            // dietplan
            // 
            dietplan.AutoSize = true;
            dietplan.Location = new Point(295, 244);
            dietplan.Margin = new Padding(2, 0, 2, 0);
            dietplan.Name = "dietplan";
            dietplan.Size = new Size(69, 20);
            dietplan.TabIndex = 17;
            dietplan.Text = "Diet Plan";
            dietplan.Click += dietplan_Click;
            // 
            // trainplan
            // 
            trainplan.AutoSize = true;
            trainplan.Location = new Point(102, 244);
            trainplan.Margin = new Padding(2, 0, 2, 0);
            trainplan.Name = "trainplan";
            trainplan.Size = new Size(94, 20);
            trainplan.TabIndex = 16;
            trainplan.Text = "Training Plan";
            // 
            // FoodSplit
            // 
            FoodSplit.FormattingEnabled = true;
            FoodSplit.Items.AddRange(new object[] { "Low-Carb", "High-Carb", "Keto", "PSMF" });
            FoodSplit.Location = new Point(283, 295);
            FoodSplit.Margin = new Padding(2);
            FoodSplit.Name = "FoodSplit";
            FoodSplit.Size = new Size(95, 28);
            FoodSplit.TabIndex = 15;
            // 
            // TrainSplit
            // 
            TrainSplit.FormattingEnabled = true;
            TrainSplit.Items.AddRange(new object[] { "Arnold", "General", "Upper-Lower", "Push-Pull-Leg" });
            TrainSplit.Location = new Point(102, 295);
            TrainSplit.Margin = new Padding(2);
            TrainSplit.Name = "TrainSplit";
            TrainSplit.Size = new Size(95, 28);
            TrainSplit.TabIndex = 14;
            TrainSplit.SelectedIndexChanged += TrainSplit_SelectedIndexChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(77, 180);
            name.Margin = new Padding(2, 0, 2, 0);
            name.Name = "name";
            name.Size = new Size(49, 20);
            name.TabIndex = 13;
            name.Text = "Name";
            name.Click += name_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 102);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 21);
            label3.TabIndex = 12;
            label3.Text = "USER Name";
            label3.Click += label3_Click;
            // 
            // DietCheckBox
            // 
            DietCheckBox.AutoSize = true;
            DietCheckBox.BackColor = SystemColors.Control;
            DietCheckBox.FlatAppearance.BorderSize = 0;
            DietCheckBox.ForeColor = Color.FromArgb(41, 128, 185);
            DietCheckBox.Location = new Point(342, 180);
            DietCheckBox.Margin = new Padding(2);
            DietCheckBox.Name = "DietCheckBox";
            DietCheckBox.Size = new Size(91, 24);
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
            TrainCheckBox.Location = new Point(185, 180);
            TrainCheckBox.Margin = new Padding(2);
            TrainCheckBox.Name = "TrainCheckBox";
            TrainCheckBox.Size = new Size(116, 24);
            TrainCheckBox.TabIndex = 9;
            TrainCheckBox.Text = "Training Plan";
            TrainCheckBox.UseVisualStyleBackColor = false;
            TrainCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(41, 128, 185);
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            update.ForeColor = Color.White;
            update.Location = new Point(319, 352);
            update.Margin = new Padding(2);
            update.Name = "update";
            update.Size = new Size(118, 28);
            update.TabIndex = 8;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(41, 128, 185);
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit.ForeColor = Color.White;
            submit.Location = new Point(342, 102);
            submit.Margin = new Padding(2);
            submit.Name = "submit";
            submit.Size = new Size(118, 28);
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
            label2.Location = new Point(24, 42);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 33);
            label2.TabIndex = 2;
            label2.Text = "Update Plans";
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
            // UpdatePlans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 424);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Button update;
        private Button submit;
        private CheckBox TrainCheckBox;
        private CheckBox DietCheckBox;
        private Label label3;
        private Label name;
        private ComboBox FoodSplit;
        private ComboBox TrainSplit;
        private Label dietplan;
        private Label trainplan;
        private PictureBox pictureBox4;
        private ComboBox comboBox1;
    }
}
