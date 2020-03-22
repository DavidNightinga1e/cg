using System;
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
            _objectDispatcher.Render(image);
            PictureBox.Image = image;
        }

        private void ButtonGeneratePoly_Click(object sender, EventArgs e)
        {
            var random = new Random();
            _objectDispatcher.ClearPolygons();
            for (int i = 0; i < NumericPolyCount.Value; i++)
            {
                var poly = new Polygon(
                    new Vector3(random.Next(0, 360), random.Next(0, 360), random.Next(0, 360)),
                    new Vector3(random.Next(0, 360), random.Next(0, 360), random.Next(0, 360)),
                    new Vector3(random.Next(0, 360), random.Next(0, 360), random.Next(0, 360)),
                    Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
                _objectDispatcher.AddPolygons(poly);
            }
        }
    }
}