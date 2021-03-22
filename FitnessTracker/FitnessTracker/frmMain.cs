using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Marlene M. Boyce 
 * Class: CMPS 480 ULV
 * Due Date: 23 March 2021
 * Problem: Create GUI app with multiple panels, insert data, iterate data, and search
 * Total time spent on project: 10-12 hours LOL
 */

namespace FitnessTracker
{
    public partial class frmMain : Form
    {
        //MBoyce NEW 1L: List is created to hold all panels created
        List<Panel> listPanel = new List<Panel>();

        //MBoyce NEW 1L: List created to hold all workout objects
        List<Workout> workouts = new List<Workout>();

        //MBoyce NEW 1L: wIndex created iterate the workout list in the view panel 
        int wIndex;
        
        public frmMain()
        {
            InitializeComponent();
        }

         // MBoyce NEW 18L: All panels are added and home panel is brought to front
         // Then if statement is executed to load and set current workout ID
        
        private void frmHome_Load(object sender, EventArgs e)
        {
            listPanel.Add(panelHome);

            listPanel.Add(panelAdd);

            listPanel.Add(panelView);

            listPanel.Add(panelReport);

            listPanel[0].BringToFront();

            // Load the last Workout ID value
            if (workouts.Count == 0)
            {
                if (!File.Exists("CurrentID.txt"))
                    CreateIdFile();

                FileInfo info = new FileInfo("CurrentID.txt");

                FileStream fs = info.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

                StreamReader sr = new StreamReader(fs);

                Workout.Counter = int.Parse(sr.ReadToEnd());

                sr.Close();
            }
        }

        //MBoyce NEW 4L: Creates file each time the whole form is closed 
        private void frmHome_FromClosing(Object sender, FormClosingEventArgs e)
        {
            CreateIdFile();
        }

        //MBoyce NEW 8L: Creates current ID file 
        private void CreateIdFile()
        {
            FileInfo info = new FileInfo("CurrentID.txt");

            FileStream fs = info.Open(FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);

            StreamWriter sw = new StreamWriter(fs);

            sw.Write(Workout.Counter.ToString());

            sw.Close();
        }

        //MBoyce NEW 6L: When user clicks "Add", "Add Panel" is brought to front 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = (Workout.Counter + 1).ToString();

            cmbRating.SelectedItem = "Easy";

            listPanel[1].BringToFront();
        }

        //MBoyce NEW 31L: Record and File Content array are created, then open file dialog box 
        //If file name is not empty, then new workout is created, and stored in list
        private bool LoadWorkouts()
        {
            string[] record = null;
            string[] fileContent = null;

            OpenFileDialog opener = new OpenFileDialog();

            opener.InitialDirectory = "../../FitnessTracker";
            opener.Filter = "Text|*.txt";
            opener.Title = "Open Workout Log";
            opener.RestoreDirectory = true;
            opener.ShowDialog();

            if (opener.FileName != "")
            {
                fileContent = File.ReadAllLines(opener.FileName);

                foreach (string line in fileContent)
                {
                    Workout w = new Workout();

                    record = line.Split(new char[] { '\t', '\n' });

                    w.ID = int.Parse(record[0]);
                    w.Name = record[1];
                    w.Rating = record[2];
                    w.Minutes = int.Parse(record[3]);
                    w.Calories = int.Parse(record[4]);

                    string[] equipment = record[5].Split(new char[] { ',' });
                    w.Equipment = new List<string>(equipment);

                    workouts.Add(w);
                }

                Workout.Counter = workouts.Last().ID;

                return true;
            }

            return false;
        }

        //MBoyce NEW 11L: When user clicks "Modify", "Modify" panel is brought to the front 
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (workouts.Count == 0)
            {
                if (!LoadWorkouts())
                    return;
            }

            wIndex = 0;

            ChangeView();

