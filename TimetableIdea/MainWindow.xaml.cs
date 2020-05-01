using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Newtonsoft.Json;

namespace TimetableIdea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /****** Jamie Donohoe     ******
         ****** Student Timetable ******/

        // allows me to use the database I created
        TimetableData db = new TimetableData();
        
        //Random for use in a methood
        static Random rng = new Random();

        //My lists used in various methods
        List<Task> AllTask = new List<Task>();
        List<Notice> AllNotice = new List<Notice>();
        List<CA> AllCA = new List<CA>();
        List<CA> SelectedCAList = new List<CA>();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Timetable info loaded
            DataToTimetable();

            //Creates and adds Notice objects to list 
            NoticeMethod();

            //Creates and adds Task objects to list
            TaskMethod();

            //Creates and adds CA objects to list
            CATrackerMethod();

            //Adds Subjects to the ComboBox
            ComboBoxData();

            //Loads Images from an S3 bucket to the application
            S3BucketImages();

            //Assigns todays date to a label
            DateBox();
        }

        //Timetable Methods
        public void DataToTimetable()
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
        }

        //Notice methods
        private void NoticeMethod()
        {
            //Creating notice objects
            Notice n1 = new Notice("Monday Bank holiday", "College closed", new DateTime(2020, 04, 05));
            Notice n2 = new Notice("Meetings, no class", "Cloud Computing", new DateTime(2020, 04, 07));
            Notice n3 = new Notice("Guest Speaker", "Database", new DateTime(2020, 04, 10));

            //adding Notice to list
            AllNotice.Add(n1);
            AllNotice.Add(n2);
            AllNotice.Add(n3);

            //Sending list to be displayed
            LstBx_notice.ItemsSource = AllNotice.ToList();
        }

        private void LstBx_notice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // user selected item
            Notice selectedNotice = LstBx_notice.SelectedItem as Notice;

            if (selectedNotice != null)
            {
                //sets textbox based on the selected item
                string NoticeTxt = $"Date posted: {selectedNotice.NoticeDate.ToShortDateString()}";
                txtB_notice.Text = NoticeTxt;
            }
        }

        //Tasks methods
        private void TaskMethod()
        {
            //Creating Task objects
            Task t1 = new Task("Rewrite Maths Notes", "Rewrite maths notes as the first ones are very messy and hard to read.", "Mathematics 3", new DateTime(2020, 04, 05));
            Task t2 = new Task("Better Understand VPC", "Do more research into VPC and gain a better understanding of I, I dont fully understand it.", "Cloud Computing", new DateTime(2020, 04, 07));
            Task t3 = new Task("Extension Database CA1", "Feeling under pressure with current amount of projects and feel I need more time.", "Database Management", new DateTime(2020, 04, 10));
            Task t4 = new Task("Study for MCQ", "Study for the upcoming MCQ, it will be about Whitebox testing", "Software Quality Testing", new DateTime(2020, 04, 05));

            //adding Tasks to list
            AllTask.Add(t1);
            AllTask.Add(t2);
            AllTask.Add(t3);
            AllTask.Add(t4);

            //Sending list to be displayed
            LstBx_Task.ItemsSource = AllTask.ToList();
        }

        private void LBx_tasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // user selected item
            Task selectedTask = LstBx_Task.SelectedItem as Task;

            if (selectedTask != null)
            {
                //sets textbox based on the selected item
                txtb_description.Text = selectedTask.TaskGoal;
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // user selected item
            Task selectedTask = LstBx_Task.SelectedItem as Task;

            if (selectedTask != null || selectedTask == null)
            {
                //removes the selected task from the list
                AllTask.Remove(selectedTask);

                //reset the list
                LstBx_Task.ItemsSource = null;
                LstBx_Task.ItemsSource = AllTask;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Create task object using random method
            Task t1 = GetRandomTask();

            //writing to a json file
            string data = JsonConvert.SerializeObject(t1, Formatting.Indented);

            using (StreamWriter sw = new StreamWriter("c:/RandomData.json"))
            {
                sw.Write(data);
                sw.Close();
            }

            //add to list
            AllTask.Add(t1);         

            //reset and display list in list box
            LstBx_Task.ItemsSource = null;
            LstBx_Task.ItemsSource = AllTask.ToList();
        }

        public Task GetRandomTask()
        {
            // get random task
            // creating arrays that will be used by random
            string[] taskNameOptions = { "Study For Upcoming CA", "Check out book", "Buy Stationary" };
            string[] taskGoalOptions = { "Complete before the end of the week", "Get it done asap", "Has to be done today" };
            string[] taskSubjectOptions = { "Mathematics 3", "Database Management", "Cloud Computing", "Web Programming", "Software Quality Testing" };

            //setting random number generators
            int randomNumber1 = rng.Next(0, 3); // 0,1 or 2
            int randomNumber2 = rng.Next(0, 6); // 0,1,2,3,4,5

            //When strings are used a random value will be given to them
            string taskNamePicked = taskNameOptions[randomNumber1];
            string taskGoalPicked = taskGoalOptions[randomNumber1];
            string taskSubjectPicked = taskSubjectOptions[randomNumber2];

            //get random date in the last 30 days
            int randomNumber3 = rng.Next(0, 31); // 0 to 30
            DateTime randomDate = DateTime.Now.AddDays(-randomNumber3); // date in the last 30 days

            //create an task object with random info
            Task t = new Task(taskNamePicked, taskGoalPicked, taskSubjectPicked, randomDate);

            //return random task
            return t;
        }

        //Tracker methods
        private void CATrackerMethod()
        {
            //Creating CA objects
            CA ca1 = new CA("Angular Project", "Create a one or two page Angular Application that gets data from an API and uses it in the application", "Web Programming 1", new DateTime(2020, 07, 27, 23, 00, 00));
            CA ca2 = new CA("Personal Project", "Create a WPF application about anything you wish. Use as many topics that we have covered as possible.", "Object Oriented Development", new DateTime(2020, 07, 24, 17, 00, 00));
            CA ca3 = new CA("Final Assesment", "Look through AWS service list and choose an area that interests you and do something in that area.", "Intro To Cloud Computing", new DateTime(2020, 07, 22, 21, 00, 00));
            CA ca4 = new CA("CA2", "Use your knowledge of Stored Procedures gained in class to anwser the exercise sheet.", "Intro To Database Management", new DateTime(2020, 07, 20, 17, 00, 00));
            CA ca5 = new CA("Final Exam", "Create Angular Application that adheres to the sheet given out. Will be similar to previous labsheet.", "Web Programming 1", new DateTime(2020, 07, 18, 09, 00, 00));
            CA ca6 = new CA("Final Exam", "There will be a labsheet that you have to complete, It will be similar to something we have done.", "Object Oriented Development", new DateTime(2020, 07, 13, 10, 00, 00));
            CA ca7 = new CA("Final Exam", "All 6 questions must be attempted on the paper. The exam covers all the exercise sheets.", "Mathematics 3", new DateTime(2020, 07, 08, 10, 00, 00));
            CA ca8 = new CA("Final Exam", "You will be required to create different types of indexes and also views with statistics", "Intro To Database Management", new DateTime(2020, 07, 16, 09, 00, 00));
            CA ca9 = new CA("Final Exam", "There will be a large MCQ moodle quiz on the topics covered in the module.", "Software Quality Testing", new DateTime(2020, 07, 10, 11, 00, 00));

            //adding CA to list
            AllCA.Add(ca1);
            AllCA.Add(ca2);
            AllCA.Add(ca3);
            AllCA.Add(ca4);
            AllCA.Add(ca5);
            AllCA.Add(ca6);
            AllCA.Add(ca7);
            AllCA.Add(ca8);
            AllCA.Add(ca9);

            //Sending list to be displayed
            //Sorts by date
            AllCA.Sort();
            LstBx_Exam.ItemsSource = AllCA.ToList();
        }

        private void LstBx_Exam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //user selected CA
            CA selectedCA = LstBx_Exam.SelectedItem as CA;

            try
            {
                if (selectedCA != null)
                {
                    //sets txtbox depending on selected CA
                    txtb_description_CA.Text = selectedCA.CADescription;

                    //sets a textbox with the remainng days before a selected CA is due 
                    TimeSpan returnedCountdown = CountdownDays(selectedCA.CADeadline);
                    txtbx_countdown.Content = string.Format("Days Left: {0}", returnedCountdown.Days);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Application has encountered an error and will now close", "Error");
                throw;
            }
            
        }

        private void Combobx_Subjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //user selected CA
            CA selectedCA = Combobx_Subjects.SelectedItem as CA;

            //calls a method that will filter the CA depending on ComboBox selection
            string filterBy = Combobx_Subjects.SelectedItem as string;
            FilterCA(filterBy);
        }

        private void FilterCA(string filterCA)
        {
            //user selected CA
            CA selectedCA = Combobx_Subjects.SelectedItem as CA;

            //clears the list before changing the output
            SelectedCAList.Clear();

            //This switch statement allows the user to choose a combobox option and then
            //it will return the the correct outputs for the selected option

            try
            {
                switch (filterCA)
                {
                    case "All":
                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = AllCA;
                        break;

                    case "Web Programming 1":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Web Programming 1")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;

                    case "Intro To Cloud Computing":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Intro To Cloud Computing")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;

                    case "Intro To Database Management":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Intro To Database Management")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;

                    case "Software Quality Testing":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Software Quality Testing")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;

                    case "Mathematics 3":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Mathematics 3")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;

                    case "Object Oriented Development":
                        foreach (CA ca in AllCA)
                        {
                            if (ca.CASubject == "Object Oriented Development")
                                SelectedCAList.Add(ca);
                        }

                        LstBx_Exam.ItemsSource = null;
                        LstBx_Exam.ItemsSource = SelectedCAList;
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The Application has encountered an error and will now close", "Error");
                throw;
            }
            
        }

        public static TimeSpan CountdownDays(DateTime caDate)
        {
            //This method returns the remaining days betwenn today and the CA deadline
            try
            {
                DateTime start = DateTime.Today;
                DateTime end = caDate;

                TimeSpan difference = end - start; //create TimeSpan object

                return difference;
            }
            catch (Exception)
            {
                MessageBox.Show("The Application has encountered an error and will now close", "Error");
                throw;
            }
            
        }
        private void ComboBoxData()
        {
            //Filling ComboBox for CA tracker
            Combobx_Subjects.Items.Add("All");
            Combobx_Subjects.Items.Add("Web Programming 1");
            Combobx_Subjects.Items.Add("Intro To Cloud Computing");
            Combobx_Subjects.Items.Add("Intro To Database Management");
            Combobx_Subjects.Items.Add("Software Quality Testing");
            Combobx_Subjects.Items.Add("Mathematics 3");
            Combobx_Subjects.Items.Add("Object Oriented Development");
        }

        //Images and date box
        private void S3BucketImages()
        {
            img_SligoIT.Source = new BitmapImage(new Uri("https://oods00189802.s3-eu-west-1.amazonaws.com/OODTimeTableIMG/it-sligo-logo.jpg"));
            img_SligoITp2.Source = new BitmapImage(new Uri("https://oods00189802.s3-eu-west-1.amazonaws.com/OODTimeTableIMG/it-sligo-logo.jpg"));
            img_topimg1.Source = new BitmapImage(new Uri("https://oods00189802.s3-eu-west-1.amazonaws.com/OODTimeTableIMG/Invest-slider-SligoIT4.jpg"));
            img_topimg2.Source = new BitmapImage(new Uri("https://oods00189802.s3-eu-west-1.amazonaws.com/OODTimeTableIMG/Invest-slider-SligoIT3.jpg"));
            img_topimg3.Source = new BitmapImage(new Uri("https://oods00189802.s3-eu-west-1.amazonaws.com/OODTimeTableIMG/SligoITStudents.jpg"));
        }
        private void DateBox()
        {
            Label_dattime_p1.Content = DateTime.Now.ToShortDateString();
            Label_dattime.Content = DateTime.Now.ToShortDateString();

        }

    }
}

