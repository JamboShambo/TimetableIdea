using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableIdea
{
    public class CA : IComparable
    {

        //props
        public string CAName { get; set; }
        public string CADescription { get; set; }
        public string CASubject { get; set; }
        public DateTime CADeadline { get; set; }

        //constructor
        public CA(string caName, string caDescription, string caSubject, DateTime caDeadline)
        {
            CAName = caName;
            CADescription = caDescription;
            CASubject = caSubject;
            CADeadline = caDeadline;
        }

        public CA(string caName)
        {
            CAName = caName;           
        }

        public CA()
        {

        }

        public override string ToString()
        {
            return string.Format("Day: {0}",CADeadline);
        }

        public int CompareTo(object obj)
        {
            CA that = obj as CA;
            return this.CADeadline.CompareTo(that.CADeadline);
        }
    }
}
