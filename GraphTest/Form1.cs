using System.Diagnostics.Metrics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;
using System.Reflection.Emit;
using Label = System.Windows.Forms.Label;

using System.Threading;
using System;


namespace GraphTest
{
    public partial class Form1 : Form
    {
        public double[] values = new double[101];   //values to be analyse
        public int valueSize = 0;                   //number of values, written in file
        public Label[] labels = new Label[9];       //array for labels, showing the partial grid 
        double Max, Min, multiplier;                //Minimal and maximal values and scale multiplier
        int index = 0;                              //current number possition of the chosen point
        bool blink = true;                          //for toggling point color
        bool ifClickOpen = false;                   //do not make point black if new file is open


        public Form1()
        {
            InitializeComponent();

            labels[0] = l1;
            labels[1] = l2;
            labels[2] = l3;
            labels[3] = l4;
            labels[4] = l5;
            labels[5] = l6;
            labels[6] = l7;
            labels[7] = l8;
            labels[8] = l9;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            myTimer.Stop();
        }

        void ClearLabels()
        {
            Max_lbl.Text = "";
            Min_lbl.Text = "";
            for (int i = 1; i < 10; i++)
            {
                labels[i - 1].Text = "";
            }
        }

        void Draw(int index, Boolean blink)
        {
            int ellipseSize = 2;

            Graphics g = panel1.CreateGraphics();
            Pen pMax = new Pen(Color.Red);
            Pen pMin = new Pen(Color.Blue);
            Pen pMid = new Pen(Color.LightGray);
            SolidBrush sBlack = new SolidBrush(Color.Black);
            SolidBrush sPink = new SolidBrush(Color.Pink);

            if (index == -1) //draw graphic from values, get from file
            {
                panel1.Controls.Clear();
                panel1.Refresh();

                Max_lbl.Text = string.Format("{0:F3}", Max);
                Min_lbl.Text = string.Format("{0:F3}", Min);

                g.DrawLine(pMax, 0, panel1.Height - 10 - Convert.ToInt16((Max - Min) * multiplier), 599, panel1.Height - 10 - Convert.ToInt16((Max - Min) * multiplier));
                g.DrawLine(pMin, 0, panel1.Height - 10, 599, panel1.Height - 10);
                for (int i = 1; i < 10; i++)
                {
                    g.DrawLine(pMid, 0, panel1.Height - 10 - Convert.ToInt16(i * ((Max - Min) * multiplier) / 10), 599, panel1.Height - 10 - Convert.ToInt16(i * ((Max - Min) * multiplier) / 10));
                    labels[i - 1].Text = string.Format("{0:F3}", Min + (Max - Min) * i / 10);
                }

                for (int i = 0; i < valueSize; i++)
                {
                    g.FillEllipse(sBlack, 5 * i + 5, panel1.Height - 10 - ellipseSize - Convert.ToInt16(((values[i]) - Min) * multiplier), ellipseSize * 2, ellipseSize * 2);
                }
            }
            else
            {
                if (index >= 0)
                {   //status_txt.Text = string.Format("index={0}  indexTemp={1}", index, indexTemp);

                    if (blink == true)
                    {
                        g.FillEllipse(sPink, 5 * index + 5, panel1.Height - 10 - ellipseSize - Convert.ToInt16(((values[index]) - Min) * multiplier), ellipseSize * 2, ellipseSize * 2);
                    }
                    else
                    {
                        g.FillEllipse(sBlack, 5 * index + 5, panel1.Height - 10 - ellipseSize - Convert.ToInt16(((values[index]) - Min) * multiplier), ellipseSize * 2, ellipseSize * 2);
                    }
                }
            }
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            blink ^= true; // togle point color
            Draw(index, blink);
        }

        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            Values_lb.Enabled = true;

            ifClickOpen = true;
            bool fileReadFlag = true;  // false if read wrong data from file

            var fileContent = string.Empty; // keep whole file data
            var filePath = string.Empty;    
            status_txt.Text = "";
            Values_lb.Items.Clear();

            int counter = 0; // number of current row in file

            OpenFile.Filter = "txt files (*.txt)|*.txt";
            OpenFile.RestoreDirectory = true;

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                filePath = OpenFile.FileName;
                var fileStream = OpenFile.OpenFile();

                OpenFile_txt.Text = filePath;

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                    string[] lines = fileContent.Split('\n'); //array of file lines

