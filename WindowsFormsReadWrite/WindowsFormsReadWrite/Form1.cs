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
            this.BackgroundImage = Properties.Resources.WFD;
            InitializeComponent();
            var timer = new Timer();
            //change the background image every second  
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            this.BackColor = Color.LightBlue;
            
            InitializeComponent();
            selectfolder.RootFolder = Environment.SpecialFolder.Desktop;
        }
        void timer_Tick(object sender, EventArgs e)
        {
            //add image in list from resource file.  
            List<Bitmap> lisimage = new List<Bitmap>();
            lisimage.Add(Properties.Resources.im);
            lisimage.Add(Properties.Resources.WFD);
            var indexbackimage = DateTime.Now.Second % lisimage.Count;
            this.BackgroundImage = lisimage[indexbackimage];
        }
        List<string> dirlist = new List<string>();
        List<string> calcArray = new List<string>();
        List<string> folderList = new List<string>();


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectfolder.ShowDialog() == DialogResult.OK)
            {

                string path = selectfolder.SelectedPath;
                string[] files = Directory.GetFiles(path);
                tbCurrentDir.Text = Path.GetDirectoryName(path);
                foreach (string filename in files)
                {
                    if (Path.GetExtension(filename).Contains(".txt"))
                    {
                        StreamReader stream = new StreamReader(filename);

                        string[] word = stream.ReadToEnd().Split(' ');
                        Array.Sort(word);

                        string sortedfile = "\\sorted" + Path.GetFileName(filename);
                        StreamWriter streamWriter = new StreamWriter(Path.GetFullPath(path) + sortedfile);

                        var dict = new Dictionary<string, int>();

                        foreach (var value in word)
                        {
                            if (dict.ContainsKey(value))

                                dict[value]++;
                            else

                                dict[value] = 1;
                        }
                        foreach (var pair in dict)

                            Console.WriteLine("{1} times {0}", pair.Key, pair.Value);

                        for (int index = 0; index < dict.Count; index++)
                        {
                            var item = dict.ElementAt(index);
                            string itemKey = item.Key;
                            int itemValue = item.Value;
                            Console.WriteLine("Sorted values: " + itemKey + "," + itemValue);
                            if (itemValue == 1)
                            {
                                streamWriter.WriteLine(itemKey);


                            }
                            else
                            {
                                streamWriter.WriteLine(itemKey + "," + itemValue);
                            }

                        }
                        streamWriter.Close();

                        dirlist.Add(path);
                        folderList.Add(sortedfile);

                    }
                    else if (Path.GetExtension(filename).Contains(".calc"))
                    {
                        string[] words = File.ReadAllLines(filename);
                        foreach (string cword in words)
                        {

                            calcArray.Add(Calc.Tocalc(cword));
                        }

                    }
                    DateTime now = DateTime.Now;

                    StreamWriter calw = new StreamWriter(Path.GetFullPath(path) + "\\" + now.ToShortDateString() + " Answ.txt");
                    foreach (string item in calcArray)
                    {
                        calw.WriteLine(item);
                    }
                    calw.Close();
                    

                }
                MessageBox.Show("Calculations completed in .calc files");
                DriveList.DataSource = dirlist;
                FolderList.DataSource = folderList;



            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string folder = string.Empty;
            foreach (var allDirect in folderList)
            {
                folder = folder + Environment.NewLine + allDirect;
            }
            textBox1.Text = folder;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string sortedfile = string.Empty;
            foreach (var allDirect in dirlist)
            {
                sortedfile = sortedfile + Environment.NewLine + allDirect;
            }
            textBox1.Text = sortedfile;
        }



    }
}           
        
