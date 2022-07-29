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
        private void btn_save1_Click(object sender, EventArgs e)
        {
            //저장 누르면 모달로그 꺼내서 이미지 전체 저장 or 확대된 부분 저장
        }
        private void btn_save2_Click(object sender, EventArgs e)
        {
            //저장 누르면 모달로그 꺼내서 이미지 전체 저장 or 확대된 부분 저장
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
    }
}
