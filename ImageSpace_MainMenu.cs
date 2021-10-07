using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ImageSpace
{
    public partial class ImageSpace_MainMenu : Form
    {
        // Image File Path
        string imageFilePath;

        //  LinearGradientBrush
        LinearGradientBrush linearGradientBrush;

        // Graphics Class
        Graphics graphics;

        // Bitmap Class
        Bitmap bitmap;

        // Colors & Alpha
        int R1;
        int G1;
        int B1;

        int R2;
        int G2;
        int B2;

        int A;

        public ImageSpace_MainMenu()
        {
            InitializeComponent();
        }

        private void ImageSpace_MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            try
            {
                D_OpenFileDialog.Filter = "PNG Files | *.png | JPG Files | *.jpg";

                if (D_OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFilePath = D_OpenFileDialog.FileName;

                    bitmap = new Bitmap(imageFilePath);

                    Main_PictureBox.Image = bitmap;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            try
            {
                D_SaveFileDialog.Filter = "PNG Files |*.png | JPG Files | *.jpg";

                if (D_SaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageFilePath = D_SaveFileDialog.FileName;

                    bitmap = new Bitmap(Main_PictureBox.Image);

                    bitmap.Save(imageFilePath);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NoFilter_Button_Click(object sender, EventArgs e)
        {
            // NO-FILTER COLORS
            R1 = 0;
            G1 = 0;
            B1 = 0;

            R2 = 0;
            G2 = 0;
            B2 = 0;

            if (Main_PictureBox.Image != null)
            {
                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Void_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // VOID-FILTER COLORS
                R1 = 42;
                G1 = 75;
                B1 = 116;

                R2 = 216;
                G2 = 52;
                B2 = 69;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Melodic_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // MELODIC-FILTER COLORS
                R1 = 12;
                G1 = 55;
                B1 = 216;

                R2 = 66;
                G2 = 92;
                B2 = 19;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Phantom_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // PHANTOM-FILTER COLORS
                R1 = 20;
                G1 = 20;
                B1 = 20;

                R2 = 60;
                G2 = 60;
                B2 = 60;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clockwork_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // CLOCKWORK-FILTER COLORS  
                R1 = 101;
                G1 = 80;
                B1 = 61;

                R2 = 221;
                G2 = 186;
                B2 = 117;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reborn_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // REBORN-FILTER COLORS
                R1 = 80;
                G1 = 140;
                B1 = 22;

                R2 = 228;
                G2 = 235;
                B2 = 230;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Esoteric_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // ESOTERIC-FILTER COLORS
                R1 = 122;
                G1 = 23;
                B1 = 19;

                R2 = 70;
                G2 = 7;
                B2 = 151;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Unhappy_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // UNHAPPY-FILTER COLORS 
                R1 = 29;
                G1 = 23;
                B1 = 192;

                R2 = 236;
                G2 = 173;
                B2 = 181;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Blues_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // BLUES-FILTER COLORS
                R1 = 52;
                G1 = 183;
                B1 = 241;

                R2 = 181;
                G2 = 176;
                B2 = 199;

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddRedColor_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // ADD-RED-COLOR 
                if (R1 <= 245 && R2 <= 245)
                {
                    R1 += 10;
                    R2 += 10;
                }
                else
                {
                    MessageBox.Show("Can't Add More Red Color!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddGreenColor_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // ADD-GREEN-COLOR 
                if (G1 <= 245 && G2 <= 245)
                {
                    G1 += 10;
                    G2 += 10;
                }
                else
                {
                    MessageBox.Show("Can't Add More Green Color!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBlueColor_Button_Click(object sender, EventArgs e)
        {
            if (Main_PictureBox.Image != null)
            {
                // ADD-BLUE-COLOR 
                if (B1 <= 245 && B2 <= 245)
                {
                    B1 += 10;
                    B2 += 10;
                }
                else
                {
                    MessageBox.Show("Can't Add More Blue Color!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                A = 65;

                Main_PictureBox.Image = bitmap = new Bitmap(imageFilePath);

                ApplyGradient(R1, G1, B1, R2, G2, B2, A);
            }
            else
            {
                MessageBox.Show("Please Open An Image!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyGradient(int firstRED, int firstGREEN, int firstBLUE, int secondRED, int secondGREEN, int secondBLUE, int ALPHA)
        {
            graphics = Graphics.FromImage(bitmap);

            linearGradientBrush = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(bitmap.Width, bitmap.Height)), Color.FromArgb(ALPHA, firstRED, firstGREEN, firstBLUE), Color.FromArgb(ALPHA, secondRED, secondGREEN, secondBLUE), LinearGradientMode.Vertical);

            graphics.FillRectangle(linearGradientBrush, new Rectangle(0, 0, bitmap.Width, bitmap.Height));

            Main_PictureBox.Image = bitmap;
        }
    }
}