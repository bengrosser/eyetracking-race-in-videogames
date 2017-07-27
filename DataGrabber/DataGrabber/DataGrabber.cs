using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using Tobii.Interaction;

namespace DataGrabber
{
    public partial class DataGrabberWindow : Form, IDisposable
    {
#pragma warning disable 0169

        private int min = 0;
        private int second =-1;
        private int fixcount = 0;
        private int saccount = 0;
        //private bool segmented = false;
        private Host hostFIX;
        private Host hostSAC;
        private FixationDataStream fixationDataStream;
        private GazePointDataStream gazePointDataStream;
        //System.IO.StreamWriter file;
        FileStream fsFIX;
        FileStream fsSAC;
        StreamWriter swFIX;
        StreamWriter swSAC;

        public DataGrabberWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartOverButton_Click(sender, e);
            fsFIX = new FileStream(@"C: \Users\CTS\Desktop\testFIX.txt", FileMode.Create, FileAccess.Write);
            fsSAC = new FileStream(@"C: \Users\CTS\Desktop\testSAC.txt", FileMode.Create, FileAccess.Write);
            swFIX = new StreamWriter(fsFIX);
            swSAC = new StreamWriter(fsSAC);
            hostFIX = new Host();
            hostSAC = new Host();

            fixationDataStream = hostFIX.Streams.CreateFixationDataStream(Tobii.Interaction.Framework.FixationDataMode.Slow);
            gazePointDataStream = hostSAC.Streams.CreateGazePointDataStream();

            fixationDataStream.Data((x, y, timestamp) => addToTXTFIX(x, y, timestamp));
            gazePointDataStream.GazePoint((x, y, ts) => addToTXTSAC(x, y, ts));
        }

        public void addToTXTFIX(double x, double y, double t)
        {
            second = (int)(t / 1000) % 60;
            fixcount++;
            MethodInvoker miFIX = delegate
                {
                    fixateBox.Text = fixcount + " pts";
                    try { swFIX.WriteLine(t + "," + x + "," + y); }
                    catch(Exception)
                    {
                        checkBox.Text = "Error FIX. 1 line went missing";
                    }
                    
                };
            if (InvokeRequired)
                this.Invoke(miFIX);
        }

        public void addToTXTSAC(double x, double y, double t)
        {
            if (second == 59)
                Interlocked.Increment(ref min);
            second = (int)(t / 1000) % 60;
            saccount++;
            MethodInvoker miSAC = delegate
            {
                if(min == 0)
                    TimeBox.Text = min + "m " + second + "sec";
                else
                {
                    TimeBox.Text = (min/89) + "m " + second + "sec";
                }

                saccadeBox.Text = saccount + "pts";
                try { swSAC.WriteLine(t + "," + x + "," + y); }
                catch(Exception)
                {
                    checkBox.Text = "Error SAC. 1 line went missing.";
                }
            };
            if (InvokeRequired)
                this.Invoke(miSAC);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            hostFIX.DisableConnection();
            hostSAC.DisableConnection();

            swFIX.Close();
            fsFIX.Close();

            swSAC.Close();
            fsSAC.Close();

            DialogResult d = MessageBox.Show("Data is in Desktop", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int lineCountFIX = File.ReadLines(@"C: \Users\CTS\Desktop\testFIX.txt").Count();
                int lineCountSAC = File.ReadLines(@"C: \Users\CTS\Desktop\testSAC.txt").Count();
                checkBox.Text = "Lines in FIX: " + lineCountFIX + "\tLines in SAC: "+lineCountSAC;
            }
            catch
            {
                DialogResult d = MessageBox.Show("Click 'Finish' before you save! Your data retrieval is still running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartOverButton_Click(object sender, EventArgs e)
        {
            fixcount = 0;
            saccount = 0;
            min = 0;
            checkBox.Text = "";
            TimeBox.Text = "";
            fixateBox.Text = "";
            saccadeBox.Text = "";
            try
            {
                File.WriteAllText(@"C: \Users\CTS\Desktop\testFIX.txt", String.Empty);
                File.WriteAllText(@"C: \Users\CTS\Desktop\testSAC.txt", String.Empty);
            }
            catch { }
            
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Haven't fully implemented this yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddSepButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Haven't fully implemented this yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //swFIX.WriteLine("===================");
            //swSAC.WriteLine("===================");
            //segmented = true;
        }
    }
}
