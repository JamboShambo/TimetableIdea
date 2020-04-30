using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableIdea
{
    public class Task
    {
        //props
        public string TaskName { get; set; }
        public string TaskGoal { get; set; }
        public string TaskSubject { get; set; }
        public DateTime TaskTimeCreated { get; set; }

        //constructor
        public Task(string name, string goal, string subject, DateTime timeCreated)
        {
            TaskName = name;
            TaskGoal = goal;
            TaskSubject = subject;
            TaskTimeCreated = timeCreated;
        }

        public Task()
        {

        }

        //method
        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}",TaskName,TaskGoal,TaskSubject,TaskTimeCreated.ToShortDateString());
        }

    }
}
