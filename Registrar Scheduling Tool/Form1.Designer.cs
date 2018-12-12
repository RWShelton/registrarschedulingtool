namespace Registrar_Scheduling_Tool
{
    partial class SchedulingTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.fileBrowserButton = new System.Windows.Forms.Button();
            this.facilityIDBox = new System.Windows.Forms.TextBox();
            this.coordinatorIDBox = new System.Windows.Forms.TextBox();
            this.eventIDBox = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.facilityIDLabel = new System.Windows.Forms.Label();
            this.coordinatorIDLabel = new System.Windows.Forms.Label();
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.eventIDLabel = new System.Windows.Forms.Label();
            this.dateTimeBox = new System.Windows.Forms.GroupBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimeErrorLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.endDateErrorLabel = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.daySelector = new System.Windows.Forms.GroupBox();
            this.sundayCheckBox = new System.Windows.Forms.CheckBox();
            this.mondayCheckBox = new System.Windows.Forms.CheckBox();
            this.tuesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.wednesdayCheckBox = new System.Windows.Forms.CheckBox();
            this.thursdayCheckBox = new System.Windows.Forms.CheckBox();
            this.fridayCheckBox = new System.Windows.Forms.CheckBox();
            this.saturdayCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.eventIDToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.dateTimeBox.SuspendLayout();
            this.daySelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.fileBrowserButton);
            this.splitContainer1.Panel1.Controls.Add(this.facilityIDBox);
            this.splitContainer1.Panel1.Controls.Add(this.coordinatorIDBox);
            this.splitContainer1.Panel1.Controls.Add(this.eventIDBox);
            this.splitContainer1.Panel1.Controls.Add(this.lblErrorMessage);
            this.splitContainer1.Panel1.Controls.Add(this.facilityIDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.coordinatorIDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.commentsBox);
            this.splitContainer1.Panel1.Controls.Add(this.commentsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.eventIDLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTimeBox);
            this.splitContainer1.Panel2.Controls.Add(this.daySelector);
            this.splitContainer1.Panel2.Controls.Add(this.clearButton);
            this.splitContainer1.Panel2.Controls.Add(this.exportButton);
            this.splitContainer1.Size = new System.Drawing.Size(632, 382);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // fileBrowserButton
            // 
            this.fileBrowserButton.Location = new System.Drawing.Point(6, 230);
            this.fileBrowserButton.Name = "fileBrowserButton";
            this.fileBrowserButton.Size = new System.Drawing.Size(100, 23);
            this.fileBrowserButton.TabIndex = 1;
            this.fileBrowserButton.Text = "Browse for File";
            this.fileBrowserButton.UseVisualStyleBackColor = true;
            this.fileBrowserButton.Click += new System.EventHandler(this.fileBrowserButton_Click);
            // 
            // facilityIDBox
            // 
            this.facilityIDBox.Location = new System.Drawing.Point(6, 61);
            this.facilityIDBox.MaxLength = 10;
            this.facilityIDBox.Name = "facilityIDBox";
            this.facilityIDBox.Size = new System.Drawing.Size(85, 20);
            this.facilityIDBox.TabIndex = 2;
            // 
            // coordinatorIDBox
            // 
            this.coordinatorIDBox.Location = new System.Drawing.Point(6, 97);
            this.coordinatorIDBox.MaxLength = 11;
            this.coordinatorIDBox.Name = "coordinatorIDBox";
            this.coordinatorIDBox.Size = new System.Drawing.Size(85, 20);
            this.coordinatorIDBox.TabIndex = 3;
            // 
            // eventIDBox
            // 
            this.eventIDBox.Location = new System.Drawing.Point(6, 25);
            this.eventIDBox.MaxLength = 9;
            this.eventIDBox.Name = "eventIDBox";
            this.eventIDBox.Size = new System.Drawing.Size(100, 20);
            this.eventIDBox.TabIndex = 1;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(3, 360);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(13, 13);
            this.lblErrorMessage.TabIndex = 23;
            this.lblErrorMessage.Text = "?";
            this.lblErrorMessage.Visible = false;
            // 
            // facilityIDLabel
            // 
            this.facilityIDLabel.AutoSize = true;
            this.facilityIDLabel.Location = new System.Drawing.Point(3, 45);
            this.facilityIDLabel.Name = "facilityIDLabel";
            this.facilityIDLabel.Size = new System.Drawing.Size(53, 13);
            this.facilityIDLabel.TabIndex = 17;
            this.facilityIDLabel.Text = "Facility ID";
            // 
            // coordinatorIDLabel
            // 
            this.coordinatorIDLabel.AutoSize = true;
            this.coordinatorIDLabel.Location = new System.Drawing.Point(3, 84);
            this.coordinatorIDLabel.Name = "coordinatorIDLabel";
            this.coordinatorIDLabel.Size = new System.Drawing.Size(75, 13);
            this.coordinatorIDLabel.TabIndex = 13;
            this.coordinatorIDLabel.Text = "Coordinator ID";
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(6, 137);
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(283, 87);
            this.commentsBox.TabIndex = 4;
            this.commentsBox.Text = "";
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.Location = new System.Drawing.Point(6, 120);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(56, 13);
            this.commentsLabel.TabIndex = 10;
            this.commentsLabel.Text = "Comments";
            // 
            // eventIDLabel
            // 
            this.eventIDLabel.AutoSize = true;
            this.eventIDLabel.Location = new System.Drawing.Point(6, 9);
            this.eventIDLabel.Name = "eventIDLabel";
            this.eventIDLabel.Size = new System.Drawing.Size(49, 13);
            this.eventIDLabel.TabIndex = 1;
            this.eventIDLabel.Text = "Event ID";
            // 
            // dateTimeBox
            // 
            this.dateTimeBox.Controls.Add(this.startDatePicker);
            this.dateTimeBox.Controls.Add(this.startDateLabel);
            this.dateTimeBox.Controls.Add(this.endDatePicker);
            this.dateTimeBox.Controls.Add(this.endTimeErrorLabel);
            this.dateTimeBox.Controls.Add(this.endDateLabel);
            this.dateTimeBox.Controls.Add(this.endTimeLabel);
            this.dateTimeBox.Controls.Add(this.endDateErrorLabel);
            this.dateTimeBox.Controls.Add(this.endTimePicker);
            this.dateTimeBox.Controls.Add(this.startTimeLabel);
            this.dateTimeBox.Controls.Add(this.startTimePicker);
            this.dateTimeBox.Location = new System.Drawing.Point(6, 3);
            this.dateTimeBox.Name = "dateTimeBox";
            this.dateTimeBox.Size = new System.Drawing.Size(261, 186);
            this.dateTimeBox.TabIndex = 18;
            this.dateTimeBox.TabStop = false;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(6, 22);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(199, 20);
            this.startDatePicker.TabIndex = 7;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(6, 6);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(6, 64);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(199, 20);
            this.endDatePicker.TabIndex = 8;
            // 
            // endTimeErrorLabel
            // 
            this.endTimeErrorLabel.AutoSize = true;
            this.endTimeErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.endTimeErrorLabel.Location = new System.Drawing.Point(211, 141);
            this.endTimeErrorLabel.Name = "endTimeErrorLabel";
            this.endTimeErrorLabel.Size = new System.Drawing.Size(20, 24);
            this.endTimeErrorLabel.TabIndex = 30;
            this.endTimeErrorLabel.Text = "?";
            this.endTimeErrorLabel.Visible = false;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(6, 48);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(6, 127);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(164, 13);
            this.endTimeLabel.TabIndex = 29;
            this.endTimeLabel.Text = "End Time (hh:mi in 24-Hour Time)";
            // 
            // endDateErrorLabel
            // 
            this.endDateErrorLabel.AutoSize = true;
            this.endDateErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.endDateErrorLabel.Location = new System.Drawing.Point(211, 62);
            this.endDateErrorLabel.Name = "endDateErrorLabel";
            this.endDateErrorLabel.Size = new System.Drawing.Size(20, 24);
            this.endDateErrorLabel.TabIndex = 24;
            this.endDateErrorLabel.Text = "?";
            this.endDateErrorLabel.Visible = false;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(6, 143);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(199, 20);
            this.endTimePicker.TabIndex = 10;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(6, 88);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(167, 13);
            this.startTimeLabel.TabIndex = 27;
            this.startTimeLabel.Text = "Start Time (hh:mi in 24-Hour Time)";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(6, 104);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(199, 20);
            this.startTimePicker.TabIndex = 9;
            // 
            // daySelector
            // 
            this.daySelector.Controls.Add(this.sundayCheckBox);
            this.daySelector.Controls.Add(this.mondayCheckBox);
            this.daySelector.Controls.Add(this.tuesdayCheckBox);
            this.daySelector.Controls.Add(this.wednesdayCheckBox);
            this.daySelector.Controls.Add(this.thursdayCheckBox);
            this.daySelector.Controls.Add(this.fridayCheckBox);
            this.daySelector.Controls.Add(this.saturdayCheckBox);
            this.daySelector.Location = new System.Drawing.Point(6, 187);
            this.daySelector.Name = "daySelector";
            this.daySelector.Size = new System.Drawing.Size(261, 157);
            this.daySelector.TabIndex = 31;
            this.daySelector.TabStop = false;
            // 
            // sundayCheckBox
            // 
            this.sundayCheckBox.AutoSize = true;
            this.sundayCheckBox.Location = new System.Drawing.Point(3, 9);
            this.sundayCheckBox.Name = "sundayCheckBox";
            this.sundayCheckBox.Size = new System.Drawing.Size(62, 17);
            this.sundayCheckBox.TabIndex = 11;
            this.sundayCheckBox.Text = "Sunday";
            this.sundayCheckBox.UseVisualStyleBackColor = true;
            // 
            // mondayCheckBox
            // 
            this.mondayCheckBox.AutoSize = true;
            this.mondayCheckBox.Location = new System.Drawing.Point(3, 30);
            this.mondayCheckBox.Name = "mondayCheckBox";
            this.mondayCheckBox.Size = new System.Drawing.Size(64, 17);
            this.mondayCheckBox.TabIndex = 12;
            this.mondayCheckBox.Text = "Monday";
            this.mondayCheckBox.UseVisualStyleBackColor = true;
            // 
            // tuesdayCheckBox
            // 
            this.tuesdayCheckBox.AutoSize = true;
            this.tuesdayCheckBox.Location = new System.Drawing.Point(3, 51);
            this.tuesdayCheckBox.Name = "tuesdayCheckBox";
            this.tuesdayCheckBox.Size = new System.Drawing.Size(67, 17);
            this.tuesdayCheckBox.TabIndex = 13;
            this.tuesdayCheckBox.Text = "Tuesday";
            this.tuesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // wednesdayCheckBox
            // 
            this.wednesdayCheckBox.AutoSize = true;
            this.wednesdayCheckBox.Location = new System.Drawing.Point(3, 72);
            this.wednesdayCheckBox.Name = "wednesdayCheckBox";
            this.wednesdayCheckBox.Size = new System.Drawing.Size(83, 17);
            this.wednesdayCheckBox.TabIndex = 14;
            this.wednesdayCheckBox.Text = "Wednesday";
            this.wednesdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // thursdayCheckBox
            // 
            this.thursdayCheckBox.AutoSize = true;
            this.thursdayCheckBox.Location = new System.Drawing.Point(3, 93);
            this.thursdayCheckBox.Name = "thursdayCheckBox";
            this.thursdayCheckBox.Size = new System.Drawing.Size(70, 17);
            this.thursdayCheckBox.TabIndex = 15;
            this.thursdayCheckBox.Text = "Thursday";
            this.thursdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // fridayCheckBox
            // 
            this.fridayCheckBox.AutoSize = true;
            this.fridayCheckBox.Location = new System.Drawing.Point(3, 114);
            this.fridayCheckBox.Name = "fridayCheckBox";
            this.fridayCheckBox.Size = new System.Drawing.Size(54, 17);
            this.fridayCheckBox.TabIndex = 16;
            this.fridayCheckBox.Text = "Friday";
            this.fridayCheckBox.UseVisualStyleBackColor = true;
            // 
            // saturdayCheckBox
            // 
            this.saturdayCheckBox.AutoSize = true;
            this.saturdayCheckBox.Location = new System.Drawing.Point(3, 135);
            this.saturdayCheckBox.Name = "saturdayCheckBox";
            this.saturdayCheckBox.Size = new System.Drawing.Size(68, 17);
            this.saturdayCheckBox.TabIndex = 17;
            this.saturdayCheckBox.Text = "Saturday";
            this.saturdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(86, 350);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(4, 350);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 18;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // SchedulingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 382);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SchedulingTool";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.dateTimeBox.ResumeLayout(false);
            this.dateTimeBox.PerformLayout();
            this.daySelector.ResumeLayout(false);
            this.daySelector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox commentsBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label eventIDLabel;
        private System.Windows.Forms.Label coordinatorIDLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.CheckBox sundayCheckBox;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.CheckBox mondayCheckBox;
        private System.Windows.Forms.CheckBox tuesdayCheckBox;
        private System.Windows.Forms.CheckBox wednesdayCheckBox;
        private System.Windows.Forms.CheckBox thursdayCheckBox;
        private System.Windows.Forms.CheckBox fridayCheckBox;
        private System.Windows.Forms.CheckBox saturdayCheckBox;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.ToolTip eventIDToolTip;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label endDateErrorLabel;
        private System.Windows.Forms.Label endTimeErrorLabel;
        private System.Windows.Forms.TextBox coordinatorIDBox;
        private System.Windows.Forms.TextBox eventIDBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox daySelector;
        private System.Windows.Forms.GroupBox dateTimeBox;
        private System.Windows.Forms.TextBox facilityIDBox;
        private System.Windows.Forms.Label facilityIDLabel;
        private System.Windows.Forms.Button fileBrowserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

