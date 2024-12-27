using DBapplication;
using System.Data;
using System.Xml.Linq;

namespace SerenityGym
{
    public partial class AddProgress : Form
    {
        int TID;
        int UID;
        Controller controllerObj;
        public AddProgress(int id)
        {
            TID = id;
            InitializeComponent();
            controllerObj = new Controller();
            name.Visible = false;

            DataTable staffTable = controllerObj.PopulateUserComboBox(TID);
            comboBox1.Items.Clear();
            foreach (DataRow row in staffTable.Rows)
            {
                string fullName = $"{row["fname"]} {row["lname"]}";
                comboBox1.Items.Add(fullName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Userr_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A User Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Please choose progress.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a goal.");
                return;
            }
            string selectedName = comboBox1.SelectedItem.ToString();
            string[] nameParts = selectedName.Split(' ');

            // Assuming valid username, extract first and last names
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            // Get the User ID

            int UID = controllerObj.GetUserID(firstName, lastName);
            int planid = controllerObj.GetPlanID(UID);


            int result = controllerObj.AddProgress(planid,UID,TID, Convert.ToInt16(comboBox2.Text), textBox1.Text);
            if(result == 0) {
                MessageBox.Show("Insert Failed");
                return;
                    }
            else
            {
                MessageBox.Show("Added Successfully");
                return;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                //TrainCheckBox.Visible = true;
                //DietCheckBox.Visible = true;
                name.Visible = true;
                name.Text = controllerObj.ShowName(UID);
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }
    }
}
