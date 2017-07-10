namespace DataGrabber
{
    partial class DataGrabberWindow
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
            this.AnalyzeGB = new System.Windows.Forms.GroupBox();
            this.StartOverButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.InProgressGB = new System.Windows.Forms.GroupBox();
            this.PointsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGB = new System.Windows.Forms.GroupBox();
            this.AddSepButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AnalyzeGB.SuspendLayout();
            this.InProgressGB.SuspendLayout();
            this.DataGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnalyzeGB
            // 
            this.AnalyzeGB.Controls.Add(this.StartOverButton);
            this.AnalyzeGB.Controls.Add(this.StopButton);
            this.AnalyzeGB.Controls.Add(this.PauseButton);
            this.AnalyzeGB.Controls.Add(this.StartButton);
            this.AnalyzeGB.Location = new System.Drawing.Point(13, 13);
            this.AnalyzeGB.Name = "AnalyzeGB";
            this.AnalyzeGB.Size = new System.Drawing.Size(313, 137);
            this.AnalyzeGB.TabIndex = 0;
            this.AnalyzeGB.TabStop = false;
            this.AnalyzeGB.Text = "Analyze";
            // 
            // StartOverButton
            // 
            this.StartOverButton.Location = new System.Drawing.Point(33, 83);
            this.StartOverButton.Name = "StartOverButton";
            this.StartOverButton.Size = new System.Drawing.Size(75, 23);
            this.StartOverButton.TabIndex = 3;
            this.StartOverButton.Text = "Start Over";
            this.StartOverButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(189, 83);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Finish";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(189, 40);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(33, 41);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // InProgressGB
            // 
            this.InProgressGB.Controls.Add(this.PointsBox);
            this.InProgressGB.Controls.Add(this.label2);
            this.InProgressGB.Controls.Add(this.TimeBox);
            this.InProgressGB.Controls.Add(this.label1);
            this.InProgressGB.Location = new System.Drawing.Point(11, 156);
            this.InProgressGB.Name = "InProgressGB";
            this.InProgressGB.Size = new System.Drawing.Size(315, 88);
            this.InProgressGB.TabIndex = 1;
            this.InProgressGB.TabStop = false;
            this.InProgressGB.Text = "In Progress";
            // 
            // PointsBox
            // 
            this.PointsBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PointsBox.Location = new System.Drawing.Point(146, 48);
            this.PointsBox.Name = "PointsBox";
            this.PointsBox.ReadOnly = true;
            this.PointsBox.Size = new System.Drawing.Size(85, 20);
            this.PointsBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Points:";
            // 
            // TimeBox
            // 
            this.TimeBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TimeBox.Location = new System.Drawing.Point(152, 19);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.ReadOnly = true;
            this.TimeBox.Size = new System.Drawing.Size(80, 20);
            this.TimeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time Elapsed:";
            // 
            // DataGB
            // 
            this.DataGB.Controls.Add(this.AddSepButton);
            this.DataGB.Controls.Add(this.SaveButton);
            this.DataGB.Location = new System.Drawing.Point(13, 250);
            this.DataGB.Name = "DataGB";
            this.DataGB.Size = new System.Drawing.Size(313, 83);
            this.DataGB.TabIndex = 2;
            this.DataGB.TabStop = false;
            this.DataGB.Text = "Data";
            // 
            // AddSepButton
            // 
            this.AddSepButton.Location = new System.Drawing.Point(33, 38);
            this.AddSepButton.Name = "AddSepButton";
            this.AddSepButton.Size = new System.Drawing.Size(87, 23);
            this.AddSepButton.TabIndex = 1;
            this.AddSepButton.Text = "Segment Data";
            this.AddSepButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(189, 38);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save Data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DataGrabberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 345);
            this.Controls.Add(this.DataGB);
            this.Controls.Add(this.InProgressGB);
            this.Controls.Add(this.AnalyzeGB);
            this.MaximizeBox = false;
            this.Name = "DataGrabberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Grabber";
            this.TopMost = true;
            this.AnalyzeGB.ResumeLayout(false);
            this.InProgressGB.ResumeLayout(false);
            this.InProgressGB.PerformLayout();
            this.DataGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnalyzeGB;
        private System.Windows.Forms.Button StartOverButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox DataGB;
        private System.Windows.Forms.Button AddSepButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox InProgressGB;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox PointsBox;
        private System.Windows.Forms.Label label2;
    }
}

