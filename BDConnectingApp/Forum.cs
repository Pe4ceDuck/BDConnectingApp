using System;
using System.Collections.Generic;
using System.Text;

namespace BDConnectingApp
{
    class Forum
    {
        private int postid;
        private string threadname;
        private int userid;
        private string creationDate;
        private string title;
        private string body;

        public int Postid { get => postid; set => postid = value; }
        public string Threadname { get => threadname; set => threadname = value; }
        public int Userid { get => userid; set => userid = value; }
        public string CreationDate { get => creationDate; set => creationDate = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
    }

    
}
