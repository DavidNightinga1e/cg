using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
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
            PictureBox.Image = _objectDispatcher.Render();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            _objectDispatcher.RandomizeSegments(Convert.ToInt32(NumericLinesCount.Value));
        }

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Clip();
        }

        private void ButtonGenerateAndClip_Click(object sender, EventArgs e)
        {
            _objectDispatcher.RandomizeSegments(Convert.ToInt32(NumericLinesCount.Value));
            _objectDispatcher.Clip();
        }
    }
}