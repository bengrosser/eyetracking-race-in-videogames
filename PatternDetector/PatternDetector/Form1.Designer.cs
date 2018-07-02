namespace PatternDetector
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
            this.shapeDetector = new System.Windows.Forms.GroupBox();
            this.startButton = new System.Windows.Forms.Button();
            this.patternLabel = new System.Windows.Forms.Label();
            this.allSelect = new System.Windows.Forms.CheckBox();
            this.otherSelect = new System.Windows.Forms.CheckBox();
            this.triangleSelect = new System.Windows.Forms.CheckBox();
            this.openData = new System.Windows.Forms.GroupBox();
            this.fileLabel = new System.Windows.Forms.Label();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.dataAccessButton = new System.Windows.Forms.Button();
            this.openDataPrompt = new System.Windows.Forms.OpenFileDialog();
            this.shapeDetector.SuspendLayout();
            this.openData.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeDetector
            // 
            this.shapeDetector.Controls.Add(this.startButton);
            this.shapeDetector.Controls.Add(this.patternLabel);
            this.shapeDetector.Controls.Add(this.allSelect);
            this.shapeDetector.Controls.Add(this.otherSelect);
            this.shapeDetector.Controls.Add(this.triangleSelect);
            this.shapeDetector.Location = new System.Drawing.Point(13, 112);
            this.shapeDetector.Name = "shapeDetector";
            this.shapeDetector.Size = new System.Drawing.Size(323, 133);
            this.shapeDetector.TabIndex = 0;
            this.shapeDetector.TabStop = false;
            this.shapeDetector.Text = "Pattern Shapes";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(185, 71);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(19, 29);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(294, 13);
            this.patternLabel.TabIndex = 5;
            this.patternLabel.Text = "Select which pattern you would like to detect then click start:";
            // 
            // allSelect
            // 
            this.allSelect.AutoSize = true;
            this.allSelect.Location = new System.Drawing.Point(22, 100);
            this.allSelect.Name = "allSelect";
            this.allSelect.Size = new System.Drawing.Size(37, 17);
            this.allSelect.TabIndex = 4;
            this.allSelect.Text = "All";
            this.allSelect.UseVisualStyleBackColor = true;
            // 
            // otherSelect
            // 
            this.otherSelect.AutoSize = true;
            this.otherSelect.Location = new System.Drawing.Point(22, 77);
            this.otherSelect.Name = "otherSelect";
            this.otherSelect.Size = new System.Drawing.Size(84, 17);
            this.otherSelect.TabIndex = 3;
            this.otherSelect.Text = "Another one";
            this.otherSelect.UseVisualStyleBackColor = true;
            // 
            // triangleSelect
            // 
            this.triangleSelect.AutoSize = true;
            this.triangleSelect.Location = new System.Drawing.Point(20, 54);
            this.triangleSelect.Name = "triangleSelect";
            this.triangleSelect.Size = new System.Drawing.Size(64, 17);
            this.triangleSelect.TabIndex = 2;
            this.triangleSelect.Text = "Triangle";
            this.triangleSelect.UseVisualStyleBackColor = true;
            // 
            // openData
            // 
            this.openData.Controls.Add(this.fileLabel);
            this.openData.Controls.Add(this.fileBox);
            this.openData.Controls.Add(this.dataAccessButton);
            this.openData.Location = new System.Drawing.Point(9, 13);
            this.openData.Name = "openData";
            this.openData.Size = new System.Drawing.Size(323, 93);
            this.openData.TabIndex = 1;
            this.openData.TabStop = false;
            this.openData.Text = "Open Data";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(164, 16);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(72, 13);
            this.fileLabel.TabIndex = 2;
            this.fileLabel.Text = "You selected:";
            // 
            // fileBox
            // 
            this.fileBox.Cursor = System.Windows.Forms.Cursors.No;
            this.fileBox.Enabled = false;
            this.fileBox.Location = new System.Drawing.Point(168, 37);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(145, 20);
            this.fileBox.TabIndex = 1;
            // 
            // dataAccessButton
            // 
            this.dataAccessButton.Location = new System.Drawing.Point(31, 34);
            this.dataAccessButton.Name = "dataAccessButton";
            this.dataAccessButton.Size = new System.Drawing.Size(75, 23);
            this.dataAccessButton.TabIndex = 0;
            this.dataAccessButton.Text = "Fetch Data";
            this.dataAccessButton.UseVisualStyleBackColor = true;
            this.dataAccessButton.Click += new System.EventHandler(this.dataAccessButton_Click);
            // 
            // openDataPrompt
            // 
            this.openDataPrompt.FileName = "To begin, fetch the data and select a file";
            this.openDataPrompt.FileOk += new System.ComponentModel.CancelEventHandler(this.openDataPrompt_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 257);
            this.Controls.Add(this.openData);
            this.Controls.Add(this.shapeDetector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.shapeDetector.ResumeLayout(false);
            this.shapeDetector.PerformLayout();
            this.openData.ResumeLayout(false);
            this.openData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shapeDetector;
        private System.Windows.Forms.GroupBox openData;
        private System.Windows.Forms.Button dataAccessButton;
        private System.Windows.Forms.OpenFileDialog openDataPrompt;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.CheckBox allSelect;
        private System.Windows.Forms.CheckBox otherSelect;
        private System.Windows.Forms.CheckBox triangleSelect;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.TextBox fileBox;
    }
}

