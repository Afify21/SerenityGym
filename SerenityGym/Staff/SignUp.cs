using DBapplication;

namespace SerenityGym
{
    public partial class SignUp : Form
    {
        Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Userr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stafff_Click(object sender, EventArgs e)
        { int r;
            if (fname.Text == "" || lname.Text == "" || add.Text =="" || num.Text=="" || pass.Text=="")
            {
                MessageBox.Show("Please enter all the required fields");
                return;
            }
            if(int.TryParse(fname.Text,out r))
            {
                MessageBox.Show("Please enter a valid first name");
                return;
            }
            if(int.TryParse(lname.Text,out r))
            {
                MessageBox.Show("Please enter a valid last name");
                return;
            }
            if(!int.TryParse(num.Text,out r))
            {
                MessageBox.Show("Please enter a valid phone number");
                return;
            }
            controllerObj.InsertUser(fname.Text,lname.Text,Convert.ToInt32(num.Text),add.Text,pass.Text);
            MessageBox.Show("User Added Successfully!");
            
        }
    }
}
