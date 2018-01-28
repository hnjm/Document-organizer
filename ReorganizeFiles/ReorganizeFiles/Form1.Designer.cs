namespace ReorganizeFles
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
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblSelectedFolder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.lblDest = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblProgressText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkDeleteOrig = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCheckTakenDate = new System.Windows.Forms.CheckBox();
            this.rblModDate = new System.Windows.Forms.RadioButton();
            this.rblCreatedDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Source:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 513);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(526, 23);
            this.progressBar.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(89, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(114, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblSelectedFolder
            // 
            this.lblSelectedFolder.AutoSize = true;
            this.lblSelectedFolder.Location = new System.Drawing.Point(13, 53);
            this.lblSelectedFolder.Name = "lblSelectedFolder";
            this.lblSelectedFolder.Size = new System.Drawing.Size(99, 13);
            this.lblSelectedFolder.TabIndex = 3;
            this.lblSelectedFolder.Text = "-No folder selected-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Destination:";
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(380, 25);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(114, 23);
            this.btnDestination.TabIndex = 5;
            this.btnDestination.Text = "Browse";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(285, 53);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(99, 13);
            this.lblDest.TabIndex = 6;
            this.lblDest.Text = "-No folder selected-";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(220, 455);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(118, 23);
            this.btnProcess.TabIndex = 7;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(7, 229);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(534, 207);
            this.txtDisplay.TabIndex = 8;
            this.txtDisplay.Text = "Progress output";
            // 
            // lblProgressText
            // 
            this.lblProgressText.AutoSize = true;
            this.lblProgressText.Location = new System.Drawing.Point(265, 481);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(24, 13);
            this.lblProgressText.TabIndex = 9;
            this.lblProgressText.Text = "0/0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Type To Move:";
            // 
            // txtFileType
            // 
            this.txtFileType.Location = new System.Drawing.Point(433, 33);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Size = new System.Drawing.Size(40, 20);
            this.txtFileType.TabIndex = 11;
            this.txtFileType.Text = "*.*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delete Original File: ";
            // 
            // chkDeleteOrig
            // 
            this.chkDeleteOrig.AutoSize = true;
            this.chkDeleteOrig.Location = new System.Drawing.Point(182, 35);
            this.chkDeleteOrig.Name = "chkDeleteOrig";
            this.chkDeleteOrig.Size = new System.Drawing.Size(44, 17);
            this.chkDeleteOrig.TabIndex = 13;
            this.chkDeleteOrig.Text = "Yes";
            this.chkDeleteOrig.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Look For \"Date Taken\" (Photos)";
            // 
            // chkCheckTakenDate
            // 
            this.chkCheckTakenDate.AutoSize = true;
            this.chkCheckTakenDate.Location = new System.Drawing.Point(182, 62);
            this.chkCheckTakenDate.Name = "chkCheckTakenDate";
            this.chkCheckTakenDate.Size = new System.Drawing.Size(44, 17);
            this.chkCheckTakenDate.TabIndex = 15;
            this.chkCheckTakenDate.Text = "Yes";
            this.chkCheckTakenDate.UseVisualStyleBackColor = true;
            // 
            // rblModDate
            // 
            this.rblModDate.AutoSize = true;
            this.rblModDate.Location = new System.Drawing.Point(429, 59);
            this.rblModDate.Name = "rblModDate";
            this.rblModDate.Size = new System.Drawing.Size(91, 17);
            this.rblModDate.TabIndex = 16;
            this.rblModDate.Text = "Modified Date";
            this.rblModDate.UseVisualStyleBackColor = true;
            // 
            // rblCreatedDate
            // 
            this.rblCreatedDate.AutoSize = true;
            this.rblCreatedDate.Checked = true;
            this.rblCreatedDate.Location = new System.Drawing.Point(331, 60);
            this.rblCreatedDate.Name = "rblCreatedDate";
            this.rblCreatedDate.Size = new System.Drawing.Size(88, 17);
            this.rblCreatedDate.TabIndex = 17;
            this.rblCreatedDate.TabStop = true;
            this.rblCreatedDate.Text = "Created Date";
            this.rblCreatedDate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rblCreatedDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rblModDate);
            this.groupBox1.Controls.Add(this.chkDeleteOrig);
            this.groupBox1.Controls.Add(this.txtFileType);
            this.groupBox1.Controls.Add(this.chkCheckTakenDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(7, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblDest);
            this.groupBox2.Controls.Add(this.btnDestination);
            this.groupBox2.Controls.Add(this.lblSelectedFolder);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 86);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Document Locations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 546);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "LDT File Organizer v1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblSelectedFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblProgressText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDeleteOrig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCheckTakenDate;
        private System.Windows.Forms.RadioButton rblModDate;
        private System.Windows.Forms.RadioButton rblCreatedDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

