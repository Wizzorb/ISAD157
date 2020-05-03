using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class facebookFriends
    {
        private int userID1;
        private int userID2;

        public facebookFriends(int theUserID1, int theUserID2)
        {
            userID1 = theUserID1;
            userID2 = theUserID2;
        }

        public int getsetUserID1
        {
            get { return userID1; }
            set { userID1 = value; }
        }
        
        public int getsetUserID2
        {
            get { return userID2; }
            set { userID2 = value; }
        }

        public string identifier
        {
            get { string comboKey = userID1 + "-" + userID2; return comboKey; }
        }
    }
}
