﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e
{
    public partial class Form7 : Form
    {
        private TimeSpan remainingTime;
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
           
        }

        private void timer_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                timer.Text = remainingTime.ToString(@"hh\:mm\:ss");
            
      
        }
    

        private void btnconfirm_Click(object sender, EventArgs e)
        {
        remainingTime = TimeSpan.FromHours(24);

            // Start the countdown timer
            countdowntimer.Start();
        }
     }
}
