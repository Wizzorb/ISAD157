using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class messages
    {
        private int messageID;
        private string recipient;
        private string dateTime;
        private string message;

        public messages(int theMessageID, string theRecipient, string theDateTime, string theMessage)
        {
            messageID = theMessageID;
            recipient = theRecipient;
            dateTime = theDateTime;
            message = theMessage;
        }

        public int getsetMessageID
        {
            get { return messageID; }
            set { messageID = value; }
        }

        public string getsetRecipient
        {
            get { return recipient; }
            set { recipient = value; }
        }

        public string getsetDateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string getsetMessage
        {
            get { return message; }
            set { message = value; }
        }

        public string identifier
        {
            get { return messageID.ToString(); }
        }
    }
}
