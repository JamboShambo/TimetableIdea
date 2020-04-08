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
        public string Name { get; set; }
        public string Goal { get; set; }
        public string Subject { get; set; }
        public DateTime TimeCreated { get; set; }

        //constructor
        public Task(string name, string goal, string subject, DateTime timeCreated)
        {
            Name = name;
            Goal = goal;
            Subject = subject;
            TimeCreated = timeCreated;
        }

    }
}
