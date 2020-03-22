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
        private readonly ObjectDispatcher _objectDispatcher;

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
                new Vector3((float) NumericSurfacePointBLX.Value, (float) NumericSurfacePointBLY.Value,
                    (float) NumericSurfacePointBLZ.Value),
                new Vector3((float) NumericSurfacePointTLX.Value, (float) NumericSurfacePointTLY.Value,
                    (float) NumericSurfacePointTLZ.Value),
                new Vector3((float) NumericSurfacePointBRX.Value, (float) NumericSurfacePointBRY.Value,
                    (float) NumericSurfacePointBRZ.Value),
                new Vector3((float) NumericSurfacePointTRX.Value, (float) NumericSurfacePointTRY.Value,
                    (float) NumericSurfacePointTRZ.Value)));
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

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            _objectDispatcher.SetSurface(new BilinearSurface(
                new Vector3((float) NumericSurfacePointBLX.Value, (float) NumericSurfacePointBLY.Value,
                    (float) NumericSurfacePointBLZ.Value),
                new Vector3((float) NumericSurfacePointTLX.Value, (float) NumericSurfacePointTLY.Value,
                    (float) NumericSurfacePointTLZ.Value),
                new Vector3((float) NumericSurfacePointBRX.Value, (float) NumericSurfacePointBRY.Value,
                    (float) NumericSurfacePointBRZ.Value),
                new Vector3((float) NumericSurfacePointTRX.Value, (float) NumericSurfacePointTRY.Value,
                    (float) NumericSurfacePointTRZ.Value)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            NumericSurfacePointBLX.Value = random.Next(-400, 400);
            NumericSurfacePointBLY.Value = random.Next(-400, 400);
            NumericSurfacePointBLZ.Value = random.Next(-400, 400);
            NumericSurfacePointBRX.Value = random.Next(-400, 400);
            NumericSurfacePointBRY.Value = random.Next(-400, 400);
            NumericSurfacePointBRZ.Value = random.Next(-400, 400);
            NumericSurfacePointTLX.Value = random.Next(-400, 400);
            NumericSurfacePointTLY.Value = random.Next(-400, 400);
            NumericSurfacePointTLZ.Value = random.Next(-400, 400);
            NumericSurfacePointTRX.Value = random.Next(-400, 400);
            NumericSurfacePointTRY.Value = random.Next(-400, 400);
            NumericSurfacePointTRZ.Value = random.Next(-400, 400);
        }
    }
}