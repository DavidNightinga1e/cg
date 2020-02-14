using System;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        private readonly ObjectsDispatcher _objectsDispatcher;

        public Form1()
        {
            InitializeComponent();
            _objectsDispatcher = new ObjectsDispatcher();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            PictureBox.Image = _objectsDispatcher.Render();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var mouseEventArgs = (MouseEventArgs) e;
            var position = mouseEventArgs.Location;

            _objectsDispatcher.RotationPoint = new Vector2(position.X, position.Y);
        }

        private void RotateRightButton_Click(object sender, EventArgs e)
        {
            var angle = (float) AngleSetupUpDown.Value;
            _objectsDispatcher.RotateCube(angle);
        }

        private void RotateLeftButton_Click(object sender, EventArgs e)
        {
            var angle = (float) AngleSetupUpDown.Value;
            _objectsDispatcher.RotateCube(-angle);
        }
    }
}