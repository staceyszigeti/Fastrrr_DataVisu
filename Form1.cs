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

namespace Fastrrr_DataVisu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Variables declaration
        string[] Lines;
        string[] Type;
        DateTime[] Date;
        DateTime[] Time;
        float[] Latitude;
        float[] Longitude;
        float[] Depth;
        float[] Speed;
        float[] Course;

        List<DateTime> listDate = new List<DateTime>();
        List<CheckBox> CheckBoxes = new List<CheckBox>();

        //Keresés eredménye a tömbben
        List<DateTime> SearchResulDate = new List<DateTime>();
        List<DateTime> SearchResulTime = new List<DateTime>();
        List<float> SearchResulLatitude = new List<float>();
        List<float> SearchResulLongitude = new List<float>();
        List<float> SearchResulDepth = new List<float>();
        List<float> SearchResulSpeed = new List<float>();
        List<float> SearchResulCourse = new List<float>();

        int NumberOfLines = 0;
        int NumberOfFix = 0;
        int NumberOfMissingData = 0;

        int[] NumOfChecked; 
        int intNumOfChecked = 0;
        int PosOfChecked = 0;
        string SelectedDate;

        public void FileOpen()
        {
            NumberOfLines = 0;
            NumberOfFix = 0;
            NumberOfMissingData = 0;

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;

                try
                {
                    Lines = File.ReadAllLines(FileName);

                    FileCheck();

                    Type = new string[NumberOfFix];
                    Date = new DateTime[NumberOfFix];
                    Time = new DateTime[NumberOfFix];
                    Latitude = new float[NumberOfFix];
                    Longitude = new float[NumberOfFix];
                    Depth = new float[NumberOfFix];
                    Speed = new float[NumberOfFix];
                    Course = new float[NumberOfFix];

                    

                    FileProcessing();

                    LabelFileName.Text = openFileDialog1.SafeFileName;
                    LabelNumberOfLine.Text = NumberOfLines.ToString();
                    LabelNumberOfFix.Text = NumberOfFix.ToString();
                    LabelNumberOfMissingData.Text = NumberOfMissingData.ToString();

                }

                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                };

            }
            else
            {
                MessageBox.Show("File beolvasás hiba!");
            };

            hScrollBar1.Maximum = Type.Length - 1;

        }

        public void FileCheck()
        {

            NumberOfLines = Lines.Length;

            for (int i = 0; i < NumberOfLines; i++)
            {
                try
                {
                    if (Lines[i].Substring(0, 1) == "T")
                    {
                        NumberOfFix++;
                    }
                }
                catch
                {
                    MessageBox.Show("Üres sort találat a " + i+1.ToString() + " sorban. Kérem a sort törölni.");
                    i++;
                };
                
            };
        }

        public void FileProcessing()
        {
            char[] delimiterChars = { ' ', '\t' };
            int j = 0;

            for (int i = 1; i < NumberOfLines; i++)
            {
                string RowBuffer = Lines[i];

                try
                {
                    if (RowBuffer.Substring(0, 1) == "T")
                    {
                        string[] RowBufferArray = RowBuffer.Split(delimiterChars);

                        if (RowBufferArray[0] != "" && RowBufferArray[1] != "" && RowBufferArray[2] != "" && RowBufferArray[3] != "" && RowBufferArray[4] != "" && RowBufferArray[5] != "" && RowBufferArray[6] != "" && RowBufferArray[7] != "")
                        {
                            Type[j] = RowBufferArray[0];
                            Date[j] = DateTime.Parse(RowBufferArray[1]);
                            Time[j] = DateTime.Parse(RowBufferArray[2]);
                            Latitude[j] = float.Parse(RowBufferArray[3], System.Globalization.CultureInfo.InvariantCulture);
                            Longitude[j] = float.Parse(RowBufferArray[4], System.Globalization.CultureInfo.InvariantCulture);
                            Depth[j] = float.Parse(RowBufferArray[5], System.Globalization.CultureInfo.InvariantCulture);
                            Speed[j] = float.Parse(RowBufferArray[6], System.Globalization.CultureInfo.InvariantCulture);
                            Course[j] = float.Parse(RowBufferArray[7], System.Globalization.CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            NumberOfMissingData++;

                            try
                            {
                                Type[j] = RowBufferArray[0];
                            }
                            catch
                            {
                                Type[j] = null;
                            };

                            try
                            {
                                Date[j] = DateTime.Parse(RowBufferArray[1]);
                            }
                            catch
                            {

                            };

                            try
                            {
                                Time[j] = DateTime.Parse(RowBufferArray[2]);
                            }
                            catch
                            {

                            };

                            try
                            {
                                Latitude[j] = float.Parse(RowBufferArray[3], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                Latitude[j] = 0;
                            };

                            try
                            {
                                Longitude[j] = float.Parse(RowBufferArray[4], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                Longitude[j] = 0;
                            };

                            try
                            {
                                Depth[j] = float.Parse(RowBufferArray[5], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                Depth[j] = 0;
                            };

                            try
                            {
                                Speed[j] = float.Parse(RowBufferArray[6], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                Speed[j] = 0;
                            };

                            try
                            {
                                Course[j] = float.Parse(RowBufferArray[7], System.Globalization.CultureInfo.InvariantCulture);
                            }
                            catch
                            {
                                Course[j] = 0;
                            };


                        }

                        j++;
                    };
                }
                catch
                {
                    i++;
                };


            }
        }

        public double CalculateAverage(float[] data)
        {
            float sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum = sum + data[i];
            };

            double result = (sum / data.Length) * 0.539957;

            return result;
        }

        public void DateSelect()
        {
            for (int i = 0; i < Date.Length; i++)
            {
                if (listDate.Contains(Date[i]) == false)
                {
                    listDate.Add(Date[i]);
                };               
            };

            listDate.Sort();

            CheckBox box;
            for (int i = 1; i <= listDate.Count; i++)
            {
                box = new CheckBox();
                box.Name = "CheckBoxDataChecker" + (i).ToString();
                box.Text = listDate[i - 1].ToString("yyyy.MM.dd");
                box.AutoSize = true;
                box.Checked = true;
                box.Location = new Point(16, 2 + i * 18); //vertical
                groupBoxDate.Controls.Add(box);
                CheckBoxes.Add(box);
            };

            if (Time != null)
            {
                dateTimePicker1.Value = Time.Min();
                dateTimePicker2.Value = Time.Max();
            };

            NumOfChecked = new int[listDate.Count]; 

            //var first = CheckBoxes.First();
            //first.Text = "First Checkbox";
        }

        public void TimeSelect()
        {
            intNumOfChecked = 0;
            PosOfChecked = 0;

            for (int i = 0; i < CheckBoxes.Count; i++)
            {
                var CheckBoxDataChecker = CheckBoxes[i];
                if (CheckBoxDataChecker.Checked == true)
                {
                    NumOfChecked[i] = 1;
                    intNumOfChecked++;
                }
                else
                {
                    NumOfChecked[i] = 0;
                };
            };

            if (intNumOfChecked == 1)
            {
                for (int i = 0; i < NumOfChecked.Length; i++)
                {
                    if (NumOfChecked[i] == 1)
                    {
                        PosOfChecked = i;
                        break;
                    };
                };

                SelectedDate = CheckBoxes[PosOfChecked].Text;
                SearchInArray();
            }
            else
            {
                MessageBox.Show("Ez a funkció csak egy napon belül működik. Kérem válasszon ki egy napot.");
            };

        }

        private void SearchInArray()
        {
            SearchResulDate.Clear();
            SearchResulTime.Clear();
            SearchResulLatitude.Clear();
            SearchResulLongitude.Clear();
            SearchResulDepth.Clear();
            SearchResulSpeed.Clear();
            SearchResulCourse.Clear();

            for (int i = 0; i < Date.Length; i++)
            {
                if (Date[i].ToString("yyyy.MM.dd") == SelectedDate)
                {
                    SearchResulDate.Add(Date[i]);
                    SearchResulTime.Add(Time[i]);
                    SearchResulLatitude.Add(Latitude[i]);
                    SearchResulLongitude.Add(Longitude[i]);
                    SearchResulDepth.Add(Depth[i]);
                    SearchResulSpeed.Add(Speed[i]);
                    SearchResulCourse.Add(Course[i]);
                };
            };

            dateTimePicker1.Value = SearchResulTime.Min();
            dateTimePicker2.Value = SearchResulTime.Max();
            labelTimeDiff.Text = SearchResulTime.Max().Subtract(SearchResulTime.Min()).ToString();

        }

        private void buttonLoadTrack_Click(object sender, EventArgs e)
        {

            FileOpen();
            DateSelect();
            LabelAverageSpeed.Text = CalculateAverage(Speed).ToString("0.00") + " kts";
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (Type != null)
            {
                LabelType.Text = Type[hScrollBar1.Value];
                LabelDate.Text = Date[hScrollBar1.Value].ToString("yyyy-MM-dd");
                LabelTime.Text = Time[hScrollBar1.Value].ToString("HH:mm:ss");
                LabelLatitude.Text = Latitude[hScrollBar1.Value].ToString();
                LabelLongitude.Text = Longitude[hScrollBar1.Value].ToString();
                LabelDepth.Text = Depth[hScrollBar1.Value].ToString();
                LabelSpeed.Text = Speed[hScrollBar1.Value].ToString();
                LabelCourse.Text = Course[hScrollBar1.Value].ToString();
            };
            
            label14.Text = hScrollBar1.Value.ToString();
        }

        private void buttonSelectTimeIntervall_Click(object sender, EventArgs e)
        {
            TimeSelect();
        }
    }
}
