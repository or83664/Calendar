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

namespace mid
{
    public partial class Form1 : Form
    {
        private Form2 f;
        public Form1()
        {
            InitializeComponent();
            string pathString = @"notes\";
            System.IO.Directory.CreateDirectory(pathString);
            f = new Form2();
            f.parent = this;
            f.Hide();
            refresh();
        }

        public void refresh()
        {

            label1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            checkedListBox1.Items.Clear();
            //textBox1.Text = "";

            try

            {
                using (StreamReader sr = new StreamReader(@"notes\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        String line = sr.ReadLine();
                        checkedListBox1.Items.Add(line);
                    }

                }
                using (StreamReader sr = new StreamReader(@"notes\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "a.txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        String linebb = sr.ReadLine();
                        String lineaa = sr.ReadLine();
                        bool bb;

                        bool.TryParse(linebb, out bb);
                        int index = checkedListBox1.Items.IndexOf(lineaa);
                        if (index != -1)
                        {
                            checkedListBox1.SetItemChecked(index, bb);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            refresh();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            f.val = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            f.refresh();
            f.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, bool> dic = new Dictionary<string, bool>();
            using (StreamWriter outputFile = new StreamWriter(@"notes\" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "a.txt"))
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    dic.Add(checkedListBox1.Items[i] as string, checkedListBox1.GetItemChecked(i));

                    //  string[] lines = { checkedListBox1.Items[i] as string };
                    string aa = checkedListBox1.Items[i] as string;
                    string bb = checkedListBox1.GetItemChecked(i).ToString();
                    outputFile.WriteLine(bb);
                    outputFile.WriteLine(aa);
                }

            }
        }
        private void checkedListBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
