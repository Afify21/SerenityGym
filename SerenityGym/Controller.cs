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

        public int SubmitFeedback(string msg,int id, string mood)
        {
            string query = "INSERT into Feedback Values(" + id + ",'"+mood+"','" + msg + "','" + DateTime.Now + "')";
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
        public string TrainingPlan(int UID)
        {
            string query = "SELECT plan_type, Split,userid FROM Plans WHERE userid=" + UID + " AND plan_type='Training'";
            DataTable result = dbMan.ExecuteReader(query); // Assuming dbMan.ExecuteReader returns a DataTable

            if (result.Rows.Count > 0)
            {
                string split = result.Rows[0]["Split"].ToString();
                return (split); // Concatenate first name and last name
            }
            else
            {
                return "User not found";
            }
        }
        public string DietPlan(int UID,int TID)
        {
            string query = "SELECT plan_type, Split,userid,staffid FROM Plans WHERE userid=" + UID + " AND plan_type='Food' AND staffid=" + TID;
            DataTable result = dbMan.ExecuteReader(query); // Assuming dbMan.ExecuteReader returns a DataTable

            if (result.Rows.Count > 0)
            {
                string split = result.Rows[0]["Split"].ToString();
                return (split); // Concatenate first name and last name
            }
            else
            {
                return "User not found";
            }
        }
        public bool IsTrainedByTrainer(int UID, int TID)
        {
            string query = "SELECT staffid FROM Plans WHERE userid=" + UID;

            DataTable result = dbMan.ExecuteReader(query);
            if (result == null)
            {
                return false;
            }

            if (result.Rows.Count > 0)
            {
                int staffid = Convert.ToInt32(result.Rows[0]["staffid"]);

                if (staffid == TID)
                {
                    return true;
                }
            }

            return false;  
        }
        public bool hasPlan(int UID)
        {
            string query = "SELECT userid FROM Plans WHERE userid=" + UID;

            DataTable result = dbMan.ExecuteReader(query);
            if (result == null)
            {
                return false;
            }
            if (result.Rows.Count > 0)
            {
                int userid = Convert.ToInt32(result.Rows[0]["userid"]);

                if (userid == UID)
                {
                    return true;
                }
            }

            return false;
        }
        public int UpdateTSplit(string split, int UID)
        {
            string query = "UPDATE Plans SET Split='" + split + "' WHERE userid=" + UID + " AND plan_type='Training'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateFSplit(string split, int UID)
        {
            string query = "UPDATE Plans SET Split='" + split + "' WHERE userid=" + UID + " AND plan_type='Food'";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddTrainingPlan(int uid, int tid, string type, string split)
        {
            string query = "INSERT INTO Plans (userid, staffid,plan_type,Split) VALUES (" + uid + ", " + tid + ", '" + type + "', '" + split + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int AddDietPlan(int uid, int tid, string type, string split)
        {
            string query = "INSERT INTO Plans (userid, staffid,plan_type,Split) VALUES (" + uid + ", " + tid + ", '" + type + "', '" + split + "')";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewPastSessions(int TID)
        {
            string query = "SELECT * FROM Registration WHERE TrainerID=" + TID +
                          " AND regtype='Private' AND regdate < '" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewComingSessions(int TID)
        {
            string query = "SELECT * FROM Registration WHERE TrainerID=" + TID +
                          " AND regtype='Private' AND regdate >= '" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewMemberProgress(int TID, int UID)
        {
            string query = "SELECT * FROM Tracker WHERE TRAINER_ID=" + TID + " AND USER_ID=" + UID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllMemberProgress(int TID)
        {
            string query = "SELECT * FROM Tracker WHERE TRAINER_ID=" + TID ;
            return dbMan.ExecuteReader(query);
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
        public int ShowProfit()
        {
            string query = "SELECT SUM(amount) FROM Payments";
            try
            {
                object result = dbMan.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : 0; // Convert and return, default to 0 if null
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in ShowProfit: {ex.Message}");
                return -1; // Return -1 if an error occurs
            }
        }

        public DataTable Reviewstable()
        {
            string query = "SELECT r.registrationid, p.paymentid, p.method, p.amount, p.paymentdate FROM Payments p, registration r  ; ";
            return dbMan.ExecuteReader(query);
        }
    }
}
