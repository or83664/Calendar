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
    public partial class Form2 : Form
    {
        public Form1 parent;

        public Form2()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;
        }

        public void refresh()
        {
            label1.Text = val;
            checkedListBox1.Items.Clear();
            textBox1.Text = "";

            try

            {
                using (StreamReader sr = new StreamReader(@"notes\" + val + ".txt"))
                {
                    while (sr.Peek() >= 0)
                    {
                        String line = sr.ReadLine();
                        checkedListBox1.Items.Add(line);
                    }  
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }

        private void save()
        {
            using (StreamWriter outputFile = new StreamWriter(@"notes\" + val + ".txt"))
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    string[] lines = { checkedListBox1.Items[i] as string };

                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 1;
            //GIVE UP
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.GetItemChecked(i)==true)
                {
                    
                    switch (count)
                    {
                        case 1:
                            {
                                DialogResult r =  MessageBox.Show("確定要刪除事件嗎?", "DoubleCheck", MessageBoxButtons.YesNo);
                                if (r == DialogResult.Yes)

                                {
                                    count = 2;
                                    MessageBox.Show("2");
                                    checkedListBox1.Items.RemoveAt(i--);
                                }
                                else
                                    count = 3;
                            }
                            break;
                        case 2 :
                            {
                               checkedListBox1.Items.RemoveAt(i--);
                               
                            }
                            break;
                        case 3:
                            {

                            }
                            break;
                    }

                }             
            }
          
           
            save();
            parent.Show();
            parent.refresh();
            this.Hide();

        }

        public string val;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FINISH

            save();
            parent.Show();
            this.Hide();
            parent.refresh();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Activated(object sender, EventArgs e)
        {
           
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            //parent.Show();
            //this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {       
            if (textBox1.Text=="")
            {
                MessageBox.Show("請輸入內容");
            }
            else
            {
                checkedListBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";

            }
        }
    }
}
