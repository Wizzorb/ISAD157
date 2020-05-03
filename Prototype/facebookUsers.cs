using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Prototype
{
    class facebookUsers
    {

        private int userID;
        private string firstName;
        private string lastName;
        private string gender;
        private string hometown;
        private string city;

        public facebookUsers(int theUserID, string theFirstName, string theLastName, string theGender, string theHometown, string theCity)
        {
            userID = theUserID;
            firstName = theFirstName;
            lastName = theLastName;
            gender = theGender;
            hometown = theHometown;
            city = theCity;
        }

        public int getUserID()
        {
            return userID;
        } public string getFirstName()
        {
            return firstName;
        } public string getLastName()
        {
            return lastName;
        } public string getGender()
        {
            return gender;
        } public string getHometown()
        {
            return hometown;
        } public string getCity()
        {
            return city;
        }

        public string lstBoxDisplay()
        {
            string result = firstName + " " + lastName;
            return result;
        }

        public string identifier
        {
            get { return userID.ToString(); }
        }

        public string displayFormat
        {
            get { return "(" + userID.ToString() + ") - " + firstName.ToString() + " " + lastName.ToString(); }
        }

        public void setUserID(int UID)
        {
            userID = UID;
        } public void setFirstName(string FName)
        {
            firstName = FName;
        } public void setLastName(string LName)
        {
            lastName = LName;
        } public void setGender(string Gndr)
        {
            gender = Gndr;
        } public void setHometown(string HTown)
        {
            hometown = HTown;
        } public void setCity(string Cty)
        {
            city = Cty;
        }
    }
}
