using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
       
        public int MatchingUser(int ID,string pass)
        {
            string query = "SELECT  Count(*) From Users WHERE userid=" + ID + " AND upassword='" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int MatchingStaff(int ID, string pass)
        {
            string query = "SELECT  Count(*) From Staff WHERE staffid=" + ID + " AND spassword='" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int UpdateUserPass(string s,int id)
        {
            string query = "Update Users SET upassword='"+s+"' WHERE userid="+id+"";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffPass(string s, int id)
        {
            string query = "Update Staff SET spassword='" + s + "' WHERE staffid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserFname(string s, int id)
        {
            string query = "Update Users SET fname='" + s + "' WHERE userid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserLname(string s, int id)
        {
            string query = "Update Users SET lname='" + s + "' WHERE userid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserAddress(string s, int id)
        {
            string query = "Update Users SET user_address='" + s + "' WHERE userid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateUserPhone(int no, int id)
        {
            string query = "Update Users SET phone_num=" + no + " WHERE userid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int SubmitFeedback(string msg,int id)
        {
            string query = "INSERT into Feedback Values(" + id + ",'" + msg + "','" + DateTime.Now + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdatePlan(string type, int Tid, int Uid)
        {
            string query = "Update Users SET phone_num=" + Tid + " WHERE userid=" + Uid + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public string ShowName(int UID)
        {
            string query = "SELECT fname, lname FROM Users WHERE userid=" + UID;
            DataTable result = dbMan.ExecuteReader(query); // Assuming dbMan.ExecuteReader returns a DataTable

            if (result.Rows.Count > 0)
            {
                string fname = result.Rows[0]["fname"].ToString();
                string lname = result.Rows[0]["lname"].ToString();
                return (fname + " " + lname); // Concatenate first name and last name
            }
            else
            {
                return "User not found";
            }
        }
    }
}
