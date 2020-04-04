using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableIdea
{
    public class Module : IComparable<Module>
    {
        //my properties
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public string Room { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        //Contructors
        public Module(string name, string lecturer, string room, DateTime timeStart, DateTime timeEnd)
        {
            Name = name;
            Lecturer = lecturer;
            Room = room;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
        }

        public Module()
        {
                
        }

        //My Methods
        public override string ToString()
        {
            return $"{Name}";

        }

        public int CompareTo(Module other)
        {
            return this.Name.CompareTo(other.Name);
        }


        
    }
}
