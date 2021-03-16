using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heim_ArtistsWebsite.Models
{
    public class Message
    {
        private String sender;
        private String messagetext;
        private DateTime datetime;

        public String Sender
        {
            get { return this.sender; }
            set
            {
                this.sender = value;
            }
        }

        public String MessageText
        {
            get { return this.messagetext; }
            set
            {
                this.messagetext = value;
            }
        }
    
        public DateTime Datetime
        {
            get { return this.datetime; }
            set
            {
                this.datetime = value;
            }
        }

        public Message() : this("", "", DateTime.Now) { }
        public Message(String sender, String messagetext, DateTime datetime)
        {
            this.Sender = sender;
            this.MessageText = messagetext;
            this.Datetime = datetime;
        }
    }
}
