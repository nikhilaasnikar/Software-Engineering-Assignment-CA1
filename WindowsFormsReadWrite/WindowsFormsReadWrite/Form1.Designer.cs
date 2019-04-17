namespace WindowsFormsReadWrite
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
            this.tbCurrentDir = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.btnselectfolder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DriveList = new System.Windows.Forms.ListBox();
            this.FolderList = new System.Windows.Forms.ListBox();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.selectfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCurrentDir
            // 
            this.tbCurrentDir.Location = new System.Drawing.Point(224, 44);
            this.tbCurrentDir.Multiline = true;
            this.tbCurrentDir.Name = "tbCurrentDir";
            this.tbCurrentDir.Size = new System.Drawing.Size(206, 32);
            this.tbCurrentDir.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 2;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(224, 122);
            this.tbCurrent.Multiline = true;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(399, 131);
            this.tbCurrent.TabIndex = 3;
            // 
            // btnselectfolder
            // 
            this.btnselectfolder.Location = new System.Drawing.Point(447, 44);
            this.btnselectfolder.Name = "btnselectfolder";
            this.btnselectfolder.Size = new System.Drawing.Size(84, 32);
            this.btnselectfolder.TabIndex = 4;
            this.btnselectfolder.Text = "SelectFolder";
            this.btnselectfolder.UseVisualStyleBackColor = true;
            this.btnselectfolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ReadText";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "WriteText";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DriveList
            // 
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Location = new System.Drawing.Point(46, 330);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(180, 95);
            this.DriveList.TabIndex = 7;
            // 
            // FolderList
            // 
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Location = new System.Drawing.Point(262, 330);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(204, 95);
            this.FolderList.TabIndex = 8;
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(513, 330);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(246, 95);
            this.FilesList.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "DisplaySortedFiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(858, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(293, 185);
            this.textBox1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(736, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "DisplayDirectories";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 463);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnselectfolder);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbCurrentDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentDir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Button btnselectfolder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox DriveList;
        private System.Windows.Forms.ListBox FolderList;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.FolderBrowserDialog selectfolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}

