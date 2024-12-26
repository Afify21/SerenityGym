using DBapplication;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace SerenityGym
{
    public partial class RecReg : Form
    {
        int UID;
        int RID;
        Controller controllerObj;

        public RecReg(int x,int y)
        {

            UID = x;
            RID = y;
            InitializeComponent();
            controllerObj = new Controller();
            CB_SesType.Items.AddRange(new string[] { "Padel", "Private", "Membership" });
            CB_Trainers.Items.AddRange(controllerObj.getTrainersARR());

            CB_Trainers.Visible = false;
            L_Trainer.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            B_T1.Visible = false;
            B_T2.Visible = false;
            B_T3.Visible = false;
            B_T4.Visible = false;
            B_T5.Visible = false;
            B_T6.Visible = false;
            B_T7.Visible = false;
            B_T8.Visible = false;
            B_T9.Visible = false;
            B_Master.Visible = true;
            comboBox1.DataSource = controllerObj.GetMemberships();
            comboBox1.DisplayMember = "membership_type";
            comboBox1.ValueMember = "membership_type";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CB_Updator_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = CB_SesType.Text;
            if (type == "Private")
            {
                CB_Trainers.Visible = true;
                L_Trainer.Visible = true;

            }
            if(type=="Membership")
            {
                label5.Visible = true;
                comboBox1.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CB_Trainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Trainers.SelectedIndex == -1)
                return;
            else
            {
                B_T1.Visible = true;
                B_T2.Visible = true;
                B_T3.Visible = true;
                B_T4.Visible = true;
                B_T5.Visible = true;
                B_T6.Visible = true;
                B_T7.Visible = true;
                B_T8.Visible = true;
                B_T9.Visible = true;
            }
            string FULL = CB_Trainers.Text;
            int tid = controllerObj.getTrainerIDByFull(CB_Trainers.Text);
            DataTable result = controllerObj.GetDatesFORREG(tid);


            B_T1.Enabled = true;
            B_T1.ForeColor = Color.White;
            B_T1.BackColor = Color.FromArgb(41, 128, 185);

            B_T2.Enabled = true;
            B_T2.ForeColor = Color.White;
            B_T2.BackColor = Color.FromArgb(41, 128, 185);

            B_T3.Enabled = true;
            B_T3.ForeColor = Color.White;
            B_T3.BackColor = Color.FromArgb(41, 128, 185);

            B_T4.Enabled = true;
            B_T4.ForeColor = Color.White;
            B_T4.BackColor = Color.FromArgb(41, 128, 185);

            B_T5.Enabled = true;
            B_T5.ForeColor = Color.White;
            B_T5.BackColor = Color.FromArgb(41, 128, 185);

            B_T6.Enabled = true;
            B_T6.ForeColor = Color.White;
            B_T6.BackColor = Color.FromArgb(41, 128, 185);

            B_T7.Enabled = true;
            B_T7.ForeColor = Color.White;
            B_T7.BackColor = Color.FromArgb(41, 128, 185);

            B_T8.Enabled = true;
            B_T8.ForeColor = Color.White;
            B_T8.BackColor = Color.FromArgb(41, 128, 185);

            B_T9.Enabled = true;
            B_T9.ForeColor = Color.White;
            B_T9.BackColor = Color.FromArgb(41, 128, 185);

            if (result == null)
                return;
            int RowsR = result.Rows.Count;

            for (int j = 0; j < RowsR; j++)
            {
                if ((B_T1.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T1.Enabled = false;
                    B_T1.ForeColor = Color.Black;
                    B_T1.BackColor = Color.Red;



                }
                if ((B_T2.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T2.Enabled = false;
                    B_T2.ForeColor = Color.Black;
                    B_T2.BackColor = Color.Red;
                }
                if ((B_T3.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T3.Enabled = false;
                    B_T3.ForeColor = Color.Black;
                    B_T3.BackColor = Color.Red;
                }
                if ((B_T4.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T4.Enabled = false;
                    B_T4.ForeColor = Color.Black;
                    B_T4.BackColor = Color.Red;

                }

                if ((B_T5.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T5.Enabled = false;
                    B_T5.ForeColor = Color.Black;
                    B_T5.BackColor = Color.Red;
                }
                if ((B_T6.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T6.Enabled = false;
                    B_T6.ForeColor = Color.Black;
                    B_T6.BackColor = Color.Red;
                }
                if ((B_T7.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T7.Enabled = false;
                    B_T7.ForeColor = Color.Black;
                    B_T7.BackColor = Color.Red;
                }
                if ((B_T8.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T8.Enabled = false;
                    B_T8.ForeColor = Color.Black;
                    B_T8.BackColor = Color.Red;
                }
                if ((B_T9.Text.Substring(0, 5) + ":00") == result.Rows[j]["starthour"].ToString())
                {
                    B_T9.Enabled = false;
                    B_T9.ForeColor = Color.Black;
                    B_T9.BackColor = Color.Red;
                }
            }
        }

        private void Userr_Click(object sender, EventArgs e)
        {
            int HourInteger=0;
            if (CB_SesType.Text == "Private")
            {
                if (B_T1.BackColor == Color.FromArgb(41, 128, 185) && B_T1.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T1.Text.Substring(0, 2));
                }
                if (B_T2.BackColor == Color.FromArgb(41, 128, 185) && B_T2.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T2.Text.Substring(0, 2));
                }
                if (B_T3.BackColor == Color.FromArgb(41, 128, 185) && B_T3.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T3.Text.Substring(0, 2));
                }
                if (B_T4.BackColor == Color.FromArgb(41, 128, 185) && B_T4.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T4.Text.Substring(0, 2));
                }
                if (B_T5.BackColor == Color.FromArgb(41, 128, 185) && B_T5.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T5.Text.Substring(0, 2));
                }
                if (B_T6.BackColor == Color.FromArgb(41, 128, 185) && B_T6.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T6.Text.Substring(0, 2));
                }
                if (B_T7.BackColor == Color.FromArgb(41, 128, 185) && B_T7.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T7.Text.Substring(0, 2));
                }
                if (B_T8.BackColor == Color.FromArgb(41, 128, 185) && B_T8.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T8.Text.Substring(0, 2));
                }
                if (B_T9.BackColor == Color.FromArgb(41, 128, 185) && B_T9.Enabled == false)
                {
                    HourInteger = Convert.ToInt16(B_T9.Text.Substring(0, 2));
                }

                if (MessageBox.Show("Do you want to confirm registeration?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int result = controllerObj.insertREGPRIVATE(HourInteger, CB_SesType.Text, Convert.ToInt32(userd.Text), CB_Trainers.Text, RID);
                    if (result == 0)
                        MessageBox.Show("Registeration Failed");
                    else if (result == 1)
                        MessageBox.Show("Registeration Successfull");
                    return;
                }
            }
            else if(CB_SesType.Text=="Membership")
            {
                if(comboBox1.SelectedIndex==-1)
                {
                    MessageBox.Show("Please select a membership type");
                    return;
                }
                if(userd.Text=="" || controllerObj.CheckUserID(Convert.ToInt32(userd.Text))==0)
                {
                    MessageBox.Show("Please enter a valid userid");
                    return;
                }
                string type = comboBox1.Text;
                int result = controllerObj.InsertMembershipReg(Convert.ToInt32(userd.Text), CB_SesType.Text, type, RID);
                int cost = controllerObj.GetCost(comboBox1.SelectedText);
                controllerObj.InsertPayment(cost, payment.Text, RID);

                if (result == 0)
                    MessageBox.Show("Registeration Failed");
                else if (result == 1)
                    MessageBox.Show("Registeration Successfull");
                return;
            }
        }

        private void B_T1_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T1.Enabled = false;

            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T2_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T2.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T3_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T3.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T4_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T4.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T5_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T5.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }

        }

        private void B_T6_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T6.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T7_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T7.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T8_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T8.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
            if (B_T9.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T9.Enabled = true;
            }
        }

        private void B_T9_Click(object sender, EventArgs e)
        {
            B_Master.Visible = true;
            B_T9.Enabled = false;

            if (B_T1.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T1.Enabled = true;
            }
            if (B_T3.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T3.Enabled = true;
            }
            if (B_T4.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T4.Enabled = true;
            }
            if (B_T5.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T5.Enabled = true;
            }
            if (B_T6.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T6.Enabled = true;
            }
            if (B_T7.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T7.Enabled = true;
            }
            if (B_T8.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T8.Enabled = true;
            }
            if (B_T2.BackColor == Color.FromArgb(41, 128, 185))
            {
                B_T2.Enabled = true;
            }
        }
    }
}