using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableIdea;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TimetableData db = new TimetableData();

            using (db)
            {

                //data to add to the database
                Subject s1 = new Subject() { SubjectID = 1, SubjectName = "Object Oriented Development" };
                Lecturer l1 = new Lecturer() { LecturerID = 1, Name = "Keith Mc Manus", SubjectID=1, Subject = s1 };
                Room r1_1 = new Room() { RoomID = 1, RoomCode = "A0006", SubjectID = 1, Subject = s1 };
                Room r1_2 = new Room() { RoomID = 2, RoomCode = "B1042", SubjectID = 1, Subject = s1 };
                Room r1_3 = new Room() { RoomID = 3, RoomCode = "D2036", SubjectID = 1, Subject = s1 };

                Subject s2 = new Subject() { SubjectID = 2, SubjectName = "Mathematics 3" };
                Lecturer l2 = new Lecturer() { LecturerID = 2, Name = "Francis O'Regan", SubjectID = 2, Subject = s2 };
                Room r2_1 = new Room() { RoomID = 4, RoomCode = "E0011", SubjectID = 2, Subject = s2 };
                Room r2_2 = new Room() { RoomID = 5, RoomCode = "C1006", SubjectID = 2, Subject = s2 };
                Room r2_3 = new Room() { RoomID = 6, RoomCode = "E0011", SubjectID = 2, Subject = s2 };

                Subject s3 = new Subject() { SubjectID = 3, SubjectName = "Software Quality and Testing" };
                Lecturer l3 = new Lecturer() { LecturerID = 3, Name = "Vivion Kinsella", SubjectID = 3, Subject = s3 };
                Room r3_1 = new Room() { RoomID = 7, RoomCode = "C1002", SubjectID = 3, Subject = s3 };
                Room r3_2 = new Room() { RoomID = 8, RoomCode = "A0005", SubjectID = 3, Subject = s3 };

                Subject s4 = new Subject() { SubjectID = 4, SubjectName = "Web Programming 1" };
                Lecturer l4 = new Lecturer() { LecturerID = 4, Name = "Kevin Peyton", SubjectID = 4, Subject = s4 };
                Room r4_1 = new Room() { RoomID = 9, RoomCode = "E0011", SubjectID = 4, Subject = s4 };
                Room r4_2 = new Room() { RoomID = 10, RoomCode = "B1041", SubjectID = 4, Subject = s4 };
                Room r4_3 = new Room() { RoomID = 11, RoomCode = "D2039", SubjectID = 4, Subject = s4 };

                Subject s5 = new Subject() { SubjectID = 5, SubjectName = "Intro to Cloud Computing" };
                Lecturer l5 = new Lecturer() { LecturerID = 5, Name = "Colm Davey", SubjectID = 5, Subject = s5 };
                Room r5_1 = new Room() { RoomID = 12, RoomCode = "A0004", SubjectID = 5, Subject = s5 };
                Room r5_2 = new Room() { RoomID = 13, RoomCode = "D2037", SubjectID = 5, Subject = s5 };

                Subject s6 = new Subject() { SubjectID = 6, SubjectName = "Intro to Database Management" };
                Lecturer l6 = new Lecturer() { LecturerID = 6, Name = "Padraig Harte", SubjectID = 6, Subject = s6 };
                Room r6_1 = new Room() { RoomID = 14, RoomCode = "C1006", SubjectID = 6, Subject = s6 };
                Room r6_2 = new Room() { RoomID = 15, RoomCode = "E0017", SubjectID = 6, Subject = s6 };
                Room r6_3 = new Room() { RoomID = 16, RoomCode = "E0029", SubjectID = 6, Subject = s6 };

                //adding to database
                db.Subjects.Add(s1);
                db.Subjects.Add(s2);
                db.Subjects.Add(s3);
                db.Subjects.Add(s4);
                db.Subjects.Add(s5);
                db.Subjects.Add(s6);

                Console.WriteLine("Subjects added");

                db.Lecturers.Add(l1);
                db.Lecturers.Add(l2);
                db.Lecturers.Add(l3);
                db.Lecturers.Add(l4);
                db.Lecturers.Add(l5);
                db.Lecturers.Add(l6);

                Console.WriteLine("Lecturers added");

                db.Rooms.Add(r1_1);
                db.Rooms.Add(r1_2);
                db.Rooms.Add(r1_3);
                db.Rooms.Add(r2_1);
                db.Rooms.Add(r2_2);
                db.Rooms.Add(r2_3);
                db.Rooms.Add(r3_1);
                db.Rooms.Add(r3_2);
                db.Rooms.Add(r4_1);
                db.Rooms.Add(r4_2);
                db.Rooms.Add(r4_3);
                db.Rooms.Add(r5_1);
                db.Rooms.Add(r5_2);
                db.Rooms.Add(r6_1);
                db.Rooms.Add(r6_2);
                db.Rooms.Add(r6_3);

                Console.WriteLine("Rooms added");

                db.SaveChanges();

                Console.WriteLine("Saved to DB");


            }

        }
    }
}
