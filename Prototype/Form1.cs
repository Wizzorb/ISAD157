using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype
{
    public partial class Form1 : Form
    {
        // Declare class arrays
        facebookUsers[] fbUsers = new facebookUsers[0]; facebookFriends[] fbFriends = new facebookFriends[0]; mList[] fbmList = new mList[0];
        messages[] fbMessages = new messages[0]; universities[] fbUni = new universities[0]; workplace[] fbWork = new workplace[0];

        // Code for connecting to the database
        string connectionString = "SERVER=" + dbConnect.SERVER + ";" +
            "DATABASE=" + dbConnect.DATABASE_NAME + ";" + "UID=" +
            dbConnect.USER_NAME + ";" + "PASSWORD=" +
            dbConnect.PASSWORD + ";" + "SslMode=" +
            dbConnect.SslMode + ";";

        public Form1()
        {
            // Calling each method
            InitializeComponent();
            dbConnectandPopulate();
            getUnis();
            getWorkplaces();
            getmList();
            getMessages();
        }

        mList[] getmList()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                // Code for calling the table data
                string query = "SELECT * FROM isad157_jharrison.messages_list";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable facebookmListTable = new DataTable();
                sqlDA.Fill(facebookmListTable);
                int endOfRecord = facebookmListTable.Rows.Count;

                // Declaring each variable before being used
                int senderID = 0000; int messageID = 0000; int count = 0;

                foreach (DataRow row in facebookmListTable.Rows)
                {
                    senderID = (int)row["MUserID"];
                    messageID = (int)row["MessID"];
                    Array.Resize(ref fbmList, fbmList.Length + 1);
                    fbmList[count] = new mList(senderID, messageID);
                    count++;
                }
                connection.Close();
                return fbmList;
            }
        }

        messages[] getMessages()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_jharrison.messagesn";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable facebookMessagesTable = new DataTable();
                sqlDA.Fill(facebookMessagesTable);
                int endOfRecord = facebookMessagesTable.Rows.Count;

                int messageID = 0000; string recipientID = "zeep"; string dateTime = "zeep"; string messageContent = "zeep"; int count = 0;

                foreach (DataRow row in facebookMessagesTable.Rows)
                {
                    messageID = (int)row["UMessageID"];
                    recipientID = row["Recipient"].ToString();
                    dateTime = row["Date_Time"].ToString();
                    messageContent = row["Message"].ToString();
                    Array.Resize(ref fbMessages, fbMessages.Length + 1);
                    fbMessages[count] = new messages(messageID, recipientID, dateTime, messageContent);
                    count++;
                }
                connection.Close();
                return fbMessages;
            }
        }

        workplace[] getWorkplaces()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_jharrison.workplacen";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable facebookWorkplaceTable = new DataTable();
                sqlDA.Fill(facebookWorkplaceTable);
                int endOfRecord = facebookWorkplaceTable.Rows.Count;

                int workID = 0000; string workplace = "zeep"; int count = 0;

                foreach (DataRow row in facebookWorkplaceTable.Rows)
                {
                    workID = (int)row["WUserID"];
                    workplace = row["Workplace"].ToString();
                    Array.Resize(ref fbWork, fbWork.Length + 1);
                    fbWork[count] = new workplace(workID, workplace);
                    count++;
                }
                connection.Close();
                return fbWork;
            }
        }

        universities[] getUnis()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_jharrison.universitiesn";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable facebookUniversityTable = new DataTable();
                sqlDA.Fill(facebookUniversityTable);
                int endOfRecord = facebookUniversityTable.Rows.Count;

                int uniUserID = 0000; string university = "zeep"; int count = 0;

                foreach (DataRow row in facebookUniversityTable.Rows)
                {
                    uniUserID = (int)row["UniUserID"];
                    university = row["University"].ToString();
                    Array.Resize(ref fbUni, fbUni.Length + 1);
                    fbUni[count] = new universities(uniUserID, university);
                    count++;
                }
                connection.Close();
                return fbUni;
            }
        }

        facebookUsers[] dbConnectandPopulate()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM isad157_jharrison.facebook_usersn";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                DataTable facebookUserTable = new DataTable();
                sqlDA.Fill(facebookUserTable);

                int endOfRecords = facebookUserTable.Rows.Count; // Get total number of rows

                // Prepare variables for use
                int fbID = 0000; string fbFirstName = "zeep"; string fbLastName = "zeep"; string fbGender = "zeep";
                string fbHometown = "zeep"; string fbCity = "zeep"; int count = 0;

                foreach(DataRow row in facebookUserTable.Rows)
                {
                    // Get data for each user to populate into its class
                    fbID = (int)row["userID"];
                    fbFirstName = row["FirstName"].ToString();
                    fbLastName = row["LastName"].ToString();
                    fbGender = row["Gender"].ToString();
                    fbHometown = row["Hometown"].ToString();
                    fbCity = row["City"].ToString();

                    // Add one more space in the array for a new facebookUsers class
                    Array.Resize(ref fbUsers, fbUsers.Length + 1);

                    // Populate the class and increase the record counter
                    fbUsers[count] = new facebookUsers(fbID, fbFirstName, fbLastName, fbGender, fbHometown, fbCity);
                    count++;
                }
                                
                // Close connection to DB
                connection.Close();
                // Tell the listbox what data it displays and how to display it.
                lstUserList.DataSource = fbUsers;
                lstUserList.DisplayMember = "displayFormat";
                // Tells the listbox what the unique value (userID) for each item is, so we can get the value when the user clicks a listbox item
                lstUserList.ValueMember = "identifier";
                return fbUsers;
            }
        }

        private void lstUserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the fbUsers array displayed in the lstUserList ListBox
            string selectedFBUser = lstUserList.SelectedValue.ToString();
            getFBUser(selectedFBUser);
        }

        private void getFBUser(string userIDF) // Calling currently selected User ID for reference
        {
            
            if (userIDF != "Prototype.facebookUsers")
            {
                // Emptying boxes and lists in case any info isn't updated
                lbUserInfoName.Text = " ";
                lbUserInfoGender.Text = " ";
                lbUserInfoHometown.Text = " ";
                lbUserInfoCity.Text = " ";
                lbUserInfoUni.Text = " ";
                lstUserFriends.Items.Clear();
                lstUserMessages.Items.Clear();

                // User info being called
                facebookUsers selectedfbuser = fbUsers.FirstOrDefault(i => i.identifier == userIDF);
                lbUserInfoName.Text = selectedfbuser.getFirstName() + " " + selectedfbuser.getLastName();
                lbUserInfoGender.Text = selectedfbuser.getGender();
                lbUserInfoCity.Text = selectedfbuser.getCity();
                lbUserInfoHometown.Text = selectedfbuser.getHometown();

                // User uni being called
                universities tempuni = fbUni.FirstOrDefault(u => u.identifier == userIDF.ToString());
                if (tempuni.uniName != " ")
                {
                    lbUserInfoUni.Text = tempuni.uniName;
                }

                // User work place being called
                workplace tempwork = fbWork.FirstOrDefault(w => w.identifier == userIDF.ToString());
                if (tempwork.workName != " ")
                {
                    lbUserInfoWork.Text = tempwork.workName;
                }

                // Message list being called before calling messages
                mList tempList = fbmList.FirstOrDefault(l => l.identifier2 == userIDF.ToString());
                if (tempList.identifier2 == null)
                {
                    lbUserInfoName.Text = "Nope";
                }
                else
                {
                    // Putting each identifier in string
                    string messID = tempList.identifier2;
                    string uID = tempList.identifier;
                    string combo = tempList.identifier3;
                        using (MySqlConnection connection = new MySqlConnection(connectionString))
                        {
                            string query = "SELECT * FROM isad157_jharrison.messagesn WHERE UMessageID =" + messID;
                            MySqlCommand cmd = new MySqlCommand(query, connection);
                            connection.Open();
                            MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                            DataTable facebookUserMessTable = new DataTable();
                            sqlDA.Fill(facebookUserMessTable);
                            int endOfRecord = facebookUserMessTable.Rows.Count;

                            foreach (DataRow row in facebookUserMessTable.Rows)
                            {
                                // User Messages being called
                                messages tempmessages = fbMessages.FirstOrDefault(m => m.identifier == messID.ToString());
                                lstUserMessages.Items.Add(tempmessages.getsetRecipient);
                                lstUserMessages.Items.Add(tempmessages.getsetDateTime);
                                lstUserMessages.Items.Add(tempmessages.getsetMessage);
                            }
                            connection.Close();
                        }
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM isad157_jharrison.facebook_friendshipsn WHERE UserID =" + userIDF;
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);
                    DataTable facebookFriendsTable = new DataTable();
                    sqlDA.Fill(facebookFriendsTable);
                    int endOfRecord = facebookFriendsTable.Rows.Count;

                    int fbID1 = 0000;
                    int fbID2 = 0000;

                    foreach (DataRow row in facebookFriendsTable.Rows)
                    {
                        fbID1 = (int)row["UserID"];
                        fbID2 = (int)row["UserID_2"];

                        // User Friends being called
                        facebookUsers tempfbuser = fbUsers.FirstOrDefault(i => i.identifier == fbID2.ToString());
                        string fbfName = tempfbuser.displayFormat;
                        lstUserFriends.Items.Add(fbfName);
                    }
                    connection.Close();
                }
            }
        }
    }
}
