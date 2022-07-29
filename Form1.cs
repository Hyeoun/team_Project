using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_Project {
    public partial class Form1 : Form {
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
                buf.save_bmp(loc);
            }
        }
        private void btn_save1_Click(object sender, EventArgs e)
        {
            if(LeftBox.Image != null)
            {
                switch (MessageBox.Show("선택하신 부분을 저장하시겠습니까? \n (예 : 부분 저장, 아니요 : 전체 저장)",
                "저장", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Bitmap buf = new Bitmap(LeftBox.Image);
                        Save_dlg(buf);
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        break;
                }
            }
        }
        private void btn_save2_Click(object sender, EventArgs e)
        {
            if(RightBox.Image != null)
            {
                switch (MessageBox.Show("선택하신 부분을 저장하시겠습니까? \n (예 : 부분 저장, 아니요 : 전체 저장)",
                "저장", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        Bitmap buf = new Bitmap(RightBox.Image);
                        Save_dlg(buf);
                        break;
                    case DialogResult.No:
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
                Bitmap right_bmp = new Bitmap(LeftBox.Image);
                right_bmp.hist_equal_oper(ref progressBar1);
                RightBox.Image = right_bmp;
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
                Bitmap right_bmp = new Bitmap(LeftBox.Image);
                right_bmp.otsu_oper(ref progressBar1);
                RightBox.Image = right_bmp;
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
                minimapdlg = new Minimapdlg();
                minimapdlg.Owner = this;
                minimapdlg?.Show();  // null이 아니면 show
            }
            else
                minimapdlg.Focus();
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
                        if (((realX + i) < 0 || (realY + j) < 0 || (realY + j) >= LeftBox.Height || (realX + i) >= LeftBox.Width))
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
    }
}
