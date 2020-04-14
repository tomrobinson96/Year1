using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int duration = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            duration++; //increment bt 1 sec
            txtTimeElapsed.Text = duration.ToString();

            if (duration >= 12)
            {
                timer1.Stop();
                MessageBox.Show("time is up!");
            }


        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        int durationDown = 12;
        private void timer2_Tick(object sender, EventArgs e)
        {
            durationDown--;
            txtTimeStarted.Text = durationDown.ToString();

            if (durationDown == 0)
            {
                timer2.Stop();
                MessageBox.Show("Time is Up!");
            }                  
            
        }





        private void label2_Click(object sender, EventArgs e) { }

       

    }
}
