namespace Fastrrr_DataVisu
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
            this.groupBoxCalculatedValues.SuspendLayout();
            this.groupBoxFileData.SuspendLayout();
            this.groupBoxSailingData.SuspendLayout();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 509);
            this.Controls.Add(this.groupBoxCalculatedValues);
            this.Controls.Add(this.groupBoxFileData);
            this.Controls.Add(this.groupBoxSailingData);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.buttonLoadTrack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxCalculatedValues.ResumeLayout(false);
            this.groupBoxCalculatedValues.PerformLayout();
            this.groupBoxFileData.ResumeLayout(false);
            this.groupBoxFileData.PerformLayout();
            this.groupBoxSailingData.ResumeLayout(false);
            this.groupBoxSailingData.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

