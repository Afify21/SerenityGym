using DBapplication;
using System.Data;

namespace SerenityGym
{
    public partial class UpdatePlans : Form
    {
        int TID;
        int UID;
        Controller controllerObj;

        public UpdatePlans(int id)
        {
            TID = id;
            InitializeComponent();
            controllerObj = new Controller();
            trainplan.Visible = false;
            TrainSplit.Visible = false;
            dietplan.Visible = false;
            FoodSplit.Visible = false;
            name.Visible = false;
            TrainCheckBox.Visible = false;
            DietCheckBox.Visible = false;
            DataTable staffTable = controllerObj.PopulateUserComboBox(TID);
            comboBox1.Items.Clear();
            foreach (DataRow row in staffTable.Rows)
            {
                string fullName = $"{row["fname"]} {row["lname"]}";
                comboBox1.Items.Add(fullName);
            }

        }
        public UpdatePlans(int tid, int uid)
        {
            TID = tid;
            UID = uid;
            InitializeComponent();
            controllerObj = new Controller();
            trainplan.Visible = false;
            TrainSplit.Visible = false;
            dietplan.Visible = false;
            FoodSplit.Visible = false;
            name.Visible = false;

            TrainCheckBox.Visible = false;
            DietCheckBox.Visible = false;
            DataTable staffTable = controllerObj.PopulateUserComboBox(TID);
            comboBox1.Items.Clear();
            foreach (DataRow row in staffTable.Rows)
            {
                string fullName = $"{row["fname"]} {row["lname"]}";
                comboBox1.Items.Add(fullName);
            }
            string Fullname = controllerObj.GetUserName(UID);
            comboBox1.SelectedItem = Fullname;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainCheckBox.Checked)
            {


                trainplan.Visible = true;
                TrainSplit.Visible = true;



            }
            else
            {
                trainplan.Visible = false;
                TrainSplit.Visible = false;
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(Userid.Text))
            //{
            //    MessageBox.Show("Please Enter A User ID");
            //    return;
            //}

            //if (!int.TryParse(Userid.Text, out int UID))
            //{
            //    MessageBox.Show("User ID must be a numeric value");
            //    return;
            //}
            //UID = Convert.ToInt32(Userid.Text);

            //if (!controllerObj.isUser(UID))
            //{
            //    MessageBox.Show("Enter a Vald User");
            //    return;
            //}
            //if (!controllerObj.IsTrainedByTrainer(UID, TID))
            //{
            //    MessageBox.Show("Please Enter A User You Train");
            //    return;

            //}
            if (comboBox1.SelectedIndex != -1) // Ensure an item is selected
            {
                // Extract the selected name
                string selectedName = comboBox1.SelectedItem.ToString();
                string[] nameParts = selectedName.Split(' ');

                // Assuming valid username, extract first and last names
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                // Get the User ID
                int UID = controllerObj.GetUserID(firstName, lastName);

                // Show UI elements and user details
                TrainCheckBox.Visible = true;
                DietCheckBox.Visible = true;
                name.Visible = true;
                name.Text = controllerObj.ShowName(UID);
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }

        }

        private void DietCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DietCheckBox.Checked)
            {

                dietplan.Visible = true;
                FoodSplit.Visible = true;

            }
            else
            {
                dietplan.Visible = false;
                FoodSplit.Visible = false;
            }
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (TrainSplit.SelectedIndex != -1 || FoodSplit.SelectedIndex != -1)
            {
                string selectedName = comboBox1.SelectedItem.ToString();
                string[] nameParts = selectedName.Split(' ');

                // Assuming valid username, extract first and last names
                string firstName = nameParts[0];
                string lastName = nameParts[1];

                // Get the User ID
                int UID = controllerObj.GetUserID(firstName, lastName);
                int result = controllerObj.UpdateTSplit(TrainSplit.Text, UID);
                int result2 = controllerObj.UpdateFSplit(FoodSplit.Text, UID);
                int result = controllerObj.UpdateTSplit(TrainSplit.Text, UID);
                int result2 = controllerObj.UpdateFSplit(TrainSplit.Text, UID);
                MessageBox.Show("Updated Successfully!");
                return;
            }
            MessageBox.Show("Update Failed!");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dietplan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void TrainSplit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrainSplit.Text = string.Empty;
            FoodSplit.Text = string.Empty;

            TrainSplit.SelectedIndex = -1;
            FoodSplit.SelectedIndex = -1;

        }

        private void TrainSplit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
