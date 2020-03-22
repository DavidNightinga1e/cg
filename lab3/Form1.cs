using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
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
            
            using (var graphics = Graphics.FromImage(image))
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                _objectDispatcher.Render(graphics);
            }

            PictureBox.Image = image;
        }

        private void ButtonRotateUp_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Rotate(Vector3.Axis.Y, 5f);
        }

        private void ButtonRotateLeft_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Rotate(Vector3.Axis.Z, -5f);
        }

        private void ButtonRotateRight_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Rotate(Vector3.Axis.Z, 5f);
        }

        private void ButtonRotateDown_Click(object sender, EventArgs e)
        {
            _objectDispatcher.Rotate(Vector3.Axis.Y, -5f);
        }

        private void ButtonRotateReset_Click(object sender, EventArgs e)
        {
            _objectDispatcher.SetSurface(new BilinearSurface(
                new Vector3(0, 0, 100),
                new Vector3(100, 100, 100),
                new Vector3(100, 0, 0),
                new Vector3(0, 100, 0)));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _objectDispatcher.Rotate(Vector3.Axis.Y, 1f);
                    break;
                case Keys.S:
                    _objectDispatcher.Rotate(Vector3.Axis.Y, -1f);
                    break;
                case Keys.D:
                    _objectDispatcher.Rotate(Vector3.Axis.Z, 1f);
                    break;
                case Keys.A:
                    _objectDispatcher.Rotate(Vector3.Axis.Z, -1f);
                    break;
                default:
                    break;
            }
        }
    }
}