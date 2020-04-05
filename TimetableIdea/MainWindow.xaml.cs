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
            var query1 = from c in db.Lecturers
                         where Name == "Colm Davey"
                         select c;

            //txtb1_1.ItemsSource = query1.ToList();

            var results = query1.ToString();

            txtb1_1.Text = results;
            //txtb1_1.Text = string.Format(string line1 = @"First Line
            //                                            Second Line
            //                                            Third Line
            //                                            Forth Line";)


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

        // img_SligoIT.Source = new BitmapImage(new Uri("https://www.oceanfm.ie/wp-content/uploads/2016/06/it-sligo-logo.jpg"));

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
