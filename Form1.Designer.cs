﻿namespace Fastrrr_DataVisu
{
    partial class Form1
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
            this.buttonLoadTrack = new System.Windows.Forms.Button();
            this.groupBoxCalculatedValues = new System.Windows.Forms.GroupBox();
            this.LabelAverageSpeed = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxFileData = new System.Windows.Forms.GroupBox();
            this.LabelNumberOfFix = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabelNumberOfLine = new System.Windows.Forms.Label();
            this.groupBoxSailingData = new System.Windows.Forms.GroupBox();
            this.LabelDepth = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelCourse = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.LabelLongitude = new System.Windows.Forms.Label();
            this.LabelLatitude = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.LabelNumberOfMissingData = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.buttonSelectTimeIntervall = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.labelTimeDiff = new System.Windows.Forms.Label();
            this.groupBoxCalculatedValues.SuspendLayout();
            this.groupBoxFileData.SuspendLayout();
            this.groupBoxSailingData.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadTrack
            // 
            this.buttonLoadTrack.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadTrack.Name = "buttonLoadTrack";
            this.buttonLoadTrack.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadTrack.TabIndex = 3;
            this.buttonLoadTrack.Text = "Load track";
            this.buttonLoadTrack.UseVisualStyleBackColor = true;
            this.buttonLoadTrack.Click += new System.EventHandler(this.buttonLoadTrack_Click);
            // 
            // groupBoxCalculatedValues
            // 
            this.groupBoxCalculatedValues.Controls.Add(this.LabelAverageSpeed);
            this.groupBoxCalculatedValues.Controls.Add(this.label12);
            this.groupBoxCalculatedValues.Location = new System.Drawing.Point(12, 284);
            this.groupBoxCalculatedValues.Name = "groupBoxCalculatedValues";
            this.groupBoxCalculatedValues.Size = new System.Drawing.Size(262, 100);
            this.groupBoxCalculatedValues.TabIndex = 25;
            this.groupBoxCalculatedValues.TabStop = false;
            this.groupBoxCalculatedValues.Text = "Calculated values:";
            // 
            // LabelAverageSpeed
            // 
            this.LabelAverageSpeed.AutoSize = true;
            this.LabelAverageSpeed.Location = new System.Drawing.Point(105, 20);
            this.LabelAverageSpeed.Name = "LabelAverageSpeed";
            this.LabelAverageSpeed.Size = new System.Drawing.Size(10, 13);
            this.LabelAverageSpeed.TabIndex = 1;
            this.LabelAverageSpeed.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Average speed:";
            // 
            // groupBoxFileData
            // 
            this.groupBoxFileData.Controls.Add(this.LabelNumberOfMissingData);
            this.groupBoxFileData.Controls.Add(this.label13);
            this.groupBoxFileData.Controls.Add(this.LabelNumberOfFix);
            this.groupBoxFileData.Controls.Add(this.label10);
            this.groupBoxFileData.Controls.Add(this.LabelFileName);
            this.groupBoxFileData.Controls.Add(this.label1);
            this.groupBoxFileData.Controls.Add(this.Label2);
            this.groupBoxFileData.Controls.Add(this.LabelNumberOfLine);
            this.groupBoxFileData.Location = new System.Drawing.Point(12, 41);
            this.groupBoxFileData.Name = "groupBoxFileData";
            this.groupBoxFileData.Size = new System.Drawing.Size(262, 100);
            this.groupBoxFileData.TabIndex = 24;
            this.groupBoxFileData.TabStop = false;
            this.groupBoxFileData.Text = "File data:";
            // 
            // LabelNumberOfFix
            // 
            this.LabelNumberOfFix.AutoSize = true;
            this.LabelNumberOfFix.Location = new System.Drawing.Point(102, 58);
            this.LabelNumberOfFix.Name = "LabelNumberOfFix";
            this.LabelNumberOfFix.Size = new System.Drawing.Size(10, 13);
            this.LabelNumberOfFix.TabIndex = 9;
            this.LabelNumberOfFix.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Number of fix:";
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.Location = new System.Drawing.Point(75, 16);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(10, 13);
            this.LabelFileName.TabIndex = 7;
            this.LabelFileName.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File name:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Number of lines:";
            // 
            // LabelNumberOfLine
            // 
            this.LabelNumberOfLine.AutoSize = true;
            this.LabelNumberOfLine.Location = new System.Drawing.Point(102, 38);
            this.LabelNumberOfLine.Name = "LabelNumberOfLine";
            this.LabelNumberOfLine.Size = new System.Drawing.Size(10, 13);
            this.LabelNumberOfLine.TabIndex = 5;
            this.LabelNumberOfLine.Text = "-";
            // 
            // groupBoxSailingData
            // 
            this.groupBoxSailingData.Controls.Add(this.LabelDepth);
            this.groupBoxSailingData.Controls.Add(this.label11);
            this.groupBoxSailingData.Controls.Add(this.LabelCourse);
            this.groupBoxSailingData.Controls.Add(this.LabelSpeed);
            this.groupBoxSailingData.Controls.Add(this.LabelLongitude);
            this.groupBoxSailingData.Controls.Add(this.LabelLatitude);
            this.groupBoxSailingData.Controls.Add(this.LabelTime);
            this.groupBoxSailingData.Controls.Add(this.LabelDate);
            this.groupBoxSailingData.Controls.Add(this.label9);
            this.groupBoxSailingData.Controls.Add(this.label8);
            this.groupBoxSailingData.Controls.Add(this.label7);
            this.groupBoxSailingData.Controls.Add(this.label6);
            this.groupBoxSailingData.Controls.Add(this.label5);
            this.groupBoxSailingData.Controls.Add(this.label4);
            this.groupBoxSailingData.Controls.Add(this.label3);
            this.groupBoxSailingData.Controls.Add(this.LabelType);
            this.groupBoxSailingData.Location = new System.Drawing.Point(12, 147);
            this.groupBoxSailingData.Name = "groupBoxSailingData";
            this.groupBoxSailingData.Size = new System.Drawing.Size(262, 131);
            this.groupBoxSailingData.TabIndex = 23;
            this.groupBoxSailingData.TabStop = false;
            this.groupBoxSailingData.Text = "Sailing data:";
            // 
            // LabelDepth
            // 
            this.LabelDepth.AutoSize = true;
            this.LabelDepth.Location = new System.Drawing.Point(58, 99);
            this.LabelDepth.Name = "LabelDepth";
            this.LabelDepth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelDepth.Size = new System.Drawing.Size(10, 13);
            this.LabelDepth.TabIndex = 20;
            this.LabelDepth.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Depth:";
            // 
            // LabelCourse
            // 
            this.LabelCourse.AutoSize = true;
            this.LabelCourse.Location = new System.Drawing.Point(194, 99);
            this.LabelCourse.Name = "LabelCourse";
            this.LabelCourse.Size = new System.Drawing.Size(10, 13);
            this.LabelCourse.TabIndex = 18;
            this.LabelCourse.Text = "-";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.Location = new System.Drawing.Point(194, 75);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(10, 13);
            this.LabelSpeed.TabIndex = 17;
            this.LabelSpeed.Text = "-";
            // 
            // LabelLongitude
            // 
            this.LabelLongitude.AutoSize = true;
            this.LabelLongitude.Location = new System.Drawing.Point(194, 49);
            this.LabelLongitude.Name = "LabelLongitude";
            this.LabelLongitude.Size = new System.Drawing.Size(10, 13);
            this.LabelLongitude.TabIndex = 16;
            this.LabelLongitude.Text = "-";
            // 
            // LabelLatitude
            // 
            this.LabelLatitude.AutoSize = true;
            this.LabelLatitude.Location = new System.Drawing.Point(194, 25);
            this.LabelLatitude.Name = "LabelLatitude";
            this.LabelLatitude.Size = new System.Drawing.Size(10, 13);
            this.LabelLatitude.TabIndex = 15;
            this.LabelLatitude.Text = "-";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(58, 75);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(10, 13);
            this.LabelTime.TabIndex = 14;
            this.LabelTime.Text = "-";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Location = new System.Drawing.Point(58, 51);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(10, 13);
            this.LabelDate.TabIndex = 13;
            this.LabelDate.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Course:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Speed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Location = new System.Drawing.Point(58, 25);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(10, 13);
            this.LabelType.TabIndex = 0;
            this.LabelType.Text = "-";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 1;
            this.hScrollBar1.Location = new System.Drawing.Point(12, 460);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(262, 20);
            this.hScrollBar1.TabIndex = 22;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Missing data:";
            // 
            // LabelNumberOfMissingData
            // 
            this.LabelNumberOfMissingData.AutoSize = true;
            this.LabelNumberOfMissingData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelNumberOfMissingData.Location = new System.Drawing.Point(102, 78);
            this.LabelNumberOfMissingData.Name = "LabelNumberOfMissingData";
            this.LabelNumberOfMissingData.Size = new System.Drawing.Size(10, 13);
            this.LabelNumberOfMissingData.TabIndex = 11;
            this.LabelNumberOfMissingData.Text = "-";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Location = new System.Drawing.Point(280, 41);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(242, 100);
            this.groupBoxDate.TabIndex = 26;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2017, 8, 23, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 20);
            this.dateTimePicker2.TabIndex = 29;
            this.dateTimePicker2.Value = new System.DateTime(2017, 8, 23, 0, 0, 0, 0);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labelTimeDiff);
            this.groupBoxTime.Controls.Add(this.label15);
            this.groupBoxTime.Controls.Add(this.buttonSelectTimeIntervall);
            this.groupBoxTime.Controls.Add(this.dateTimePicker1);
            this.groupBoxTime.Controls.Add(this.dateTimePicker2);
            this.groupBoxTime.Location = new System.Drawing.Point(281, 148);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(241, 130);
            this.groupBoxTime.TabIndex = 30;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time:";
            // 
            // buttonSelectTimeIntervall
            // 
            this.buttonSelectTimeIntervall.Location = new System.Drawing.Point(77, 93);
            this.buttonSelectTimeIntervall.Name = "buttonSelectTimeIntervall";
            this.buttonSelectTimeIntervall.Size = new System.Drawing.Size(158, 23);
            this.buttonSelectTimeIntervall.TabIndex = 30;
            this.buttonSelectTimeIntervall.Text = "Update Time Intervall";
            this.buttonSelectTimeIntervall.UseVisualStyleBackColor = true;
            this.buttonSelectTimeIntervall.Click += new System.EventHandler(this.buttonSelectTimeIntervall_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Elipsed:";
            // 
            // labelTimeDiff
            // 
            this.labelTimeDiff.AutoSize = true;
            this.labelTimeDiff.Location = new System.Drawing.Point(58, 74);
            this.labelTimeDiff.Name = "labelTimeDiff";
            this.labelTimeDiff.Size = new System.Drawing.Size(43, 13);
            this.labelTimeDiff.TabIndex = 32;
            this.labelTimeDiff.Text = "0:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 509);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBoxDate);
            this.Controls.Add(this.groupBoxCalculatedValues);
            this.Controls.Add(this.groupBoxFileData);
            this.Controls.Add(this.groupBoxSailingData);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.buttonLoadTrack);
            this.Name = "Form1";
            this.Text = "Fastrrr -DataVisu";
            this.groupBoxCalculatedValues.ResumeLayout(false);
            this.groupBoxCalculatedValues.PerformLayout();
            this.groupBoxFileData.ResumeLayout(false);
            this.groupBoxFileData.PerformLayout();
            this.groupBoxSailingData.ResumeLayout(false);
            this.groupBoxSailingData.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadTrack;
        private System.Windows.Forms.GroupBox groupBoxCalculatedValues;
        private System.Windows.Forms.Label LabelAverageSpeed;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxFileData;
        private System.Windows.Forms.Label LabelFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label LabelNumberOfLine;
        private System.Windows.Forms.GroupBox groupBoxSailingData;
        private System.Windows.Forms.Label LabelDepth;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelCourse;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Label LabelLongitude;
        private System.Windows.Forms.Label LabelLatitude;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LabelNumberOfFix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelNumberOfMissingData;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.Button buttonSelectTimeIntervall;
        private System.Windows.Forms.Label labelTimeDiff;
        private System.Windows.Forms.Label label15;
    }
}

