﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;
using Microsoft.ReportingServices.Interfaces;
using SerenityGym;

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

        public int MatchingUser(int ID, string pass)
        {
            string query = "SELECT  Count(*) From Users WHERE userid=" + ID + " AND upassword='" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int MatchingStaff(int ID, string pass)
        {
            string query = "SELECT  Count(*) From Staff WHERE staffid=" + ID + " AND spassword='" + pass + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int UpdateUserPass(string s, int id)
        {
            string query = "Update Users SET upassword='" + s + "' WHERE userid=" + id + "";
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

        public int SubmitFeedback(string msg, int id, string mood)
        {
            string query = "INSERT into Feedback Values(" + id + ",'" + mood + "','" + msg + "','" + DateTime.Now + "')";
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
            string query = "SELECT plan_type,Split,userid FROM Plans WHERE userid=" + UID + " AND plan_type='Training'";
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
        public string DietPlan(int UID, int TID)
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
        public string IsTrainedByWho(int UID)
        {
            string query = "SELECT s.fname,s.lname FROM Staff as s,Plans as p WHERE s.staffid=p.staffid And p.userid=" + UID;

            DataTable result = dbMan.ExecuteReader(query);
            
            if (result.Rows.Count > 0)
            {
                string fname = result.Rows[0]["fname"].ToString();
                string lname = result.Rows[0]["lname"].ToString();
                return (fname + " " + lname); 
            }
            else
            {
                return "User not found";
            }
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
        public bool isUser(int UID)
        {
            string query = "SELECT userid FROM Users WHERE userid=" + UID;

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
            string query = "INSERT INTO Plans (userid,staffid,plan_type,Split) VALUES (" + uid + ", " + tid + ", '" + type + "', '" + split + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetPlanID(int id)
        {
            string query = "SELECT planid FROM Plans WHERE userid=" + id;
            return (int)dbMan.ExecuteScalar(query);
        }
        public int AddProgress(int pid,int uid, int tid, int progress, string goal)
        {
            string query = "INSERT INTO Tracker (planid,USER_ID,TRAINER_ID,progress,goal) VALUES (" + pid + "," + uid + ", " + tid + ", " + progress + ", '" + goal + "')";
            return dbMan.ExecuteNonQuery(query);
        }
        
        public int AddDietPlan(int uid, int tid, string type, string split)
        {
            string query = "INSERT INTO Plans (userid, staffid,plan_type,Split) VALUES (" + uid + ", " + tid + ", '" + type + "', '" + split + "')";

            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewPastSessions(int TID)
        {
            string query = "SELECT  u.fname as FirstName,u.lname as LastName,r.starthour,r.endhour,r.regdate FROM Registration as r,Users as u WHERE u.userid=r.userid And TrainerID=" + TID +
                          " AND r.regtype='Private' AND r.regdate < '" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewComingSessions(int TID)
        {
            string query = "SELECT  u.fname as FirstName,u.lname as LastName,r.starthour,r.endhour,r.regdate FROM Registration as r,Users as u WHERE u.userid=r.userid And TrainerID=" + TID +
                          " AND r.regtype='Private' AND r.regdate >= '" + DateTime.Now.ToString("MM-dd-yyyy") + "'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewMemberProgress(int TID, int UID)
        {
            string query = "SELECT u.fname as FirstName,u.lname as LastName,t.progress,t.goal FROM Tracker as t, Users as u,Staff as s WHERE u.userid=t.USER_ID and s.staffid=t.TRAINER_ID and TRAINER_ID=" + TID + " AND USER_ID=" + UID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewMemberProgress( int UID)
        {
            string query = "SELECT t.progress,t.goal FROM Tracker as t, Users as u,Staff as s WHERE u.userid=t.USER_ID and s.staffid=t.TRAINER_ID and USER_ID=" + UID;
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewAllMemberProgress(int TID)
        {
            string query = "SELECT u.fname as FirstName,u.lname as LastName,t.progress,t.goal FROM Tracker as t, Users as u,Staff as s WHERE u.userid=t.USER_ID and s.staffid=t.TRAINER_ID and TRAINER_ID=" + TID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewTrainingPlan(int UID)
        {
            string query = "SELECT * FROM Plans WHERE userid=" + UID + " AND plan_type='Training'"; ;
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewDietPlan(int UID)
        {
            string query = "SELECT * FROM Plans WHERE userid=" + UID + " AND plan_type='Food'"; ;
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
            string query = "SELECT registrationid,method, Paymentamount, regdate FROM registration   ; ";
            return dbMan.ExecuteReader(query);
        }

        public string Getnotis(string type, ref int i, ref int rowcount, ref string s)
        {
            string query = "Select notif_message,FORMAT(notif_date, 'yyyy-MM-dd') AS notif_date From Gets_Notified ,Notifications  where membership_type='" + type + "' AND notifid=notificationid ";
            DataTable dt = dbMan.ExecuteReader(query);
            rowcount = dt.Rows.Count;
            if (i == -1)
                i = rowcount - 1;
            if (dt.Rows.Count > 0)
            {
                string noti = dt.Rows[i]["notif_message"].ToString();
                s = dt.Rows[i]["notif_date"].ToString();
                return noti;
            }
            else
            {
                MessageBox.Show("No notifications");
                return null;
            };
        }

        public string getmembership(int id)
        {
            string query = "select membership_type from users where userid=" + id + "";
            DataTable typeee = dbMan.ExecuteReader(query);
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
            string query = "DELETE FROM Staff WHERE staffid = " + id + "";
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
            string query = "INSERT INTO Users(membership_type, fname, lname, phone_num, user_address, expiry_d, upassword) VALUES (NULL,'"+fname+"','"+lname+"',"+num+",'"+address+"',NULL,'" + pass + "');";
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
        public int ShowProfit()
        {
            string query = "SELECT SUM(Paymentamount) FROM Registration";
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

        public int GetTotalMoodsCount()
        {
            string query = "SELECT COUNT(*) FROM Feedback";
            try
            {
                object result = dbMan.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : 0; // Convert and return, default to 0 if null
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in GetTotalMoodsCount: {ex.Message}");
                return -1; // Return -1 if an error occurs
            }
        }

        public int GetPositiveMoodsCount()
        {
            string query = "SELECT COUNT(*) FROM Feedback WHERE Mood = 'Positive'";
            try
            {
                object result = dbMan.ExecuteScalar(query);
                return result != null ? Convert.ToInt32(result) : 0; // Convert and return, default to 0 if null
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in GetPositiveMoodsCount: {ex.Message}");
                return -1; // Return -1 if an error occurs
            }
        }
        public DataTable PopulateComboBox()
        {
           string query = "SELECT staffid FROM Staff WHERE staffid BETWEEN 20000 AND 29999";
            return dbMan.ExecuteReader(query);
        }
        public DataTable PopulateUserComboBox(int TID)
        {
            string query = "SELECT Distinct u.fname, u.lname FROM Users AS u, Plans AS p WHERE u.userid = p.userid AND p.staffid = " + TID;
            return dbMan.ExecuteReader(query);
        }
        public int GetUserID(string firstName, string lastName)
        {
            string query = $"SELECT userid FROM Users WHERE fname = '{firstName}' AND lname = '{lastName}'";
            DataTable result = dbMan.ExecuteReader(query);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["userid"]);
            }
            else
            {
                throw new Exception("User not found.");
            }
        }
        public DataTable GetFullMembership()
        {
            string query = "SELECT * FROM Membership";
            return dbMan.ExecuteReader(query);
        }
        public string GetUserName(int UID)
        {
            string query = $"SELECT fname, lname FROM Users WHERE userid = " + UID;
            DataTable result = dbMan.ExecuteReader(query);

            if (result.Rows.Count > 0)
            {
                string firstName = result.Rows[0]["fname"].ToString();
                string lastName = result.Rows[0]["lname"].ToString();
                return $"{firstName} {lastName}";
            }
            else
            {
                throw new Exception("User not found.");
            }
        }

        public DataTable Getprivregs(int x)
        {
            string query = "select r.registrationid, r.userid,r.regtype As Type,r.starthour AS StartHour,r.endhour AS EndHour,r.method AS PaymentMethod,r.regdate AS RegDate ,t.Lname AS TrainerLastName FROM Registration as r, Staff as t\r\nwhere t.staffid=r.TrainerID and r.regtype='Private' and regdate='"+DateTime.Now+"'  and r.userid="+x+" and starthour>'"+ DateTime.Now.TimeOfDay+"'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetPadelReg(int x)
        {    
            string query = "select r.registrationid, r.userid, r.regtype As Type, r.starthour AS StartHour, r.endhour AS EndHour, r.method AS PaymentMethod, r.regdate AS RegDate FROM Registration as r where (r.regtype='Padel') and regdate='"+DateTime.Now+"'  and r.userid="+x+ " and starthour>'"+ DateTime.Now.TimeOfDay+"'";
            return dbMan.ExecuteReader(query);
        }

        public int Gettraineebyid(string staffId)
        {
            int staffIdInt = Convert.ToInt32(staffId);

            // Construct the query with the staffId
            string query = "SELECT COUNT(userid) FROM Plans WHERE staffid = " + staffIdInt;

            // Execute the query and get the result
            var result = dbMan.ExecuteScalar(query); // Use ExecuteScalar to get the count

            // Return the result as an integer, handling DBNull.Value if necessary
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }
        public int Insertadmin(string Managerid, string fname, string lname, int num, string address, string pass)
        {
            string manager1 = ("Manager");
            Convert.ToInt32(Managerid);
            string query = "INSERT INTO Staff(staffid, staff_address, fname, lname, phone_num, staff_type, spassword) " +
                  "VALUES (" + Managerid + ",'" + address + "','" + fname + "','" + lname + "','" + num + "', '" + manager1 + "', '" + pass + "');";
            return dbMan.ExecuteNonQuery(query);
        }
    
    

        public DataTable GetDatesFORREG(int id)
        {
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy-MM-dd");
            string query = "select starthour,endhour from Registration where TrainerID=" + id + "AND regdate='" + today + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDatesFORREGPPP()
        {
            DateTime today = DateTime.Today;
            string date = today.ToString("yyyy-MM-dd");
            string query = "select starthour,endhour from Registration where regtype='Padel' and regdate='" + today + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GETMYDET(int x)
        { 
            string query = "select * from Users Where userid="+x+"";
            return dbMan.ExecuteReader(query);
        }

        public int getTrainerID(string fn, string ln)
        {
            string query = "Select staffid from staff where fname='" + fn + "'AND lname='" + ln + "'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public DataTable getTrainers()
        {
            string query = "SELECT CONCAT(fname, ' ', lname) AS FullName from staff where staffid >= 20000 AND staffid<= 29999";
            return dbMan.ExecuteReader(query);
        }

        public int getTrainerIDByFull(string FULL)
        {
            string query = "SELECT staffid FROM staff WHERE CONCAT(fname, ' ', lname) = '" + FULL + "'";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string[] getTrainersARR() {
            string query = "SELECT CONCAT(fname, ' ', lname) AS FullName from staff where staffid >= 20000 AND staffid<= 29999"; DataTable dataTable = dbMan.ExecuteReader(query);
            List<string> fullNames = new List<string>();
            foreach (DataRow row in dataTable.Rows)
            {
                fullNames.Add(row["FullName"].ToString());
            }
            return fullNames.ToArray(); }

        public int insertREGPRIVATE(int START, string type, int uid, string FullName, int Staffchecker)
        {
          
            int trainerid = getTrainerIDByFull(FullName);
            if (Staffchecker == -1)
            {
                string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values("+400+",'Credit','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','"+type+"'," + uid + ",null,"+trainerid+",null);";
                return dbMan.ExecuteNonQuery(query);
            }
            if (Staffchecker > 0) 
            {
                string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values('"+400+"','Credit','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','"+type+"'," + uid + ",null," + trainerid + ","+Staffchecker+");";
                return dbMan.ExecuteNonQuery(query);
            }
            return 0;
        }
        public int insertREGPRIVATE2(int START,string method, string type, int uid, string FullName, int Staffchecker)
        {

            int trainerid = getTrainerIDByFull(FullName);
            if (Staffchecker == -1)
            {
                string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values(" + 400 + ",'"+method+"','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','" + type + "'," + uid + ",null," + trainerid + ",null);";
                return dbMan.ExecuteNonQuery(query);
            }
            if (Staffchecker > 0)
            {
                string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values('" + 400 + "','Credit','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','" + type + "'," + uid + ",null," + trainerid + "," + Staffchecker + ");";
                return dbMan.ExecuteNonQuery(query);
            }
            return 0;
        }

        public int insertREGPadel(int START, string type, int uid)
        {
                string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values('"+250+"','Credit','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','" + type + "'," + uid + ",null,null,null);";
                return dbMan.ExecuteNonQuery(query);
        }
        public int insertREGPadel2(int START,string method, string type, int uid, int RID)
        {
            string query = "insert into Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) values('" + 250 + "','"+method+"','" + (START.ToString() + ":00:00") + "','" + ((START + 1).ToString() + ":00:00") + "','" + DateTime.Now + "','" + type + "'," + uid + ",null,null,"+RID+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertMembershipReg(int amount, string method,int ID, string type1, string type2,int RID)
        {
            string query = "INSERT INTO Registration(Paymentamount,method,starthour,endhour,regdate,regtype,userid,membership_type,TrainerID,S_ID) VALUES ('"+amount+"','"+method+"',NULL,NULL,'" + DateTime.Now + "','" + type1 + "'," + ID + ",'" + type2 + "',NULL," + RID + ");";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateUserMembership(string type, int id)
        {
            
            if (type == "Bronze")
            {
               string query = "UPDATE Users SET membership_type='" + type + "', expiry_d='" + DateTime.Now.AddDays(30) + "' WHERE userid =" + id;
                return dbMan.ExecuteNonQuery(query);
            }
            else if (type == "Silver")
            {
               string query = "UPDATE Users SET membership_type='" + type + "', expiry_d='" + DateTime.Now.AddDays(90) + "' WHERE userid =" + id;
                return dbMan.ExecuteNonQuery(query);
            }
            else if (type == "Gold")
            {
              string  query = "UPDATE Users SET membership_type='" + type + "', expiry_d='" + DateTime.Now.AddDays(180) + "' WHERE userid =" + id;
                return dbMan.ExecuteNonQuery(query);
            }
            else if (type == "Platinum")
            {
              string  query = "UPDATE Users SET membership_type='" + type + "', expiry_d='" + DateTime.Now.AddDays(360) + "' WHERE userid =" + id;
                return dbMan.ExecuteNonQuery(query);
            }
            return 0;
            
            
        }
        public int GetCost(string type)
        {
            string query = "SELECT MAX(cost) FROM Membership WHERE membership_type='"+type+"';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int InsertPayment(int amount, string method, int RID)
        {
            string query = "INSERT INTO Payments(amount,paymentdate,method,staffid) VALUES (" + amount + ",'" + DateTime.Now + "','" + method + "'," + RID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int deletereg(int z)
        {
            string query = "DELETE FROM Registration WHERE registrationid ="+z+" ;";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
    



