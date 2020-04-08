using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TimetableIdea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TimetableData db = new TimetableData();
        //List<Module> AllModule = new List<Module>();
        //List<Module> MonModule = new List<Module>();
        //List<Module> TuesModule = new List<Module>();
        //List<Module> WedModule = new List<Module>();
        //List<Module> ThursModule = new List<Module>();
        //List<Module> FriModule = new List<Module>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Monday information loaded
            //cell 1
            var q1 = from c in db.Subjects
                         where c.SubjectID == 1
                         select c.SubjectName;

            txtb2_1.ItemsSource = q1.ToList();

            var q2 = from c in db.Lecturers
                     where c.LecturerID == 1
                     select c.Name;

            txtb2_1_Copy.ItemsSource = q2.ToList();

            var q3 = from c in db.Rooms
                         where c.RoomID == 1
                         select c.RoomCode;

            txtb2_1_Copy1.ItemsSource = q3.ToList();

            //cell 2
            var q4 = from c in db.Subjects
                     where c.SubjectID == 2
                     select c.SubjectName;

            txtb7_1.ItemsSource = q4.ToList();

            var q5 = from c in db.Lecturers
                     where c.LecturerID == 2
                     select c.Name;

            txtb7_1_Copy.ItemsSource = q5.ToList();

            var q6 = from c in db.Rooms
                     where c.RoomID == 4
                     select c.RoomCode;

            txtb7_1_Copy1.ItemsSource = q6.ToList();

            //cell 3
            var q7 = from c in db.Subjects
                     where c.SubjectID == 3
                     select c.SubjectName;

            txtb8_1.ItemsSource = q7.ToList();

            var q8 = from c in db.Lecturers
                     where c.LecturerID == 3
                     select c.Name;

            txtb8_1_Copy.ItemsSource = q8.ToList();

            var q9 = from c in db.Rooms
                     where c.RoomID == 7
                     select c.RoomCode;

            txtb8_1_Copy1.ItemsSource = q9.ToList();

            //cell 4           
            txtb9_1.ItemsSource = q7.ToList();
            txtb9_1_Copy.ItemsSource = q8.ToList();
            txtb9_1_Copy1.ItemsSource = q9.ToList();

            // Tuesday information loaded
            //cell 1
            var q10 = from c in db.Subjects
                     where c.SubjectID == 4
                     select c.SubjectName;

            txtb1_2.ItemsSource = q10.ToList();

            var q11 = from c in db.Lecturers
                     where c.LecturerID == 4
                     select c.Name;

            txtb1_2_Copy.ItemsSource = q11.ToList();

            var q12 = from c in db.Rooms
                     where c.RoomID == 9
                     select c.RoomCode;

            txtb1_2_Copy1.ItemsSource = q12.ToList();

            //cell 2
            var q13 = from c in db.Subjects
                      where c.SubjectID == 5
                      select c.SubjectName;

            txtb2_2.ItemsSource = q13.ToList();

            var q14 = from c in db.Lecturers
                      where c.LecturerID == 5
                      select c.Name;

            txtb2_2_Copy.ItemsSource = q14.ToList();

            var q15 = from c in db.Rooms
                      where c.RoomID == 12
                      select c.RoomCode;

            txtb2_2_Copy1.ItemsSource = q15.ToList();

            //cell 3        
            txtb7_2.ItemsSource = q10.ToList();
            txtb7_2_Copy.ItemsSource = q11.ToList();

            var q16 = from c in db.Rooms
                      where c.RoomID == 10
                      select c.RoomCode;

            txtb7_2_Copy1.ItemsSource = q15.ToList();

            //cell 4        
            txtb8_2.ItemsSource = q10.ToList();
            txtb8_2_Copy.ItemsSource = q11.ToList();
            txtb8_2_Copy1.ItemsSource = q15.ToList();

            //cell 5
            var q17 = from c in db.Subjects
                      where c.SubjectID == 6
                      select c.SubjectName;

            txtb9_2.ItemsSource = q17.ToList();

            var q18 = from c in db.Lecturers
                      where c.LecturerID == 6
                      select c.Name;

            txtb9_2_Copy.ItemsSource = q18.ToList();

            var q19 = from c in db.Rooms
                      where c.RoomID == 14
                      select c.RoomCode;

            txtb9_2_Copy1.ItemsSource = q19.ToList();

            // Wednesday information loaded
            //cell 1
            txtb1_3.ItemsSource = q1.ToList();
            txtb1_3_Copy.ItemsSource = q2.ToList();

            var q20 = from c in db.Rooms
                      where c.RoomID == 2
                      select c.RoomCode;

            txtb1_3_Copy1.ItemsSource = q20.ToList();

            //cell 2
            txtb3_3.ItemsSource = q4.ToList();
            txtb3_3_Copy.ItemsSource = q5.ToList();

            var q21 = from c in db.Rooms
                      where c.RoomID == 5
                      select c.RoomCode;

            txtb3_3_Copy1.ItemsSource = q21.ToList();

            //cell 2
            txtb4_3.ItemsSource = q17.ToList();
            txtb4_3_Copy.ItemsSource = q18.ToList();

            var q22 = from c in db.Rooms
                      where c.RoomID == 15
                      select c.RoomCode;

            txtb4_3_Copy1.ItemsSource = q22.ToList();

            //cell 3
            txtb5_3.ItemsSource = q10.ToList();
            txtb5_3_Copy.ItemsSource = q11.ToList();

            var q23 = from c in db.Rooms
                      where c.RoomID == 11
                      select c.RoomCode;

            txtb5_3_Copy1.ItemsSource = q23.ToList();

            //cell 4
            txtb7_3.ItemsSource = q4.ToList();
            txtb7_3_Copy.ItemsSource = q5.ToList();

            var q24 = from c in db.Rooms
                      where c.RoomID == 6
                      select c.RoomCode;

            txtb7_3_Copy1.ItemsSource = q24.ToList();

            //cell 5
            txtb8_3.ItemsSource = q4.ToList();
            txtb8_3_Copy.ItemsSource = q5.ToList();
            txtb8_3_Copy1.ItemsSource = q24.ToList();

            //cell 6
            txtb9_3.ItemsSource = q7.ToList();
            txtb9_3_Copy.ItemsSource = q8.ToList();

            var q25 = from c in db.Rooms
                      where c.RoomID == 8
                      select c.RoomCode;

            txtb9_3_Copy1.ItemsSource = q25.ToList();

            // Thursday information loaded
            //cell 1
            txtb1_4.ItemsSource = q17.ToList();
            txtb1_4_Copy.ItemsSource = q18.ToList();

            var q26 = from c in db.Rooms
                      where c.RoomID == 16
                      select c.RoomCode;

            txtb1_4_Copy1.ItemsSource = q26.ToList();

            //cell 2
            txtb2_4.ItemsSource = q17.ToList();
            txtb2_4_Copy.ItemsSource = q18.ToList();
            txtb2_4_Copy1.ItemsSource = q26.ToList();

            //cell 3
            txtb3_4.ItemsSource = q13.ToList();
            txtb3_4_Copy.ItemsSource = q14.ToList();

            var q27 = from c in db.Rooms
                      where c.RoomID == 13
                      select c.RoomCode;

            txtb3_4_Copy1.ItemsSource = q27.ToList();

            //cell 4
            txtb4_4.ItemsSource = q13.ToList();
            txtb4_4_Copy.ItemsSource = q14.ToList();
            txtb4_4_Copy1.ItemsSource = q27.ToList();

            //cell 5
            txtb5_4.ItemsSource = q13.ToList();
            txtb5_4_Copy.ItemsSource = q14.ToList();
            txtb5_4_Copy1.ItemsSource = q27.ToList();

            // Friday information loaded
            //cell 1
            txtb1_5.ItemsSource = q1.ToList();
            txtb1_5_Copy.ItemsSource = q2.ToList();

            var q28 = from c in db.Rooms
                      where c.RoomID == 3
                      select c.RoomCode;

            txtb1_5_Copy1.ItemsSource = q28.ToList();

            //cell 2
            txtb2_5.ItemsSource = q1.ToList();
            txtb2_5_Copy.ItemsSource = q2.ToList();
            txtb2_5_Copy1.ItemsSource = q28.ToList();

            img_SligoIT.Source = new BitmapImage(new Uri("https://www.oceanfm.ie/wp-content/uploads/2016/06/it-sligo-logo.jpg"));

        }
        // creating modules obj
        // Monday modules
        // Module mon_OOD = new Module("Object Oriented Development", "Keith Mc Manus", "A0006", new DateTime(2020, 01, 01, 10, 00, 0), new DateTime(2020, 01, 01, 11, 00, 0));
        // Module mon_Maths = new Module("Mathematics 3", "Francis O'Regan", "E0011", new DateTime(2020, 01, 01, 15, 00, 0), new DateTime(2020, 01, 01, 16, 00, 0));
        // Module mon_SQT = new Module("Software Quality and Testing", "Vivion Kinsella", "C1002", new DateTime(2020, 01, 01, 16, 00, 0), new DateTime(2020, 01, 01, 18, 00, 0));

        // Tuesday modules
        // Module tues_Web1 = new Module("Web Programming 1", "Kevin Peyton", "E0011", new DateTime(2020, 01, 01, 09, 00, 0), new DateTime(2020, 01, 01, 10, 00, 0));
        // Module tues_Cloud = new Module("Intro to Cloud Computing", "Colm Davey", "A0004", new DateTime(2020, 01, 01, 10, 00, 0), new DateTime(2020, 01, 01, 11, 00, 0));
        // Module tues_Web2 = new Module("Web Programming 1", "Kevin Peyton", "B1041", new DateTime(2020, 01, 01, 15, 00, 0), new DateTime(2020, 01, 01, 17, 00, 0));
        // Module tues_DBase = new Module("Intro to Database Management ", "Padraig Harte", "C1006", new DateTime(2020, 01, 01, 17, 00, 0), new DateTime(2020, 01, 01, 18, 00, 0));

        // Wednesday modules
        // Module wed_OOD = new Module("Object Oriented Development", "Keith Mc Manus", "B1042", new DateTime(2020, 01, 01, 9, 00, 0), new DateTime(2020, 01, 01, 10, 00, 0));
        // Module wed_Maths1 = new Module("Mathematics 3", "Francis O'Regan", "C1006", new DateTime(2020, 01, 01, 11, 00, 0), new DateTime(2020, 01, 01, 12, 00, 0));
        // Module wed_DBase = new Module("Intro to Database Management ", "Padraig Harte", "E0017", new DateTime(2020, 01, 01, 12, 00, 0), new DateTime(2020, 01, 01, 01, 00, 0));
        // Module Wed_Web = new Module("Web Programming 1", "Kevin Peyton", "D2039", new DateTime(2020, 01, 01, 13, 00, 0), new DateTime(2020, 01, 01, 14, 00, 0));
        // Module wed_Maths2 = new Module("Mathematics 3", "Francis O'Regan", "E0011", new DateTime(2020, 01, 01, 15, 00, 0), new DateTime(2020, 01, 01, 17, 00, 0));
        // Module wed_SQT = new Module("Software Quality and Testing", "Vivion Kinsella", "A0005", new DateTime(2020, 01, 01, 17, 00, 0), new DateTime(2020, 01, 01, 18, 00, 0));

        // Thursday modules
        // Module thurs_DBase = new Module("Intro to Database Management ", "Padraig Harte", "E0029", new DateTime(2020, 01, 01, 9, 00, 0), new DateTime(2020, 01, 01, 11, 00, 0));
        // Module thurs_Cloud = new Module("Intro to Cloud Computing", "Colm Davey", "D2037", new DateTime(2020, 01, 01, 11, 00, 0), new DateTime(2020, 01, 01, 14, 00, 0));

        // Friday modules
        // Module fri_OOD = new Module("Object Oriented Development", "Keith Mc Manus", "D2036", new DateTime(2020, 01, 01, 9, 00, 0), new DateTime(2020, 01, 01, 11, 00, 0));

        // adding modules to list
        // AllModule.Add(mon_OOD);
        // AllModule.Add(mon_Maths);
        // AllModule.Add(mon_SQT);

        // AllModule.Add(tues_Web1);
        // AllModule.Add(tues_Cloud);
        // AllModule.Add(tues_Web2);
        // AllModule.Add(tues_DBase);

        // AllModule.Add(wed_OOD);
        // AllModule.Add(wed_Maths1);
        // AllModule.Add(wed_DBase);
        // AllModule.Add(Wed_Web);
        // AllModule.Add(wed_Maths2);
        // AllModule.Add(wed_SQT);

        // AllModule.Add(thurs_DBase);
        // AllModule.Add(thurs_Cloud);

        // AllModule.Add(fri_OOD);

        // MonModule.Add(mon_OOD);
        // MonModule.Add(mon_Maths);
        // MonModule.Add(mon_SQT);

        // TuesModule.Add(tues_Web1);
        // TuesModule.Add(tues_Cloud);
        // TuesModule.Add(tues_Web2);
        // TuesModule.Add(tues_DBase);

        // WedModule.Add(wed_OOD);
        // WedModule.Add(wed_Maths1);
        // WedModule.Add(wed_DBase);
        // WedModule.Add(Wed_Web);
        // WedModule.Add(wed_Maths2);
        // WedModule.Add(wed_SQT);

        // ThursModule.Add(thurs_DBase);
        // ThursModule.Add(thurs_Cloud);

        // FriModule.Add(fri_OOD);


        // sorting modules
        // AllModule.Sort();


        // use a data template???
        //txtb1_1.Text = "Jamie";


        // LstBx_Module.ItemsSource = AllModule.ToList();

        private void LstBx_Module_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Module selectedModule = LstBx_Module.SelectedItem as Module;
            //if (selectedModule != null)
            //{
            //    TxtBl_Lectuer.Text = ($"Lecturer:\t {selectedModule.Lecturer}");
            //    TxtBl_Room.Text = ($"Room:\t {selectedModule.Room}");
            //    TxtBl_Time.Text = ($"Time:\t {selectedModule.TimeStart.ToShortTimeString()} - {selectedModule.TimeEnd.ToShortTimeString()}");
            //}
            
        }

        private void Refresh()
        {
            // puts itemsource to null, sorts the selected activites and checks what has been changed
            //LstBx_Module.ItemsSource = null;
            //AllModule.Sort();
            //LstBx_Module.ItemsSource = AllModule.ToList();

        }

        //private void RefreshAgain()
        //{
        //    //checks if what radio is checked, and displays according to choice 
        //    if (Rad_Mon.IsChecked == true)
        //    {
        //        //without this null the objects would not remove from lists when they are moved over to the other list
        //        LstBx_Module.ItemsSource = null;
        //        LstBx_Module.ItemsSource = MonModule;
        //    }
        //    else if (Rad_Tues.IsChecked == true)
        //    {
        //        LstBx_Module.ItemsSource = null;
        //        LstBx_Module.ItemsSource = TuesModule;
        //    }
        //    else if (Rad_Wed.IsChecked == true)
        //    {
        //        LstBx_Module.ItemsSource = null;
        //        LstBx_Module.ItemsSource = WedModule;
        //    }
        //    else if (Rad_Thurs.IsChecked == true)
        //    {
        //        LstBx_Module.ItemsSource = null;
        //        LstBx_Module.ItemsSource = ThursModule;
        //    }
        //    else if (Rad_Fri.IsChecked == true)
        //    {
        //        LstBx_Module.ItemsSource = null;
        //        LstBx_Module.ItemsSource = FriModule;
        //    }
        //    else
        //    {
        //        LstBx_Module.ItemsSource = null;
        //    }
        //}

        private void Rad_Mon_Checked(object sender, RoutedEventArgs e)
        {
            //if (Rad_Mon.IsChecked == true)
            //{
            //    //without this null the objects would not remove from lists when they are moved over to the other list
            //    LstBx_Module.ItemsSource = null;
            //    LstBx_Module.ItemsSource = MonModule;
            //}
        }
    }
}
