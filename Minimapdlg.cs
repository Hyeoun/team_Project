using System;
using System.Drawing;
using System.Windows.Forms;

namespace team_Project
{
    public partial class Minimapdlg : Form
    {
        public bool open = true;
        Point pt = new Point();
        Size rect_size = new Size();
        Bitmap img;
        PictureBox new_c_box;

        public Minimapdlg(PictureBox new_c_box, Bitmap oImage)
        {
            InitializeComponent();
            this.new_c_box = new_c_box;
            this.img = new Bitmap(oImage);
            zoom_box.Image = img;
            rect_size.Width = (int)((zoom_box.Width / (double)oImage.Width) * MainWindow.rect.Width);
            rect_size.Height = (int)((zoom_box.Height / (double)oImage.Height) * MainWindow.rect.Height);
            pt = MainWindow.rect.Location;
        }

        private void left_box_Paint(object sender, PaintEventArgs e)
        {
            if (zoom_box.Image != null)
            {
                Rectangle rt = new Rectangle(pt.X, pt.Y, rect_size.Width-2, rect_size.Height-2);
                e.Graphics.DrawRectangle(new Pen(Color.Red, 2), rt);
                MainWindow.rect.Location = pt;
                MainWindow.rect.Width = (int)((img.Width / (double)zoom_box.Width) * rect_size.Width);
                MainWindow.rect.Height = (int)((img.Height / (double)zoom_box.Height) * rect_size.Height);
                Show_Img();
            }
        }
        private void left_box_MouseMove(object sender, MouseEventArgs e)
        {
            if (zoom_box.Image != null && e.Button == MouseButtons.Left)
            {
                Size msize = new Size(rect_size.Width / 2, rect_size.Height / 2);
                if (e.X - msize.Width >= 0 && e.X + msize.Width < zoom_box.Width)
                {
                    pt.X = e.X - msize.Width;
                }
                if (e.Y - msize.Height >= 0 && e.Y + msize.Height < zoom_box.Height)
                {
                    pt.Y = e.Y - msize.Height;
                }

                zoom_box.Refresh();
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Zoom_Out();
            }
            else if (e.Button == MouseButtons.Left)
            {
                Zoom_In();
            }
        }
        private void Zoom_In()
        {
            if (zoom_box.Image != null)
            {
                Point tpt = new Point(pt.X + 10, pt.Y + 10);
                Size tsize = new Size(rect_size.Width - 20, rect_size.Height - 20);
                if (tsize.Width - 20 > 50 && tsize.Height - 20 > 50)
                {
                    pt.X = tpt.X;
                    pt.Y = tpt.Y;
                    rect_size.Width = tsize.Width;
                    rect_size.Height = tsize.Height;

                    zoom_box.Refresh();
                }
            }
        }
        private void Zoom_Out()
        {
            if (zoom_box.Image != null)
            {
                Point tpt = new Point(pt.X - 10, pt.Y - 10);
                Size tsize = new Size(rect_size.Width + 20, rect_size.Height + 20);
                if (within_Range(tpt.X, tpt.Y, zoom_box.Width, zoom_box.Height) &&
                    within_Range(tpt.X + tsize.Width, tpt.Y + tsize.Height, zoom_box.Width, zoom_box.Height))
                {
                    pt.X = tpt.X;
                    pt.Y = tpt.Y;
                    rect_size.Width = tsize.Width;
                    rect_size.Height = tsize.Height;
                }
                else if (within_Range(tpt.X, tpt.Y, zoom_box.Width, zoom_box.Height))
                {
                    pt.X = tpt.X;
                    pt.Y = tpt.Y;
                    rect_size.Width += 10;
                    rect_size.Height += 10;
                }
                else if (within_Range(tpt.X + tsize.Width, tpt.Y + tsize.Height, zoom_box.Width, zoom_box.Height))
                {
                    rect_size.Width = tsize.Width;
                    rect_size.Height = tsize.Height;
                }
                else
                {
                    pt.X = 0;
                    pt.Y = 0;
                    rect_size.Width = zoom_box.Width;
                    rect_size.Height = zoom_box.Height;
                }
                zoom_box.Refresh();
            }
        }
        public void Show_Img()
        {
            Bitmap ori_img = new Bitmap(zoom_box.Image);
            int width = ori_img.Width;
            int height = ori_img.Height;
            int box_width = new_c_box.Width;
            int box_height = new_c_box.Height;
            int scale_X = (int)((width / (double)box_width) * pt.X);
            int scale_Y = (int)((height / (double)box_height) * pt.Y);
            int scale_width = (int)((width / (double)box_width) * rect_size.Width);
            int scale_height = (int)((height / (double)box_height) * rect_size.Height);
            Bitmap zoom_img = new Bitmap(scale_width, scale_height);

            for (int i = 0; i < scale_height; ++i)
            {
                for (int j = 0; j < scale_width; ++j)
                {
                    if (within_Range(scale_X + j, scale_Y + i, width, height))
                    {
                        zoom_img.SetPixel(j, i, ori_img.GetPixel(scale_X + j, scale_Y + i));
                    }
                }
            }
            new_c_box.Image = zoom_img;
        }
        private bool within_Range(int x, int y, int w, int h)
        {
            if (x >= 0 && x < w && y >= 0 && y < h) { return true; }
            return false;
        }
        private void Minimapdlg_Deactivate(object sender, EventArgs e)
        {
            open = false;
        }
    }
}
