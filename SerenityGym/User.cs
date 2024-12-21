using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerenityGym
{

    public partial class User : Form
    {
        int UID;

        public User(int UserID)
        {
            UID = UserID;
            InitializeComponent();
        }
    }
}
