﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        private ObjectDispatcher _objectDispatcher;
        
        public Form1()
        {
            InitializeComponent();
            _objectDispatcher = new ObjectDispatcher();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            var image = new Bitmap(360, 360);
            
        }
    }
}