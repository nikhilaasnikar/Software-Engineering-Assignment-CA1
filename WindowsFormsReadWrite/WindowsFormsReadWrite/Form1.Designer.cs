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
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.btnselectfolder = new System.Windows.Forms.Button();
            this.DriveList = new System.Windows.Forms.ListBox();
            this.FolderList = new System.Windows.Forms.ListBox();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.selectfolder = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCurrentDir
            // 
            this.tbCurrentDir.BackColor = System.Drawing.SystemColors.Window;
            this.tbCurrentDir.Location = new System.Drawing.Point(173, 84);
            this.tbCurrentDir.Multiline = true;
            this.tbCurrentDir.Name = "tbCurrentDir";
            this.tbCurrentDir.Size = new System.Drawing.Size(293, 32);
            this.tbCurrentDir.TabIndex = 0;
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(795, 415);
            this.tbCurrent.Multiline = true;
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(10, 10);
            this.tbCurrent.TabIndex = 3;
            // 
            // btnselectfolder
            // 
            this.btnselectfolder.AutoSize = true;
            this.btnselectfolder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnselectfolder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnselectfolder.Location = new System.Drawing.Point(530, 84);
            this.btnselectfolder.Name = "btnselectfolder";
            this.btnselectfolder.Size = new System.Drawing.Size(103, 32);
            this.btnselectfolder.TabIndex = 4;
            this.btnselectfolder.Text = "SelectFolder";
            this.btnselectfolder.UseVisualStyleBackColor = false;
            this.btnselectfolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DriveList
            // 
            this.DriveList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DriveList.FormattingEnabled = true;
            this.DriveList.Location = new System.Drawing.Point(674, 84);
            this.DriveList.Name = "DriveList";
            this.DriveList.Size = new System.Drawing.Size(304, 134);
            this.DriveList.TabIndex = 7;
            // 
            // FolderList
            // 
            this.FolderList.BackColor = System.Drawing.SystemColors.MenuBar;
            this.FolderList.FormattingEnabled = true;
            this.FolderList.Location = new System.Drawing.Point(674, 242);
            this.FolderList.Name = "FolderList";
            this.FolderList.Size = new System.Drawing.Size(304, 186);
            this.FolderList.TabIndex = 8;
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(777, 421);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(10, 4);
            this.FilesList.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(530, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "DisplaySortedFiles";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(173, 139);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(293, 286);
            this.textBox1.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(534, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 29);
            this.button4.TabIndex = 12;
            this.button4.Text = "DisplayDirectories";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.MinimumSize = new System.Drawing.Size(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Windows Form Application\r\nNikhil Aasnikar and Caleb Eke\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 463);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.FolderList);
            this.Controls.Add(this.DriveList);
            this.Controls.Add(this.btnselectfolder);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.tbCurrentDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentDir;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Button btnselectfolder;
        private System.Windows.Forms.ListBox DriveList;
        private System.Windows.Forms.ListBox FolderList;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.FolderBrowserDialog selectfolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}