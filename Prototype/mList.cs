using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class mList
    {
        private int senderID;
        private int lMessageID;

        public mList(int theSenderID, int theLMessageID)
        {
            senderID = theSenderID;
            lMessageID = theLMessageID;
        }

        public int getsetSenderID
        {
            get { return senderID; }
            set { senderID = value; }
        }

        public int getsetMessageID
        {
            get { return lMessageID; }
            set { lMessageID = value; }
        }
        public string identifier
        {
            get { return senderID.ToString(); }
        }

        public string identifier2
        {
            get { return lMessageID.ToString(); }
        }

        public string identifier3
        {
            get { string comboKey = senderID + "-" + lMessageID; return comboKey; }
        }
    }
}
