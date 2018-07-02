using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatternDetector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (triangleSelect.Checked == true && otherSelect.Checked == false)
            {
                DialogResult d = MessageBox.Show("You selected " + triangleSelect.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                allSelect.Enabled = false;
            }
            else if (otherSelect.Checked == true && triangleSelect.Checked == false)
            {
                DialogResult d = MessageBox.Show("You selected " + otherSelect.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                allSelect.Enabled = false;
            }
            else if (triangleSelect.Checked == true && otherSelect.Checked == true)
            {
                DialogResult d = MessageBox.Show("You selected " + triangleSelect.Text + " and " + otherSelect.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                allSelect.Enabled = false;
            }
            else if (allSelect.Checked)
            {
                DialogResult d = MessageBox.Show("You selected " + allSelect.Text, "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                triangleSelect.Enabled = false;
                otherSelect.Enabled = false;
            }
        }

        private void dataAccessButton_Click(object sender, EventArgs e)
        {
            openDataPrompt.ShowDialog();
            if (openDataPrompt.CheckFileExists == true)
            {
                fileBox.Text = openDataPrompt.SafeFileName;
            }
        }

        private void openDataPrompt_FileOk(object sender, CancelEventArgs e)
        {
            this.Activate();

        }
    }
}
