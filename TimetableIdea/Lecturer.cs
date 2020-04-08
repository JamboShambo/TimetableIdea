using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TimetableIdea
{
    public partial class Lecturer
    {
        public int LecturerID { get; set; }
        public string Name { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        

    }
    public partial class Subject
    {
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public virtual List<Lecturer>  Lecturers { get; set; }
        public virtual List<Room> Rooms { get; set; }

        
    }
    public partial class Room
    {
        public int RoomID { get; set; }
        public string RoomCode { get; set; }
        public int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }

        
    }
    public class TimetableData : DbContext
    {
        public TimetableData() : base("MyTimetableData") { }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Room> Rooms { get; set; }

    }
}
