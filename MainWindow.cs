using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace team_Project
{
    public partial class MainWindow : MetroForm
    {
        Bitmap O_left_img;
        Bitmap O_right_img;
        public static Rectangle rect;
        public static Rectangle rect2;
        private Minimapdlg minimapdlg = null;

        bool isModalOpened = false;

        public MainWindow()
        {
            InitializeComponent();
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "BMP files(*.bmp)|*.bmp";
        }

        public static Image resizeImage(Image image)
        {
            if (image != null)
            {
                rect2 = rect;
                Bitmap cutBitmap = new Bitmap(image);
                cutBitmap = cutBitmap.Clone(new Rectangle(rect2.X, rect2.Y, rect2.Width, rect2.Height), System.Drawing.Imaging.PixelFormat.Undefined);

                return cutBitmap;
            }
            else
            {
                return image;
            }
        }
        private void btn_load1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LeftBox.Load(openFileDialog1.FileName);
                O_left_img = new Bitmap(LeftBox.Image);
                rect.X = 0;
                rect.Y = 0;
                rect.Width = O_left_img.Width;
                rect.Height = O_left_img.Height;
                rect2.X = 0;
                rect2.Y = 0;
                rect2.Width = O_left_img.Width;
                rect2.Height = O_left_img.Height;
            }
        }
        private void btn_load2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RightBox.Load(openFileDialog1.FileName);
                O_right_img = new Bitmap(RightBox.Image);
                rect2.X = 0;
                rect2.Y = 0;
                rect2.Width = O_right_img.Width;
                rect2.Height = O_right_img.Height;
            }
        }
        private void Save_dlg(Bitmap buf)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string loc = saveFileDialog1.FileName.ToString();
                buf.Save(loc);
            }
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            if (LeftBox.Image != null)
            {
                switch (MessageBox.Show("선택하신 부분을 저장하시겠습니까? \n (예 : 부분 저장, 아니요 : 전체 저장)",
                "저장", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Bitmap buf = new Bitmap(LeftBox.Image);
                        Save_dlg(buf);
                        break;
                    case DialogResult.No:
                        Save_dlg(new Bitmap(O_left_img));
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }
        private void btn_save2_Click(object sender, EventArgs e)
        {
            if (RightBox.Image != null)
            {
                switch (MessageBox.Show("선택하신 부분을 저장하시겠습니까? \n (예 : 부분 저장, 아니요 : 전체 저장)",
                "저장", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Bitmap buf = new Bitmap(RightBox.Image);
                        Save_dlg(buf);
                        break;
                    case DialogResult.No:
                        Save_dlg(new Bitmap(O_right_img));
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }
        private void btn_exp_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.expansion_oper(O_left_img, progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btn_ero_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.erosion_oper(O_left_img, progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btn_hist_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.hist_equal_oper(progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btn_otsu_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.otsu_oper(progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btn_gau_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.gaussian_oper(O_left_img, progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void btn_lap_Click(object sender, EventArgs e)
        {
            try
            {
                O_right_img = new Bitmap(O_left_img);
                O_right_img.laplacian_oper(O_left_img, progressBar1);
                RightBox.Image = resizeImage(O_right_img);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void btn_match_Click(object sender, EventArgs e)
        {
            if (LeftBox.Image != null && RightBox.Image != null)
            {
                Bitmap left_bmp = new Bitmap(LeftBox.Image);
                Bitmap right_bmp = new Bitmap(RightBox.Image);
                Point match_p = left_bmp.match_img(right_bmp, progressBar1);
                MessageBox.Show($"X:{match_p.X}, Y:{match_p.Y}");
            }
        }

        private void LeftBox_Click(object sender, EventArgs e)
        {
            if (isModalOpened || LeftBox.Image == null)
            {
                return;
            }

            if (minimapdlg == null)
            {
                isModalOpened = true;
                minimapdlg = new Minimapdlg(LeftBox, O_left_img);
                minimapdlg.FormClosed += (o, exx) => isModalOpened = false;
                minimapdlg.Owner = this;
                minimapdlg?.Show();  //null이 아니면 show!
            }
            else
                minimapdlg.Focus();

            if (minimapdlg.open == false)
            {
                minimapdlg = null;
                LeftBox_Click(sender, e);
            }
        }
        private void RightBox_Click(object sender, EventArgs e)
        {
            if (isModalOpened || RightBox.Image == null)
            {
                return;
            }

            if (minimapdlg == null)
            {
                isModalOpened = true;
                minimapdlg = new Minimapdlg(RightBox, O_right_img, false);
                minimapdlg.FormClosed += (o, exx) => isModalOpened = false;
                minimapdlg.Owner = this;
                minimapdlg?.Show();
            }
            else
                minimapdlg.Focus();

            if (minimapdlg.open == false)
            {
                minimapdlg = null;
                RightBox_Click(sender, e);
            }
        }

        private void LeftBox_MouseMove(object sender, MouseEventArgs e)
        {
            scope_img(ref LeftBox, e);
        }

        private void RightBox_MouseMove(object sender, MouseEventArgs e)
        {
            scope_img(ref RightBox, e);
        }

        private void scope_img(ref PictureBox pic_box, MouseEventArgs e)
        {
            if (pic_box.Image == null)
            {
                label1.Text = $" X : {e.X}";
                label2.Text = $" Y : {e.Y}";
            }
            else
            {
                int realX = (int)(e.X * ((double)pic_box.Image.Width / (double)pic_box.Width));
                int realY = (int)(e.Y * ((double)pic_box.Image.Height / (double)pic_box.Height));

                //label1.Text = $"X : " + realX;
                //label2.Text = $"Y : " + realY;

                label1.Text = $"X : {realX + rect.X}";
                label2.Text = $"Y : {realY + rect.Y}";

                Bitmap bitmap = new Bitmap(31, 31);

                for (int i = -15; i < 15; ++i)
                {
                    for (int j = -15; j < 15; ++j)
                    {
                        if (((realX + i) < 0 || (realY + j) < 0 || (realY + j) >= pic_box.Image.Height || (realX + i) >= pic_box.Image.Width))
                        {
                            continue;
                        }
                        else
                        {
                            bitmap.SetPixel(15 + i, 15 + j, ((Bitmap)(pic_box.Image)).GetPixel(realX + i, realY + j));
                        }
                    }
                }
                byte temp = ((Bitmap)(pic_box.Image)).GetPixel(realX, realY).R;
                lbl_gray.Text = $"Gray : {temp}";

                scope_box.Image = bitmap;
            }
        }


    }
}

