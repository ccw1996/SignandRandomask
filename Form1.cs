using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signandrandomask
{
    public partial class Form1 : Form
    {
        static String[] a = { "1", "2", "3", "4", "5" };
        static String[] b = { "a", "b", "c", "d", "e" };
        int count = 0;
        int lena = a.Length;
        int lenb = b.Length;
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                if (count < lena)
                {
                    label1.Text = a[count];
                    count++;
                }
                else
                    MessageBox.Show("无数据");
            }  
            else if (radioButton2.Checked == true)
            {
                if (count < lenb)
                {
                    label1.Text = b[count];
                    count++;
                }
                else
                {
                    MessageBox.Show("无数据");
                }
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (count < lena)
                {
                    label1.Text = a[count];
                    count++;
                }
                else
                    MessageBox.Show("已到达最后一个");
            }
            else if (radioButton2.Checked == true)
            {
                if (count < lenb)
                {
                    label1.Text = b[count];
                    count++;
                }
                else
                {
                    MessageBox.Show("已到达最后一个");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (count < lena)
                {
                    label1.Text = a[count];
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (count < lenb)
                {
                    label1.Text = b[count];
                    count++;
                }
                else
                {
                    count = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