                    foreach (string line in lines)
                    {                     
                        if (line != "")
                        {
                            try
                            {
                                values[counter] = Convert.ToDouble(line);
                            }
                            catch (Exception)
                            {
                                status_txt.Text = status_txt.Text + $"Incorrect Value convertion from file!  line: {counter + 1}\r\n[{line}]\r\n";
                                fileReadFlag = false;
                                break;                         
                            }

                            if ((values[counter] < 0) || (values[counter] >1000))
                            {
                                status_txt.Text = status_txt.Text + $"Incorrect Value convertion from file!  line: {counter + 1}\r\n[{line}]  value must be between 0 and 1000\r\n";
                                fileReadFlag = false;
                                break;
                            }

                            Values_lb.Items.Add(String.Format("{0:D2}:  {1}", counter + 1, line));

                            if (++counter > 100)
                            {
                                status_txt.Text = status_txt.Text + $"File contains more than 100 reads and extra lines was skipped\r\n";
                                break;
                            }
                        }
                    }
                    valueSize = counter;
                }

                if (counter == 0)
                {
                    status_txt.Text = status_txt.Text + $"File doesn't contain data\r\n";
                    Values_lb.Enabled = true;
                    fileReadFlag = false;
                }

                if (fileReadFlag ==  false)
                {
                    Values_lb.Items.Clear();
                    Values_lb.Enabled = false;
                    panel1.Controls.Clear(); //clear graphic panel
                    this.Refresh();
                    return;
                }

                Max = values.Select(x => x)
                      .Where(x => x > 0)
                      .Max();

                Min = values.Select(x => x)
                                      .Where(x => x > 0)
                                      .Min();


                multiplier = (panel1.Height - 20) / (Max - Min); //calculate scale according to Max and Min values
                Draw(index, false); //overdraw selected value black after timer is stopped.

                if (counter > 0)
                {
                    Draw(-1, true); //draw whole graphic and all values
                }
                else
                {
                    ClearLabels();
                    panel1.Controls.Clear(); //clear graphic panel
                    this.Refresh();
                }
            }
        }

        private void CreateFile_btn_Click(object sender, EventArgs e)
        {
            lowLimit_txt.ForeColor = Color.Black;
            highLimit_txt.ForeColor = Color.Black;
            maxIteration_txt.ForeColor = Color.Black;

            Random RandomMeas = new Random(0);

            double LowLimit = 0;
            double HighLimit = 0;
            double valueLimit;
            Int16 Iteration;
            double num;
            string strValue;
            status_txt.Text = "";


            // User input date validation
            try
            {
                LowLimit = Convert.ToDouble(lowLimit_txt.Text);
                if ((LowLimit < 0) || (LowLimit >1000))
                {
                    status_txt.Text = status_txt.Text + "LowLimit must be between 0 and 1000!\r\n";
                    ClearLabels();
                    lowLimit_txt.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception)
            {
                status_txt.Text = status_txt.Text + "Incorrect format for LowLimit!\r\n";
                ClearLabels();
                lowLimit_txt.ForeColor = Color.Red;
                return;
            }

            try
            {
                HighLimit = Convert.ToDouble(highLimit_txt.Text);
                if ((HighLimit < 0) || (HighLimit > 1000))
                {
                    status_txt.Text = status_txt.Text + "HighLimit must be between 0 and 1000!\r\n";
                    ClearLabels();
                    highLimit_txt.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception)
            {
                status_txt.Text = status_txt.Text + "Incorrect format for HighLimit!\r\n";
                ClearLabels();
                highLimit_txt.ForeColor = Color.Red;
                return;
            }

            try
            {
                Iteration = Convert.ToInt16(maxIteration_txt.Text);
                if ((Iteration < 1) || (Iteration > 100))
                {
                    status_txt.Text = status_txt.Text + "\"Iteration must be between 1 and 100!\r\n";
                    ClearLabels();
                    maxIteration_txt.ForeColor = Color.Red;
                    return;
                }
            }
            catch (Exception)
            {
                status_txt.Text = status_txt.Text + "Incorrect format for Iteration!\r\n";
                ClearLabels();
                maxIteration_txt.ForeColor = Color.Red;
                return;
            }

            if (HighLimit < LowLimit + 0.01)
            {
                status_txt.Text = "HighLimit must be at least 0.01 greater then LowLilit!\r\n";
                ClearLabels();
                return;
            }


            // Create file
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "txt files (*.txt)|*.txt";
            SaveFile.Title = "Save an Image File";
            SaveFile.DefaultExt = "txt";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                CreateFile_txt.Text = SaveFile.FileName;

                using (StreamWriter sw = File.CreateText(SaveFile.FileName))
                {
                    for (int i = 0; i < Iteration; i++)
                    {
                        num = RandomMeas.NextDouble();
                        valueLimit = num * (HighLimit - LowLimit) + LowLimit;
                        strValue = String.Format("{0:F3}", valueLimit);
                        sw.WriteLine(strValue);
                    }
                }

                OpenFile_txt.Text = "";
            }
        }

        // choose value to blink
        private void Values_lb_MouseClick(object sender, MouseEventArgs e)
        {
            myTimer.Stop();
            if (ifClickOpen == false)
            {
                Draw(index, false); //draw the point black
            }
            myTimer.Start();
            index = Values_lb.IndexFromPoint(e.Location);
            ifClickOpen = false;
        }
    }
}