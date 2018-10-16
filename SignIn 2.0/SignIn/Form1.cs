using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SignIn
{
    public partial class StudentSignInWindow : Form
    {
        static String PATH; //Path for creation of the log file
        static String currentFile; //Path and file currently in use
        static Boolean login = true; //To work out log entry is a login or logout
        public StudentSignInWindow()
        {
            InitializeComponent();
            txtEntryBox.KeyDown += new KeyEventHandler(txtEntryBox_KeyDown); //Allows manual entry of student ID          
        }

        private void txtEntryBox_TextChanged(object sender, EventArgs e){}

        private void createDaysLog()
        {
            PATH = @"G:\ChchAttendance\"; //Location of log files
            String date = DateTime.Now.Date.ToString("MM/dd/yyyy"); //Formats the date so the log files are stored sequentially
            date = date.Replace(@"/", string.Empty);//Removes slashes from file name
            
            String fileName = PATH + date + ".txt"; //Creates the file name
            currentFile = fileName; //Sets it as the current log file
            if (!File.Exists(fileName)) //Checks if file already exists...
            {
                File.Create(fileName);//...and creates it if it doesn't
                currentFile = fileName;
            }            
        }

        private void logEntry() //Creates the log entry
        {
            lastEntry(); //Checks if last entry for this student was an in or out
            string inOut; //For use in the entry text
            if (login) {
                inOut = "in";
            }
            else
            {
                inOut = "out";
            }
            String timeStamp = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString(); //Creates the timestamp
            String entry = "\r\n" + txtEntryBox.Text + "," + timeStamp +"," + inOut; //Creates the log entry string
            File.AppendAllText(currentFile, entry); //Adds it to the log file
        }

        private void txtEntryBox_KeyDown(object sender, KeyEventArgs e) //Enter key event
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtEntryBox.Text.Equals("quit")) //quits the program
                {
                    Application.Exit();
                }
                else
                {
                    //Methods called to check, validate and enter the log entry
                    createDaysLog();
                    logEntry();
                    successMessage();
                    closeMessage();
                }
            }
        }

        private void successMessage()
        {            
            //Provides a message for display to confirm successful login/logout by student
            String student = txtEntryBox.Text;
            lblSuccessMessage.BackColor = System.Drawing.Color.Transparent;
            lblSuccessMessage.Visible = true;
            if (login)
            {
                lblSuccessMessage.ForeColor = System.Drawing.Color.GreenYellow;
                lblSuccessMessage.Text = student + " logged in successfully!";
            }
            else
            {
                lblSuccessMessage.ForeColor = System.Drawing.Color.Pink;
                lblSuccessMessage.Text = student + " logged out successfully!";
            }
            txtEntryBox.Text = "";
        }

        private void closeMessage() //Clears the message from the entry textbox after hald a second
        {
            
            System.Threading.Tasks.Task.Delay(2500).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() => {
                    lblSuccessMessage.Text = "";
                    lblSuccessMessage.Visible = false;
                }));
                //lblSuccessMessage.Visible = false
            });
        }

        private void lastEntry() //Checks the previous entry (if any) for student logging in
        {
            try
            {
                login = true; //So first login if caught
                String fileData = null;
                String student = txtEntryBox.Text;
                using (StreamReader reader = File.OpenText(currentFile)) //Reads the log file
                {
                    fileData = reader.ReadToEnd();
                }
                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); //Just in case there is some mac weilding weirdo in the house

                foreach (String line in lines) //Iterates through the log file to find last entry for student signing in
                {
                    string[] columnData = line.Split(',');
                    if (columnData[0].Equals(student))
                    {
                        if (columnData[2].Equals("in")) //Means last entry for student was a login
                        {
                            login = false;
                        }
                        else if (columnData[2].Equals("out"))//Means last entry for student was a logout
                        {
                            login = true;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("It would appear that the file with student information is not available. Please " +
                    "let a tutor know the login system is down", "We had an oopsie!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
