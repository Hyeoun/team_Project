//복사

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_Project
{
    public partial class Form1 : Form
    {
        Image OriginImage;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "BMP files(*.bmp)|*.bmp";
        }

        private void btn_load1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LeftBox.Load(openFileDialog1.FileName);
                OriginImage = LeftBox.Image;
            }
        }
        private void btn_load2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RightBox.Load(openFileDialog1.FileName);
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
                        Save_dlg(new Bitmap(OriginImage));
                        break;
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
                        Save_dlg(new Bitmap(OriginImage));
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
                Bitmap left_bmp = new Bitmap(LeftBox.Image);
                Bitmap new_bmp = new Bitmap(left_bmp);
                new_bmp.expansion_oper(left_bmp, ref progressBar1);
                RightBox.Image = new_bmp;
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
                Bitmap left_bmp = new Bitmap(LeftBox.Image);
                Bitmap new_bmp = new Bitmap(left_bmp);
                new_bmp.erosion_oper(left_bmp, ref progressBar1);
                RightBox.Image = new_bmp;
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
                Bitmap bmp = new Bitmap(LeftBox.Image.Width, LeftBox.Image.Height);

                int row = bmp.Width;
                int col = bmp.Height;
                int[] hist = new int[256];
                int[] sum = new int[256];
                byte[] newpixel = new byte[256];
                byte[] pa = new byte[row * col];
                byte[] pb = new byte[row * col];

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Color color = ((Bitmap)LeftBox.Image).GetPixel(i, j);
                        pa[i * col + j] = color.G;
                    }
                }
                for (int l = 0; l < 256; ++l)
                {
                    int count = 0;

                    for (int i = 0; i < row; ++i)
                    {
                        for (int j = 0; j < col; ++j)
                        {
                            if (pa[i * col + j] == l)
                            {
                                count++;
                                hist[l] = count;
                            }
                        }
                    }
                }
                sum[0] = hist[0];

                for (int i = 1; i < 256; ++i)
                {
                    sum[i] = sum[i - 1] + hist[i];
                    newpixel[i] = (byte)((sum[i] * 255) / (row * col));
                }
                for (int i = 0; i < row; ++i)
                {
                    for (int j = 0; j < col; ++j)
                    {
                        Color ncolor;
                        pb[i * col + j] = newpixel[pa[i * col + j]];
                        ncolor = Color.FromArgb(255, pb[i * col + j], pb[i * col + j], pb[i * col + j]);
                        bmp.SetPixel(i, j, ncolor);
                    }
                }
                RightBox.Image = bmp;
                RightBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //Bitmap right_bmp = new Bitmap(LeftBox.Image);
                //right_bmp.hist_equal_oper(ref progressBar1);
                //RightBox.Image = right_bmp;
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
                Bitmap bmp = new Bitmap(LeftBox.Image.Width, LeftBox.Image.Height);

                int row = bmp.Width;
                int col = bmp.Height;

                int[] hist = new int[256];
                byte[] pa = new byte[row * col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Color color = ((Bitmap)LeftBox.Image).GetPixel(i, j);
                        pa[i * col + j] = color.G;
                    }
                }
                for (int l = 0; l < 256; ++l)
                {
                    int count = 0;

                    for (int i = 0; i < row; ++i)
                    {
                        for (int j = 0; j < col; ++j)
                        {
                            if (pa[i * col + j] == l)
                            {
                                count++;
                                hist[l] = count;
                            }
                        }
                    }
                }

                
                int n = findThreshold(hist);

                for (int i = 0; i < row; ++i)
                {
                    for (int j = 0; j < col; ++j)
                    {
                        Color ncolor;
                        if (pa[i * col + j] < n)
                        {
                            ncolor = Color.FromArgb(255, 0, 0, 0);
                        }
                        else
                        {
                            ncolor = Color.FromArgb(255, 255, 255, 255);
                        }
                        bmp.SetPixel(i, j, ncolor);
                    }
                }

                RightBox.Image = bmp;
                RightBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //Bitmap right_bmp = new Bitmap(LeftBox.Image);
                //right_bmp.otsu_oper(ref progressBar1);
                //RightBox.Image = right_bmp;
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
                Bitmap left_bmp = new Bitmap(LeftBox.Image);
                Bitmap new_bmp = new Bitmap(left_bmp);
                new_bmp.gaussian_oper(left_bmp, ref progressBar1);
                RightBox.Image = new_bmp;
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
                Bitmap left_bmp = new Bitmap(LeftBox.Image);
                Bitmap new_bmp = new Bitmap(left_bmp);
                new_bmp.laplacian_oper(left_bmp, ref progressBar1);
                RightBox.Image = new_bmp;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btn_match_Click(object sender, EventArgs e)
        {

        }

        private Minimapdlg minimapdlg = null;
        private void LeftBox_Click(object sender, EventArgs e)
        {
            if (minimapdlg == null)
            {
                minimapdlg = new Minimapdlg(LeftBox);
                minimapdlg.Owner = this;
                minimapdlg?.Show();  //null이 아니면 show!
            }
            else
                minimapdlg.Focus();

            if(minimapdlg.open == false)
            {
                minimapdlg = null;
                LeftBox_Click(sender, e);
            }
        }

        private void LeftBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (LeftBox.Image == null)
            {
                label1.Text = $" X : {e.X}";
                label2.Text = $" Y : {e.Y}";
            }
            else
            {
                int realX = (int)(e.X * ((double)LeftBox.Image.Width / (double)LeftBox.Width));
                int realY = (int)(e.Y * ((double)LeftBox.Image.Height / (double)LeftBox.Height));

                label1.Text = $"X : " + realX;
                label2.Text = $"Y : " + realY;

                Bitmap bitmap = new Bitmap(101, 101);

                for (int i = -50; i < 50; ++i)
                {
                    for (int j = -50; j < 50; ++j)
                    {
                        if (((realX + i) < 0 || (realY + j) < 0 || (realY + j) >= LeftBox.Image.Height || (realX + i) >= LeftBox.Image.Width))
                        {
                            continue;
                        }
                        else
                        {
                            bitmap.SetPixel(50 + i, 50 + j, ((Bitmap)(LeftBox.Image)).GetPixel(realX + i, realY + j));

                        }
                    }
                }
                byte temp = ((Bitmap)(LeftBox.Image)).GetPixel(realX, realY).R;
                lbl_gray.Text = $"Gray : {temp}";

                scope_box.Image = bitmap;
            }
        }

        private void RightBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (RightBox.Image == null)
            {
                label1.Text = $" X : {e.X}";
                label2.Text = $" Y : {e.Y}";
            }
            else
            {

                int realX = (int)(e.X * ((double)RightBox.Image.Width / (double)RightBox.Width));
                int realY = (int)(e.Y * ((double)RightBox.Image.Height / (double)RightBox.Height));

                label1.Text = $"X : " + realX;
                label2.Text = $"Y : " + realY;

                Bitmap bitmap1 = new Bitmap(101, 101);

                for (int i = -50; i < 50; ++i)
                {
                    for (int j = -50; j < 50; ++j)
                    {
                        if (((realX + i) < 0 || (realY + j) < 0 || (realY + j) >= RightBox.Image.Height || (realX + i) >= RightBox.Image.Width))
                        {
                            continue;
                        }
                        else
                        {
                            bitmap1.SetPixel(50 + i, 50 + j, ((Bitmap)(RightBox.Image)).GetPixel(realX + i, realY + j));

                        }
                    }
                }
                byte temp = ((Bitmap)(RightBox.Image)).GetPixel(realX, realY).R;
                lbl_gray.Text = $"Gray : {temp}";

                scope_box.Image = bitmap1;
            }
        }
    }
}
