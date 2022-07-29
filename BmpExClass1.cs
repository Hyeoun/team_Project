using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace team_Project {
    static class BmpExClass {
        private static void create_head_8bit_save(this FileStream fs, int w, int h)
        {
            BFHeader biheader = new BFHeader();
            biheader.bfType = 19778;
            biheader.bfSize = 14 + 40 + 4 * 256 + w * h;
            biheader.bfReserved1 = 0;
            biheader.bfReserved2 = 0;
            biheader.bfOffBits = 1078;

            byte[] buf = BitConverter.GetBytes(biheader.bfType)
                .Concat(BitConverter.GetBytes(biheader.bfSize))
                .Concat(BitConverter.GetBytes(biheader.bfReserved1))
                .Concat(BitConverter.GetBytes(biheader.bfReserved2))
                .Concat(BitConverter.GetBytes(biheader.bfOffBits)).ToArray();
            fs.Write(buf, 0, buf.Length);
        }
        private static void create_info_8bit_save(this FileStream fs, int w, int h)
        {
            BFinfo binfo = new BFinfo();
            binfo.biSize = 40;
            binfo.biWidth = w;
            binfo.biHeight = h;
            binfo.biPlanes = 0;
            binfo.biBitCount = 8;
            binfo.biCompression = 0;
            binfo.biSizeImage = 0;
            binfo.biXPelsPerMeter = w * 5;
            binfo.biYPelsPerMeter = h * 5;
            binfo.biClrUsed = 0;
            binfo.biClrImportant = 0;

            byte[] buf = BitConverter.GetBytes(binfo.biSize)
                .Concat(BitConverter.GetBytes(binfo.biWidth))
                .Concat(BitConverter.GetBytes(binfo.biHeight))
                .Concat(BitConverter.GetBytes(binfo.biPlanes))
                .Concat(BitConverter.GetBytes(binfo.biBitCount))
                .Concat(BitConverter.GetBytes(binfo.biCompression))
                .Concat(BitConverter.GetBytes(binfo.biSizeImage))
                .Concat(BitConverter.GetBytes(binfo.biXPelsPerMeter))
                .Concat(BitConverter.GetBytes(binfo.biYPelsPerMeter))
                .Concat(BitConverter.GetBytes(binfo.biClrUsed))
                .Concat(BitConverter.GetBytes(binfo.biClrImportant)).ToArray();
            fs.Write(buf, 0, buf.Length);
        }
        private static bool within_range(int n, int m, int x, int y)
        {
            if (0 <= x && x < n && 0 <= y && y < m)
                return true;
            return false;
        }
        private static void histing(Bitmap my_img, ref int[] hist)
        {
            for (int i = 0; i < my_img.Width; ++i)
            {
                for (int j = 0; j < my_img.Height; ++j)
                {
                    ++hist[my_img.GetPixel(j, i).R];
                }
            }
        }
        public static void expansion_oper(this Bitmap my_img, Bitmap ori_img, ref ProgressBar pro)
        {
            int width = my_img.Width;
            int height = my_img.Height;

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    byte max = 0;
                    for (int i = y - 1; i <= y + 1; ++i)
                    {
                        for (int j = x - 1; j <= x + 1; ++j)
                        {
                            if (within_range(width, height, j, i) && (ori_img.GetPixel(j, i)).R > max)
                                max = (ori_img.GetPixel(j, i)).R;
                        }
                    }
                    my_img.SetPixel(x, y, Color.FromArgb(max, max, max));
                }
                pro.Value = (int)(((y + 1) * width) / (double)(width * height) * 100);
            }
        }
        public static void erosion_oper(this Bitmap my_img, Bitmap ori_img, ref ProgressBar pro)
        {
            int width = my_img.Width;
            int height = my_img.Height;

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    byte min = 255;
                    for (int i = y - 1; i <= y + 1; ++i)
                    {
                        for (int j = x - 1; j <= x + 1; ++j)
                        {
                            if (within_range(width, height, j, i) && (ori_img.GetPixel(j, i)).R < min)
                                min = (ori_img.GetPixel(j, i)).R;
                        }
                    }
                    my_img.SetPixel(x, y, Color.FromArgb(min, min, min));
                }
                pro.Value = (int)(((y + 1) * width) / (double)(width * height) * 100);
            }
        }
        public static void hist_equal_oper(this Bitmap my_img, ref ProgressBar pro)
        {
            int[] hist = Enumerable.Repeat<int>(0, 256).ToArray();
            int[] arr = Enumerable.Repeat<int>(0, 256).ToArray();
            int[] _sum = Enumerable.Repeat<int>(0, 256).ToArray();
            int width = my_img.Width;
            int height = my_img.Height;
            double pre_oper = 255.0 / (width * height);
            histing(my_img, ref hist);

            _sum[0] = hist[0];
            hist[0] = (int)Math.Round(hist[0] * pre_oper);
            for (int i = 1; i < 256; ++i)
            {
                _sum[i] = hist[i] + _sum[i - 1];
                hist[i] = (int)Math.Round(_sum[i] * pre_oper);
            }
            for (int i = 0; i < my_img.Width; ++i)
            {
                for (int j = 0; j < my_img.Height; ++j)
                {
                    byte temp = (byte)hist[my_img.GetPixel(j, i).R];
                    my_img.SetPixel(j, i, Color.FromArgb(temp, temp, temp));
                }
                pro.Value = (int)(((i + 1) * width) / (double)(width * height) * 100);
            }
        }
        public static void otsu_oper(this Bitmap my_img, ref ProgressBar pro)
        {
            int width = my_img.Width;
            int height = my_img.Height;
            int Pixels = width * height;
            int[] hist = Enumerable.Repeat<int>(0, 256).ToArray();
            histing(my_img, ref hist);
            int a_sum = 0;
            for (int i = 0; i < 256; ++i)
            {
                a_sum += hist[i] * i;
            }
            double all_ave = a_sum / (double)Pixels;
            double max = 0;
            int p_sum = 0;
            int m_sum = 0;
            int result = 0;
            for (int i = 0; i < 256; ++i)
            {
                p_sum += hist[i];
                m_sum += hist[i] * i;
                if (p_sum != 0 && p_sum != Pixels)
                {
                    double p1 = (double)p_sum / (double)Pixels;
                    double p2 = 1 - p1;
                    double m1 = (double)m_sum / (double)p_sum;
                    double m2 = (double)(a_sum - m_sum) / (double)(Pixels - p_sum);
                    double res = p1 * Math.Pow((m1 - all_ave), 2.0) + p2 * Math.Pow((m2 - all_ave), 2.0);
                    if (max < res)
                    {
                        max = res;
                        result = i;
                    }
                }
            }
            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    if (my_img.GetPixel(j, i).R > result)
                    {
                        my_img.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        my_img.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                    }
                }
                pro.Value = (int)(((i + 1) * width) / (double)(width * height) * 100);
            }
        }
        public static void gaussian_oper(this Bitmap my_img, Bitmap ori_img, ref ProgressBar pro)
        {
            int width = my_img.Width;
            int height = my_img.Height;

            byte[] gaus_arr = { 1, 2, 1, 2, 4, 2, 1, 2, 1 };
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    byte pix = 0;
                    int a = 0;
                    for (int i = y - 1; i <= y + 1; ++i)
                    {
                        int b = 0;
                        for (int j = x - 1; j <= x + 1; ++j)
                        {
                            if (within_range(height, width, j, i))
                            {
                                double temp = (ori_img.GetPixel(j, i).R / 16.0) * gaus_arr[a * 3 + b];
                                pix += (byte)temp;
                            }
                            ++b;
                        }
                        ++a;
                    }
                    my_img.SetPixel(x, y, Color.FromArgb(pix, pix, pix));
                }
                pro.Value = (int)(((y + 1) * width) / (double)(width * height) * 100);
            }
        }
        public static void laplacian_oper(this Bitmap my_img, Bitmap ori_img, ref ProgressBar pro)
        {
            int width = my_img.Width;
            int height = my_img.Height;

            int[] lapla_arr = { 0, 1, 0, 1, -4, 1, 0, 1, 0 };
            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    int pix = 0;
                    int a = 0;
                    for (int i = y - 1; i <= y + 1; ++i)
                    {
                        int b = 0;
                        for (int j = x - 1; j <= x + 1; ++j)
                        {
                            if (within_range(height, width, j, i))
                            {
                                pix += ori_img.GetPixel(j, i).R * lapla_arr[a * 3 + b];
                            }
                            ++b;
                        }
                        ++a;
                    }
                    my_img.SetPixel(x, y, Color.FromArgb((byte)(pix + 128), (byte)(pix + 128), (byte)(pix + 128)));
                }
                pro.Value = (int)(((y + 1) * width) / (double)(width * height) * 100);
            }
        }

        public static void save_bmp(this Bitmap my_img, in string loc)
        {
            using (FileStream fs = new FileStream(loc, FileMode.Create))
            {
                int width = my_img.Width;
                int height = my_img.Height;
                fs.create_head_8bit_save(width, height);
                fs.create_info_8bit_save(width, height);

                for (int i = 0; i < 256; i++)
                {
                    fs.WriteByte((byte)i);
                    fs.WriteByte((byte)i);
                    fs.WriteByte((byte)i);
                    fs.WriteByte((byte)i);
                }

                for (int i = height - 1; i >= 0; --i)
                {
                    for (int j = 0; j < width; ++j)
                    {
                        fs.WriteByte(my_img.GetPixel(j, i).R);
                    }
                }
            }
        }
    }
}
