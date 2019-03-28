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

namespace WindowsFormsReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox1.Text = of.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(textBox1.Text);
            RichtextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.WriteLine(textBox2.Text);
            sw.Close();
        }

        private void DriveList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FolderList.Items.Clear();

            try
            {
                DriveInfo drive = (DriveInfo)DriveList.SelectedItem;
                foreach (DirectoryInfo dirInfo in drive.RootDirectory.GetDirectories())
                    FolderList.Items.Add(dirInfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FolderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilesList.Items.Clear();

            DirectoryInfo dir = (DirectoryInfo)FolderList.SelectedItem;

            foreach (FileInfo fi in dir.GetFiles())
                FilesList.Items.Add(fi);

        }

        private void FilesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo di in DriveInfo.GetDrives())
                DriveList.Items.Add(di);
        }
    }
}
