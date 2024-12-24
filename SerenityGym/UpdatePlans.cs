using DBapplication;

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
            TrainCheckBox.Visible = false;
            DietCheckBox.Visible = false;

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


                //int result = controllerObj.UpdatePlan("Training", TID, UID);
                //if (result == 0)
                //    MessageBox.Show("Update Failed!");
                //else
                //    MessageBox.Show("Updated Successfully!");
            }
            else
            {
                trainplan.Visible = false;
                TrainSplit.Visible = false;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (Userid.Text == "")
            {
                MessageBox.Show("Please Enter A User ID");
            }
            TrainCheckBox.Visible = true;
            DietCheckBox.Visible = true;
            UID = Convert.ToInt32(Userid.Text);
            name.Text = controllerObj.ShowName(UID);
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
