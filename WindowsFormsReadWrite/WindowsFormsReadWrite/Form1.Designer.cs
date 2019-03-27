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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RichtextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DriveList = new System.Windows.Forms.ListBox();
            this.FolderList = new System.Windows.Forms.ListBox();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 32);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 262);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 2;
            // 
            // RichtextBox1
            // 
            this.RichtextBox1.Location = new System.Drawing.Point(224, 122);
            this.RichtextBox1.Multiline = true;
            this.RichtextBox1.Name = "RichtextBox1";
            this.RichtextBox1.Size = new System.Drawing.Size(399, 131);
            this.RichtextBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "ReadText";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "WriteText";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // DriveList
            // 
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Location = new System.Drawing.Point(46, 330);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(180, 95);
            this.DriveList.TabIndex = 7;
            this.DriveList.SelectedIndexChanged += new System.EventHandler(this.DriveList_SelectedIndexChanged);
            // 
            // FolderList
            // 
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Location = new System.Drawing.Point(262, 330);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(204, 95);
            this.FolderList.TabIndex = 8;
            this.FolderList.SelectedIndexChanged += new System.EventHandler(this.FolderList_SelectedIndexChanged);
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(513, 330);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(246, 95);
            this.FilesList.TabIndex = 9;
            this.FilesList.SelectedIndexChanged += new System.EventHandler(this.FilesList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 463);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichtextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox RichtextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox DriveList;
        private System.Windows.Forms.ListBox FolderList;
        private System.Windows.Forms.ListBox FilesList;
    }
}

