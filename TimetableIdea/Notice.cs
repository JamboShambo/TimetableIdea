using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableIdea
{
    public class Notice
    {

        //props
        public string NoticeReason { get; set; }
        public string NoticeSubject { get; set; }
        public DateTime NoticeDate { get; set; }


        //constructor
        public Notice(string noticeReason, string noticeSubject, DateTime noticeDate)
        {
            NoticeReason = noticeReason;
            NoticeSubject = noticeSubject;
            NoticeDate = noticeDate;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", NoticeReason,NoticeSubject, NoticeDate.ToShortDateString());
        }


    }
}