            listPanel[2].BringToFront();
        }

        //MBoyce NEW 15L: wIndex is used to iterate through the workouts list 
        private void ChangeView()
        {
            txtIdView.Text = workouts[wIndex].ID.ToString();
            txtNameView.Text = workouts[wIndex].Name;
            cmbRatingView.SelectedItem = workouts[wIndex].Rating;
            txtTimeView.Text = workouts[wIndex].Minutes.ToString();
            txtCalView.Text = workouts[wIndex].Calories.ToString();

            txtEquipmentView.Clear();

            foreach (string equipment in workouts[wIndex].Equipment)
            {
                txtEquipmentView.Text += equipment;

                if (equipment != workouts[wIndex].Equipment.Last())
                    txtEquipmentView.Text += ",";
            }
        }

        //MBoyce NEW 9L: When user clicks "Report", "Report" panel is brought to the front 
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (workouts.Count == 0)
            {
                if (!LoadWorkouts())
                    return;
            }

            listPanel[3].BringToFront();
        }

        //MBoyce NEW 4L: When user clicks "Home", Home panel is brought to the front
        private void btnHome_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

        //MBoyce NEW 21L: When user clicks "Save", the save file dialog is opened 
        //The workout is then saved to the text file
        //Each file contains workout "records"
        private void btnSave_Click(object sender, EventArgs e)
        {
            string record = txtID.Text + "\t" + txtName.Text + "\t" + cmbRating.SelectedItem + "\t" +
                            txtTime.Text + "\t" + txtCal.Text + "\t" + txtEquipment.Text + "\n";


            SaveFileDialog saver = new SaveFileDialog();
            saver.InitialDirectory = "../../FitnessTracker";
            saver.Filter = "Text|*.txt";
            saver.Title = "Save to Workout Log";
            saver.ShowDialog();

            if (saver.FileName != "")
            {
                File.AppendAllText(saver.FileName, record);

                txtID.Text = (Workout.Counter + 1).ToString();
                txtName.Clear();
                cmbRating.SelectedItem = "Easy";
                txtTime.Clear();
                txtCal.Clear();
                txtEquipment.Clear();

                // Increment the next workout count
                Workout.Counter = int.Parse(txtID.Text);
            }

        }

        //MBoyce NEW 7L: When user clicks "Back" then wIndex is decremented to display previous workout
        //Then panel is refreshed 
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wIndex > 0)
                wIndex--;
            
            ChangeView();
            
            listPanel[2].Refresh();
        }

        //MBoyce NEW 7L: When user clicks "next" then wIndex is incremented to display next workout
        //Then panel is refreshed 
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (wIndex < workouts.Count - 1)
                wIndex++;

            ChangeView();

            listPanel[2].Refresh();
        }

        //MBoyce NEW 39L: if statement is executed to verify fields are not empty
        //foreach used to iterate through each line, then appends the text
        //totals are then counted and displayed
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtStart.Text != "" && txtEnd.Text != "")
            {
                txtOutput.Clear();

                int start = int.Parse(txtStart.Text);
                int stop = int.Parse(txtEnd.Text);

                var filteredList = from w in workouts
                                   where w.ID >= start && w.ID <= stop select w;

                if (filteredList != null)
                {
                    int totalCalories = 0, totalMinutes = 0;

                    foreach (Workout w in filteredList)
                    {
                        txtOutput.AppendText("ID: " + w.ID + Environment.NewLine +
                                             "Name: " + w.Name + Environment.NewLine +
                                             "Difficultly: " + w.Rating + Environment.NewLine +
                                             "Workout Time: " + w.Minutes  + " minutes" + Environment.NewLine +
                                             "Calories Burned: " + w.Calories + Environment.NewLine +
                                             "Equipment: ");

                        totalCalories += w.Calories;
                        totalMinutes += w.Minutes;

                        foreach (string equipment in w.Equipment)
                        {
                            txtOutput.AppendText(equipment);

                            if (equipment != w.Equipment.Last())
                                txtOutput.AppendText(",");
                            else
                                txtOutput.AppendText("\r\n\r\n");
                        }

                    }

                    txtOutput.AppendText("Total Number of Workouts: " + filteredList.Count() + Environment.NewLine);
                    txtOutput.AppendText("Total Calories Burned: " + totalCalories + Environment.NewLine);
                    txtOutput.AppendText("Total Workout Time: " + totalMinutes + " minutes" + Environment.NewLine);
                }

            }

            txtStart.Clear();
            txtEnd.Clear();
        }

    }
}
