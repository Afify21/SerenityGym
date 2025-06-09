using DBapplication;
using System.Data;
using System.Xml.Linq;

namespace SerenityGym
{
    public partial class ViewMemberProgress : Form
    {
        int TID;
        int UID;
        Controller controllerObj;
        public ViewMemberProgress(int id)
        {
            TID = id;
            InitializeComponent();
            controllerObj = new Controller();
            dataGridView1.Visible = false;
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

                dataGridView1.Visible = true;
                DataTable dt = controllerObj.ViewMemberProgress(TID, UID);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Userr_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            DataTable dt = controllerObj.ViewAllMemberProgress(TID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Userr_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            DataTable dt = controllerObj.ViewAllMemberProgress(TID);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
