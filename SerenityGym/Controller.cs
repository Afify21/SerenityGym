using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

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

        public DataTable Equipmenttable()
        {
            string query = "SELECT * FROM Equipment";
            return dbMan.ExecuteReader(query);
        }
        
        public DataTable Feedbacktable()
        {
            string query = "SELECT * FROM Feedback";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Transactionstable()
        {
            string query = "SELECT r.registrationid, p.paymentid, p.method, p.amount, p.paymentdate FROM Payments p, registration r  ; ";
            return dbMan.ExecuteReader(query);
        }

        public string Getnotis(string type,ref int i,ref int rowcount,ref string s)
        {
            string query = "Select notif_message,FORMAT(notif_date, 'yyyy-MM-dd') AS notif_date From Gets_Notified ,Notifications  where membership_type='" + type + "' AND notifid=notificationid ";
            DataTable dt = dbMan.ExecuteReader(query);
            rowcount=dt.Rows.Count;
            if (i == -1)
                i = rowcount-1;
            if (dt.Rows.Count > 0)
            {
                string noti = dt.Rows[i]["notif_message"].ToString();
                s = dt.Rows[i]["notif_date"].ToString();
                return noti;
            }
            else
            { MessageBox.Show("No notifications");
                return null;
            };
        }
        
        public string getmembership(int id)
        {
            string query = "select membership_type from users where userid="+id+"";
            DataTable typeee=dbMan.ExecuteReader(query);
            string s = typeee.Rows[0]["membership_type"].ToString();
            return s;
        }
        public int UpdateStaffFname(string s, int id)
        {
            string query = "Update Staff SET fname='" + s + "' WHERE staffid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffLname(string s, int id)
        {
            string query = "Update Staff SET lname='" + s + "' WHERE staffid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffAddress(string s, int id)
        {
            string query = "Update Staff SET staff_address='" + s + "' WHERE staffid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffPhone(int no, int id)
        {
            string query = "Update Staff SET phone_num=" + no + " WHERE staffid=" + id + "";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeleteStaff(int id)
        {
            string query = "DELETE FROM Staff WHERE staffid = " + id+ "";
            return dbMan.ExecuteNonQuery(query);
        }


    }
}
