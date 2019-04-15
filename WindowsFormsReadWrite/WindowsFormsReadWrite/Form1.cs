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
            selectfolder.RootFolder = Environment.SpecialFolder.Desktop;
        }

        /* private void button1_Click(object sender, EventArgs e)
         {


         }*/

        /*private void button3_Click(object sender, EventArgs e)
        {

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (selectfolder.ShowDialog() == DialogResult.OK)
            {
                List<string> dirlist = new List<string>();
                List<string> calcArray = new List<string>();
                List<string> folderList = new List<string>();
                string path = selectfolder.SelectedPath;
                string[] files = Directory.GetFiles(path);
                tbCurrentDir.Text = Path.GetDirectoryName(path);
                foreach (string filename in files)
                {
                    if (Path.GetExtension(filename).Contains(".txt"))
                    {
                        tbCurrent.Text = Path.GetFileName(filename) + "\n";

                        StreamReader stream = new StreamReader(filename);

                        string[] word = stream.ReadToEnd().Split(' ');
                        Array.Sort(word);

                        string sortedfile = "\\sorted" + Path.GetFileName(filename);
                        StreamWriter streamWriter = new StreamWriter(Path.GetFullPath(path) + sortedfile);
                        //Test//Console.WriteLine(Path.GetFullPath(path) + sortedfile);
                        // termsListà will be your list of sorted word

                        // counts occurrences
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

                        dirlist.Add(Path.GetPathRoot(path));
                        folderList.Add(sortedfile);

                    }
                    else if (Path.GetExtension(filename).Contains(".calc"))
                    {
                        string[] words = File.ReadAllLines(filename);
                        foreach (string cword in words)
                        {
                            //MessageBox.Show(Calc.Tocalc(Calcword));
                            calcArray.Add(Calc.Tocalc(cword));
                        }

                    }
                    DateTime now = DateTime.Now;
                    StreamWriter calw = new StreamWriter(Path.GetFullPath(path) + "\\"+now.ToShortDateString()+" Answ.txt");
                    foreach (string item in calcArray)
                    {
                        calw.WriteLine(item);
                    }
                    calw.Close();
                }
                DriveList.DataSource = dirlist;
                FolderList.DataSource = folderList;
                
                ///FilesList.DataSource = allfiles;

            }
            
            
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(tbCurrentDir.Text);
            tbCurrent.Text = sr.ReadToEnd();
            sr.Close();
        }
=======
                    }
                    /*private void button2_Click(object sender, EventArgs e)
                    {
                        StreamReader sr = new StreamReader(tbCurrentDir.Text);
                        tbCurrent.Text = sr.ReadToEnd();
                        sr.Close();
                    }
>>>>>>> f87bc050440ee558fcc2d34dfecf0e63905f2ba5

                    private void button3_Click_1(object sender, EventArgs e)
                    {
                        StreamWriter sw = new StreamWriter(tbCurrentDir.Text, true);
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
                    */
                }
            }
        
