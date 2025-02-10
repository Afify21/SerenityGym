using DBapplication;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace SerenityGym
{
    public partial class InsertPlans : Form
    {
        int TID;
        int UID;
        Controller controllerObj;

        public InsertPlans(int id)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void submit_Click(object sender, EventArgs e)
        {

           
            if (string.IsNullOrWhiteSpace(Userid.Text))
            {
                MessageBox.Show("Please Enter A User ID");
                return;
            }

            if (!int.TryParse(Userid.Text, out int UID))
            {
                MessageBox.Show("User ID must be a numeric value");
                return;
            }
            UID = Convert.ToInt32(Userid.Text);

            if (!controllerObj.isUser(UID))
            {
                MessageBox.Show("Enter a Vald User");
                return;
            }
            if (!controllerObj.hasPlan(UID))
            {
                TrainCheckBox.Visible = true;
                DietCheckBox.Visible = true;
                name.Visible = true;
                name.Text = controllerObj.ShowName(UID);
                return;
            }

                if (!controllerObj.IsTrainedByTrainer(UID, TID))
            {
                MessageBox.Show("Please Enter A User You Train");
                return;

            }
            if (controllerObj.hasPlan(UID))
            {
                if (MessageBox.Show("User already has a plan! Do you want to update?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdatePlans update = new UpdatePlans(TID, UID);
                    update.Show();
                    return;
                }
            }
            













        }









        private void update_Click(object sender, EventArgs e)
        {
            UID = Convert.ToInt32(Userid.Text);

            if (controllerObj.hasPlan(UID))
            {
                if (MessageBox.Show("User already has a plan! Do you want to update?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdatePlans update = new UpdatePlans(TID, UID);
                    update.Show();
                    return;
                }
                return;
            }
            if (TrainCheckBox.Checked && DietCheckBox.Checked && TrainSplit.SelectedIndex!=-1 && FoodSplit.SelectedIndex != -1)
            {
                int result = controllerObj.AddTrainingPlan(UID, TID, "Training", TrainSplit.Text);
                int result2 = controllerObj.AddDietPlan(UID, TID, "Food", FoodSplit.Text);
                    MessageBox.Show("Inserted Successfully!");
                return;
            }
            MessageBox.Show("Insert Failed!");

        }

        private void TrainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TrainCheckBox.Checked)
            {


                trainplan.Visible = true;
                TrainSplit.Visible = true;



                //string result = controllerObj.AddTrainingPlan(UID,TID);
                //trainplan.Text = result;
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



                //string result = controllerObj.AddTrainingPlan(UID,TID);
                //trainplan.Text = result;
            }
            else
            {
                dietplan.Visible = false;
                FoodSplit.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
