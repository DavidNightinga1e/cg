using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        private ObjectDispatcher _objectDispatcher;
        
        public Form1()
        {
            InitializeComponent();
            _objectDispatcher = new ObjectDispatcher();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = (MouseEventArgs) e;
            var position = mouseEventArgs.Location;
            
            _objectDispatcher.AddPoint(new Vector2(position.X, position.Y));
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            PictureBox.Image = _objectDispatcher.GetRender();
        }

        private void ButtonClearScreen_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Clear();
        }
    }
}