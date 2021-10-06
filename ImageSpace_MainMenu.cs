using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageSpace
{
    public partial class ImageSpace_MainMenu : Form
    {
        // Image File Path
        string imageFilePath;

        public ImageSpace_MainMenu()
        {
            InitializeComponent();
        }

        private void ImageSpace_MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            D_OpenFileDialog.Filter = "PNG Files | *.png";
            
            if (D_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = D_OpenFileDialog.FileName; 
            }

            Bitmap bitmap = new Bitmap(imageFilePath);

            Main_PictureBox.Image = bitmap;
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            D_SaveFileDialog.Filter = "PNG Files |*.png";

            if (D_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = D_SaveFileDialog.FileName;
            }

            Bitmap bitmap = new Bitmap(Main_PictureBox.Image);

            bitmap.Save(imageFilePath);
        }
    }
}
