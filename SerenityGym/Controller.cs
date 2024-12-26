using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;

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

        public int ClockIn(int id)
        {
            string query = "INSERT INTO Attendance (att_status, att_date, staffid) VALUES ('Clocked In','" + DateTime.Now + "'," + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int IsClockedInCheck(int id)
        {
            string query = "SELECT COUNT(*) FROM Attendance WHERE att_date ='" + DateTime.Now + "' AND staffid =" + id;
            return (int)dbMan.ExecuteScalar(query);
        }
        public int UpdateStaffAddress(string add,int id)
        {
            string query = "UPDATE Staff SET staff_address='" + add + "' WHERE staffid =" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffFName(string name, int id)
        {
            string query = "UPDATE Staff SET fname='" + name + "' WHERE staffid =" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffLName(string name, int id)
        {
            string query = "UPDATE Staff SET lname='" + name + "' WHERE staffid =" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffPhoneNum(int num, int id)
        {
            string query = "UPDATE Staff SET phone_num='" + num + "' WHERE staffid =" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffPassword(string pass, int id)
        {
            string query = "UPDATE Staff SET spassword='" + pass + "' WHERE staffid =" + id;
            return dbMan.ExecuteNonQuery(query);
        }
        public string GetStaffPassword(int id)
        {
            string query = "SELECT spassword FROM Staff WHERE staffid=" + id;
            return (string)dbMan.ExecuteScalar(query);
        }
        public int CheckUserID(int id)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE userid=" + id;
            return (int)dbMan.ExecuteScalar(query); 
        }
        public int InsertUser(string fname, string lname, int num, string address, string pass)
        {
            string query = "INSERT INTO Users(membership_type, fname, lname, phone_num, user_address, expiry_date, upassword) VALUES (NULL,'"+fname+"','"+lname+"',"+num+",'"+address+"',NULL,'" + pass + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetMemberships()
        {
            string query = "SELECT membership_type FROM Membership";
            return dbMan.ExecuteReader(query);
        }
        public int SendNotification(string mes)
        {
            string query = "INSERT INTO Notifications(notif_message,notif_date) VALUES ('" + mes + "','" + DateTime.Now + "');";
           
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetNotifID()
        {
            string query = "SELECT MAX(notificationid) FROM Notifications";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int GetsNotified(int id,string membership)
        {
            string query = "INSERT INTO Gets_Notified(notifid,membership_type) VALUES (" + id + ",'" + membership + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ClockingOut(int id)
        {
            string query = "INSERT INTO Attendance (att_status, att_date, staffid) VALUES ('Clocked Out','" + DateTime.Now + "'," + id + ");";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
