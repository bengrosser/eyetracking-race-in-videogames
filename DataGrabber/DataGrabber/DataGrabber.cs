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
using Tobii.Interaction;

namespace DataGrabber
{
    public partial class DataGrabberWindow : Form, IDisposable
    {
#pragma warning disable 0169

        private int min = 0;
        private int second =-1;
        private int count = 0;
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
            fsFIX = new FileStream(@"C: \Users\CTS\Desktop\testFIX.txt", FileMode.Append, FileAccess.Write);
            fsSAC = new FileStream(@"C: \Users\CTS\Desktop\testSAC.txt", FileMode.Append, FileAccess.Write);
            swFIX = new StreamWriter(fsFIX);
            swSAC = new StreamWriter(fsSAC);
            hostFIX = new Host();
            hostSAC = new Host();
            fixationDataStream = hostFIX.Streams.CreateFixationDataStream();
            gazePointDataStream = hostSAC.Streams.CreateGazePointDataStream();

            fixationDataStream.Data((x, y, timestamp) => addToTXTFIX(x, y, timestamp));
            gazePointDataStream.GazePoint((x, y, ts) => addToTXTSAC(x, y, ts));
        }

        public void addToTXTFIX(double x, double y, double t)
        {
            //if (second == 0)
                //min++;
            second = (int)(t / 1000) % 60;
            count++;
            MethodInvoker miFIX = delegate
                {          
                    TimeBox.Text = min + "m " + second + "sec";
                    PointsBox.Text = count + " pts";
                    
                };
            if (InvokeRequired)
                this.Invoke(miFIX);
            swFIX.WriteLine(t + "," + x + "," + y);
        }

        public void addToTXTSAC(double x, double y, double t)
        {
            //if (second == 0)
            //min++;
            second = (int)(t / 1000) % 60;
            count++;
            MethodInvoker miSAC = delegate
            {
                TimeBox.Text = min + "m " + second + "sec";
                PointsBox.Text = count + " pts";

            };
            if (InvokeRequired)
                this.Invoke(miSAC);
            swSAC.WriteLine(t + "," + x + "," + y);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            hostFIX.DisableConnection();
            hostSAC.DisableConnection();

            swFIX.Close();
            fsFIX.Close();

            swSAC.Close();
            fsSAC.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
        }
    }
}
