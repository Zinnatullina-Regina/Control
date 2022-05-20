using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control
{
    public partial class Form1 : Form
    {
        int g = 1;



        public Form1()
        {
            Timer timer1 = new Timer();
            InitializeComponent();
            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g++;
            if (g == 2) 
            {
                panel2.Visible = true;
            
            }
            else if (g == 3)
            {
                panel2.Visible = true;
                panel3.Visible = true;
            }
            else if (g == 4)

            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
            }
            else if (g == 5)
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
            }
            else if (g == 6)
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                panel6.Visible = true;
            }
            else if (g > 6)
            {
                MessageBox.Show("Вам должно хватить этих будильников");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
            timer2.Start();
        }
    }
}
