using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

/*
 * Registrar Scheduling Tool
 * Author: Robert Shelton
 * Date: 9/21/2017
 * 
 * This is a temporary tool for the Registrar's Office to schedule recurring events. 
 * The tool is a windows form that allows for the entering of all pertinent data 
 * about the event and exports it to an Excel Spreadsheet using the COM Interop Excel Library.
 * The form can be cleared and reused as many times as a user needs. 
 */

namespace Registrar_Scheduling_Tool
{
    public partial class SchedulingTool : Form
    {
        DateTime startDate;
        DateTime endDate;
        DateTime startTime;
        DateTime endTime;
        List<DayOfWeek> daysOfWeek = new List<DayOfWeek>();
        string eventID;
        string description;
        string shortDescr;
        string meetingType;
        string comment;
        string coordinatorID;
        string meetingLocation;
        string facilityID;

        string filePath = null;
        

        public SchedulingTool()
        {
            InitializeComponent();
            //Setting the format for the time pickers to hours:minutes instead of a date.
            //Setting this to 24 hour time is done in the custom format string. H is 24 hour, h is twelve hour.
            startTimePicker.ShowUpDown = true;
            startTimePicker.CustomFormat = "HH:mm";
            startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            startTimePicker.Value = new DateTime(1754, 1, 1, 0, 0, 0);

            endTimePicker.ShowUpDown = true;
            endTimePicker.CustomFormat = "HH:mm";
            endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            endTimePicker.Value = new DateTime(1754, 1, 1, 0, 0, 0);

            startDatePicker.CustomFormat = "MM/dd/yyyy";
            startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            startDatePicker.Text = "";

            endDatePicker.CustomFormat = "MM/dd/yyyy";
            endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            //Set the text in the title of the window
            this.Text = "Registrar Scheduling Tool";
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                var excelApp       = new Excel.Application();
                excelApp.Visible = true;
                var excelWorkbook  = excelApp.Workbooks.Open(@filePath);
                var excelWorksheet = excelWorkbook.Sheets[1];
                var excelRange     = excelWorksheet.UsedRange;
                var outputWorkbook = (Microsoft.Office.Interop.Excel._Workbook)excelApp.Workbooks.Add();
                var outputWorksheet = (Microsoft.Office.Interop.Excel._Worksheet)outputWorkbook.ActiveSheet;
                int count = 0;
                for(int i = 2; i <= excelRange.Rows.Count; i++)
                {
                    eventID         = excelRange.Cells[i, "A"].Value.ToString();
                    meetingType     = "MTG";
                    comment         = excelRange.Cells[i, "C"].Value.ToString();
                    coordinatorID   = "";
                    meetingLocation = "C";
                    facilityID      = excelRange.Cells[i, "B"].Value.ToString();
                    startDate       = Convert.ToDateTime(excelRange.Cells[i, "D"].Value.ToString());
                    endDate         = Convert.ToDateTime(excelRange.Cells[i, "E"].Value.ToString());
                    startTime       = Convert.ToDateTime(excelRange.Cells[i, "F"].Value.ToString());
                    endTime         = Convert.ToDateTime(excelRange.Cells[i, "G"].Value.ToString());

                    if (excelRange.Cells[i, "H"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Sunday);
                    }
                    if (excelRange.Cells[i, "I"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Monday);
                    }
                    if (excelRange.Cells[i, "J"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Tuesday);
                    }
                    if (excelRange.Cells[i, "K"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Wednesday);
                    }
                    if (excelRange.Cells[i, "L"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Thursday);
                    }
                    if (excelRange.Cells[i, "M"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Friday);
                    }
                    if (excelRange.Cells[i, "N"].Value.ToString() == "Y")
                    {
                        daysOfWeek.Add(DayOfWeek.Saturday);
                    }

                    var dates = Enumerable.Range(0, (int)(endDate - startDate).TotalDays + 1)
                      .Select(x => startDate.AddDays(x))
                      .ToList();
                    //Function to remove all the dates from our range that don't occur on days of the week the user picked.
                    dates.RemoveAll(
                        date => !daysOfWeek.Contains(date.DayOfWeek)
                    );
                    daysOfWeek.Clear();
                    int meetingNumber = 10;
                    int toAdd = count;
                    outputWorksheet.Cells[1, "A"] = "Event ID";
                    outputWorksheet.Cells[1, "B"] = "Meeting Number";
                    outputWorksheet.Cells[1, "C"] = "Description";
                    outputWorksheet.Cells[1, "D"] = "Short Description";
                    outputWorksheet.Cells[1, "E"] = "Meeting Type";
                    outputWorksheet.Cells[1, "F"] = "Meeting Date";
                    outputWorksheet.Cells[1, "G"] = "Meeting Start Time";
                    outputWorksheet.Cells[1, "H"] = "Meeting End Time";
                    outputWorksheet.Cells[1, "I"] = "Campus Meeting Location";
                    outputWorksheet.Cells[1, "J"] = "Facility ID";
                    outputWorksheet.Cells[1, "K"] = "Campus Coordinator EMPLID";
                    outputWorksheet.Cells[1, "L"] = "Comment";
                    int dateIndex = 0;
                    for (int j = 2 + toAdd; j <= dates.Count + toAdd + 1; j++)
                    {
                        
                        outputWorksheet.Cells[j, "A"].NumberFormat = "@";
                        outputWorksheet.Cells[j, "A"] = eventID;
                        outputWorksheet.Cells[j, "B"] = meetingNumber;

                        outputWorksheet.Cells[j, "E"] = meetingType;

                        //These have the same character coding for format as the datetimepicker at the top. 
                        outputWorksheet.Cells[j, "F"] = dates[dateIndex].ToString("MM/dd/yyyy");
                        dateIndex++;
                        outputWorksheet.Cells[j, "G"] = startTime.ToString("HH:mm");
                        outputWorksheet.Cells[j, "H"] = endTime.ToString("HH:mm");

                        outputWorksheet.Cells[j, "I"] = meetingLocation;
                        outputWorksheet.Cells[j, "J"] = facilityID;
                        outputWorksheet.Cells[j, "K"] = coordinatorID;
                        outputWorksheet.Cells[j, "L"] = comment;
                        ((Excel.Range)outputWorksheet.Columns[i]).AutoFit();
                        meetingNumber++;
                        count++;
                    }
                    
                }
            }
            else
            {
                eventID         = eventIDBox.Text;
                meetingType     = "MTG";
                comment         = commentsBox.Text;
                coordinatorID   = coordinatorIDBox.Text;
                meetingLocation = "C";
                facilityID      = facilityIDBox.Text;
                startDate       = startDatePicker.Value;
                endDate         = endDatePicker.Value;
                startTime       = startTimePicker.Value;
                endTime         = endTimePicker.Value;


                //Checking to see what days the user checked in the form. 
                //Add the days to a list for checking against later.
                if (sundayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Sunday);
                }
                if (mondayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Monday);
                }
                if (tuesdayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Tuesday);
                }
                if (wednesdayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Wednesday);
                }
                if (thursdayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Thursday);
                }
                if (fridayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Friday);
                }
                if (saturdayCheckBox.Checked)
                {
                    daysOfWeek.Add(DayOfWeek.Saturday);
                }

                //Helper method to check if all mandatory fields are full
                bool isValid = ValidateFields();
                //if fields are valid, we're good to generate the spreadsheet. 
                if (isValid)
                {
                    DisplayInExcel();
                }
                //clear out the list of days at the end so if they re-run the program they won't get carryover days
                daysOfWeek.Clear();
            }
        }
        private bool ValidateFields()
        {
            //clear any previously visible error labels
            endTimeErrorLabel.Visible = false;
            endDateErrorLabel.Visible = false;
            
            //Boolean reflecting whether or not all fields are valid
            bool toReturn = true;

            /*
             * We only have to look at the fields in the left side of the form because
             * those are the only text fields. We're not checking to see if they selected
             * any days of the week because that will be reflected when they export the 
             * form and there are no meetings. It should be easy for a user to just go back
             * and add days of the week if that happens.
             */
            foreach (Control ctl in splitContainer1.Panel1.Controls)
            {
                //There are only text boxes in the form, this is just in case something else got added in the future.
                if (ctl is TextBox || ctl is MaskedTextBox)
                {
                    //coordinator ID isn't a mandatory field per customer request, so it is being manually removed.
                    //I wasn't sure whether empty fields read as null or empty strings, so I checked for both. 
                    //If strings with only spaces become a problem, that could either be changed here, or by 
                    //changing the text fields themselves to Masked Text Boxes. This allows us to mandate certain
                    //types of characters in the field. 
                    if (ctl.Text.Equals(null) || ctl.Text.Equals("") && ctl.Name != "coordinatorIDBox")
                    { 
                        ctl.BackColor = Color.Red;
                        //This is the error message that displays at the bottom left of the form. 
                        lblErrorMessage.Visible = true;
                        lblErrorMessage.Text = "Mandatory fields must be filled.";
                        lblErrorMessage.ForeColor = Color.Red;
                        toReturn = false;
                    }
                    else
                    {
                        //If the field is populated, set its color to white and move on.
                        ctl.BackColor = Color.White;
                    }
                }
            }
            //making sure we're not going backwards in time with our start and end dates.
            if (DateTime.Compare(startDate, endDate) > 0)
            {
                endDateErrorLabel.Visible = true;
                //Asterisk displays to the right of the field that's messed up.
                endDateErrorLabel.Text = "*";
                /*this one overwrites the error message at the bottom. Because of the ordering in the code, 
                 * the end time error takes highest priority. Every time they fix one problem and hit export again, 
                 * the error message will change to the next thing they need to fix. If they do it all at once, 
                 * it will just run.
                 */ 
                
                lblErrorMessage.Text = "End Date must be after Start Date";
                endDateErrorLabel.ForeColor = Color.Red;
                toReturn = false;
            }
            //same comparison for the start and end time. 
            if (DateTime.Compare(startTime, endTime) > 0)
            {
                endTimeErrorLabel.Visible = true;
                //Same deal as above
                endTimeErrorLabel.Text = "*";
                lblErrorMessage.Text = "End Time must be after Start Time";
                endTimeErrorLabel.ForeColor = Color.Red;
                toReturn = false;
            }
            //If none of the validations failed, set the error field to green and pass out true
            if (toReturn == true)
            {
                lblErrorMessage.Text = "All fields are filled.";
                lblErrorMessage.ForeColor = Color.Green;
            }
            return toReturn;
  
        }
        //This is the method that builds the excel spreadsheet itself.
        private void DisplayInExcel()
        {
            //COM Interop library helps us out here. See Docs for how that works. 
            var excelApp = new Excel.Application();
            
            //We could do all this work in the background and then make it visible, but I like seeing excel build 
            //the spreadsheet in front of me
            excelApp.Visible = true;
            
            //Make a workbook to do this in
            excelApp.Workbooks.Add();

            //pick a worksheet to use in our workbook
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            //This generates a range of dates in between the start and end date.
            var dates = Enumerable.Range(0, (int)(endDate - startDate).TotalDays + 1)
                      .Select(x => startDate.AddDays(x))
                      .ToList();
            //Function to remove all the dates from our range that don't occur on days of the week the user picked.
            dates.RemoveAll(
                date => !daysOfWeek.Contains(date.DayOfWeek)
            );

            //Making our titles for the columns.
            workSheet.Cells[1, "A"] = "Event ID";
            workSheet.Cells[1, "B"] = "Meeting Number";
            workSheet.Cells[1, "C"] = "Description";
            workSheet.Cells[1, "D"] = "Short Description";
            workSheet.Cells[1, "E"] = "Meeting Type";
            workSheet.Cells[1, "F"] = "Meeting Date";
            workSheet.Cells[1, "G"] = "Meeting Start Time";
            workSheet.Cells[1, "H"] = "Meeting End Time";
            workSheet.Cells[1, "I"] = "Campus Meeting Location";
            workSheet.Cells[1, "J"] = "Facility ID";
            workSheet.Cells[1, "K"] = "Campus Coordinator EMPLID";
            workSheet.Cells[1, "L"] = "Comment";
            
            //Make excel fit all the text in the columns. 
            ((Excel.Range)workSheet.Columns[1]).AutoFit();

            //meeting number starts at 10 per customer request. 
            int meetingNumber = 10;

            //looping through the rows in the spreadsheet and populating our data. 
            for (int i = 2; i <= dates.Count + 1; i++)
            {
                workSheet.Cells[i, "A"].NumberFormat = "@";
                workSheet.Cells[i, "A"] = eventID;
                workSheet.Cells[i, "B"] = meetingNumber;
               

                workSheet.Cells[i, "E"] = meetingType;

                //These have the same character coding for format as the datetimepicker at the top. 
                workSheet.Cells[i, "F"] = dates[i - 2].ToString("MM/dd/yyyy");
                workSheet.Cells[i, "G"] = startTime.ToString("HH:mm");
                workSheet.Cells[i, "H"] = endTime.ToString("HH:mm");

                workSheet.Cells[i, "I"] = meetingLocation;
                workSheet.Cells[i, "J"] = facilityID;
                workSheet.Cells[i, "K"] = coordinatorID;
                workSheet.Cells[i, "L"] = comment;
                ((Excel.Range)workSheet.Columns[i]).AutoFit();
                meetingNumber++;
            } 
        }

        //Handler for the clear button. Removes all data from text fields and resets pickers to current time/date.
        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in splitContainer1.Panel1.Controls)
            {
                if (ctl is TextBox || ctl is RichTextBox)
                {
                    ctl.Text = "";
                    ctl.BackColor = Color.White;
                }
            }
            //Uncheck boxes. daySelector is a grouping I added in the Design tab to avoid typecasting errors. 
            foreach (CheckBox box in daySelector.Controls)
            {
                box.Checked = false;
            }
            //dateTimeBox is the same deal as daySelector.
            foreach(var dtp in dateTimeBox.Controls.OfType<DateTimePicker>())
            {
                dtp.Value = DateTime.Now;
                if(dtp.Name.Equals("startTimePicker") || dtp.Name.Equals("endTimePicker"))
                {
                   dtp.Value = new DateTime(1754, 1, 1, 0, 0, 0);
                }
            }
            lblErrorMessage.Visible = false;
            endDateErrorLabel.Visible = false;
            endTimeErrorLabel.Visible = false;
        }

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                label1.Text = filePath;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
