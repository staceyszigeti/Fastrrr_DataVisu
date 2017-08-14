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
        string[] lines;
        string[] Type = new string[1000];
        DateTime[] Date = new DateTime[1000];
        DateTime[] Time = new DateTime[1000];
        float[] Latitude = new float[1000];
        float[] Longitude = new float[1000];
        float[] Depth = new float[1000];
        float[] Speed = new float[1000];
        float[] Course = new float[1000];

        public void FileRead()
        {
            char[] delimiterChars = { ' ', '\t' };

            for (int i = 1; i < 1000; i++)
            {
                string RowBuffer = lines[i];

                if (RowBuffer.Substring(0, 1) == "T")
                {
                    string[] RowBufferArray = RowBuffer.Split(delimiterChars);

                    Type[i] = RowBufferArray[0];
                    Date[i] = DateTime.Parse(RowBufferArray[1]);
                    Time[i] = DateTime.Parse(RowBufferArray[2]);
                    Latitude[i] = float.Parse(RowBufferArray[3], System.Globalization.CultureInfo.InvariantCulture); ;
                    Longitude[i] = float.Parse(RowBufferArray[4], System.Globalization.CultureInfo.InvariantCulture);
                    Depth[i] = float.Parse(RowBufferArray[5], System.Globalization.CultureInfo.InvariantCulture);
                    Speed[i] = float.Parse(RowBufferArray[6], System.Globalization.CultureInfo.InvariantCulture);
                    //Course[i] = float.Parse(RowBufferArray[7], System.Globalization.CultureInfo.InvariantCulture);
                };

            }
        }

        public double CalculateAverage(float[] data)
        {
            float sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum = data[i];
            };

            double result = sum / data.Length;

            return result;
        }

        private void buttonLoadTrack_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                try
                {
                    lines = File.ReadAllLines(file);

                    LabelNumberOfLine.Text = lines.Length.ToString();
                    LabelFileName.Text = openFileDialog1.SafeFileName;
                }
                catch (IOException)
                {
                    MessageBox.Show("IOException");
                };

                FileRead();
                LabelAverageSpeed.Text = CalculateAverage(Speed).ToString();
            };
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            LabelType.Text = Type[hScrollBar1.Value];
            LabelDate.Text = Date[hScrollBar1.Value].ToString("yyyy-MM-dd");
            LabelTime.Text = Time[hScrollBar1.Value].ToString("HH:mm:ss");
            LabelLatitude.Text = Latitude[hScrollBar1.Value].ToString();
            LabelLongitude.Text = Longitude[hScrollBar1.Value].ToString();
            LabelDepth.Text = Depth[hScrollBar1.Value].ToString();
            LabelSpeed.Text = Speed[hScrollBar1.Value].ToString();
            LabelCourse.Text = Course[hScrollBar1.Value].ToString();
        }
    }
}
