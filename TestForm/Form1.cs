﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timelineSchedulerControl1.Init(DateTime.Now, DateTime.Now.AddDays(35));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}