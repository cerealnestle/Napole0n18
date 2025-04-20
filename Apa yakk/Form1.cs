using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apa_yakk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (DialogResult.OK == OpenFile.ShowDialog())
            {
                this.PbInput.Image = new Bitmap(OpenFile.FileName);
            }
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PbOutput.Image == null)
            {
                MessageBox.Show("Tidak ada citra yang akan disimpan");
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Title = "Simpan file citra";
                saveFile.Filter = "Image File (*.bmp, *.jpg, *.jpeg)|*.bmp;*.jpg;*.jpeg";
                if (DialogResult.OK == saveFile.ShowDialog())
                    this.PbOutput.Image.Save(saveFile.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.PbInput.Image);
            OlahCitra.KeBrightness(copy);
            this.PbOutput.Image = copy;
        }
    }
}
