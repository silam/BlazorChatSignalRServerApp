﻿namespace BlazorSignalRServerApp.Data
{
    public class NotificationMessage
    {
        public NotificationMessage() { }
        public int MsgId { get; set; }
        public string SenderName { get; set; }

        public string ReceiverName { get; set; }

        public string MsgTitle { get; set; }


        public string MsgBody { get; set; }

        public DateTime MsgDate { get; set; } = DateTime.Now;

        public string MsgDateStr => this.MsgDate.ToString("dd-MMM-yyyy");




    }
}
