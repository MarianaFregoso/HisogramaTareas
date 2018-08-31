using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Histogramasrtareas
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> _InputImage;
        Image<Gray, byte> _GrayImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filename = "c:\\HilaryDuff.jpg";
            _InputImage = new Image<Bgr, byte>(Filename);
            if (_InputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }
            imageBox1.Image = _InputImage;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;

        }

        private void btnGris_Click(object sender, EventArgs e)
        {
            _GrayImage = _InputImage.Convert<Gray, byte>();
            if (_InputImage == null)
            {
                MessageBox.Show("Imagen no cargada");
                return;
            }
            imageBox2.Image = _GrayImage;
            imageBox2.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.RightClickMenu;
        }

        private void btnHistAzul_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _InputImage[0] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            histogramBox1.AddHistogram("Histograma de color azul", Color.Blue, m, 256, new float[] { 0, 255 });
            histogramBox1.Refresh();
        }

        private void histogramBox2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _InputImage[1] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            histogramBox2.AddHistogram("Histograma de color Verde", Color.Green, m, 256, new float[] { 0, 255 });
            histogramBox2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _InputImage[2] }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            histogramBox3.AddHistogram("Histograma de color Rojo", Color.Red, m, 256, new float[] { 0, 255 });
            histogramBox3.Refresh();
        }
    }
}
