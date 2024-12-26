using DBapplication;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SerenityGym
{
    public partial class Statistics_table : Form
    {
        Controller controllerObj;
        public Statistics_table()
        {
            InitializeComponent();
            controllerObj = new Controller();
            star1.Visible = false;
            star2.Visible = false;
            star3.Visible = false;
            star4.Visible = false;
            star5.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            DataTable staffTable = controllerObj.PopulateComboBox();
            CB_Updator.Items.Clear();
            foreach (DataRow row in staffTable.Rows)
            {
                CB_Updator.Items.Add(row["staffid"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            int profit = controllerObj.ShowProfit();
            label2.Text = profit.ToString();
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Stafff_Click(object sender, EventArgs e)
        {
            // Get the total count of moods and count of "Positive" moods
            // Get the total count of moods and count of "Positive" moods
            int totalMoods = controllerObj.GetTotalMoodsCount(); // Replace with the actual method to fetch the total mood count
            int positiveMoods = controllerObj.GetPositiveMoodsCount(); // Replace with the actual method to fetch positive mood count

            if (totalMoods == 0)
            {
                MessageBox.Show("No mood data available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Calculate the percentage of positive moods
            double positivePercentage = ((double)positiveMoods / totalMoods) * 100;

            // Determine which PictureBox to display and update the rating in the Label
            label3.Visible = true; // Ensure label3 is visible in all conditions
            if (positivePercentage >= 0 && positivePercentage <= 20)
            {
                star1.Visible = true;
                star2.Visible = star3.Visible = star4.Visible = star5.Visible = false;
                label3.Text = "Rating: 1/5";
            }
            else if (positivePercentage > 20 && positivePercentage <= 40)
            {
                star2.Visible = true;
                star1.Visible = star3.Visible = star4.Visible = star5.Visible = false;
                label3.Text = "Rating: 2/5";
            }
            else if (positivePercentage > 40 && positivePercentage <= 60)
            {
                star3.Visible = true;
                star1.Visible = star2.Visible = star4.Visible = star5.Visible = false;
                label3.Text = "Rating: 3/5";
            }
            else if (positivePercentage > 60 && positivePercentage <= 80)
            {
                star4.Visible = true;
                star1.Visible = star2.Visible = star3.Visible = star5.Visible = false;
                label3.Text = "Rating: 4/5";
            }
            else if (positivePercentage > 80 && positivePercentage <= 100)
            {
                star5.Visible = true;
                star1.Visible = star2.Visible = star3.Visible = star4.Visible = false;
                label3.Text = "Rating: 5/5";
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Feedbacktable();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected staff id
            string selectedStaffId = CB_Updator.SelectedItem.ToString();

            // Fetch the count of user ids trained by the selected staff
            int userCount = controllerObj.Gettraineebyid(selectedStaffId);
            label6.Text = userCount.ToString(); 
            label6.Visible  = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

      

