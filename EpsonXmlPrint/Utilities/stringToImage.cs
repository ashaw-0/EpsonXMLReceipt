using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace EpsonXmlPrint.Utilities
{
    public static class stringToImage
    {
        public static attributes makeGray16Image(string chinese)
        {
            attributes attr = new attributes();

            Bitmap chineseTextImage = imageMaker(chinese);
            attr.width = chineseTextImage.Width;
            attr.height = chineseTextImage.Height;
            string raw = toGrayImage(chineseTextImage);
            attr.b64 = toBase64Binary(raw);

            return attr;
        }

        public static string makeGray16Chinese(string chinese)
        {

            Bitmap chineseTextImage = imageMaker(chinese);
            string raw = toGrayImage(chineseTextImage);
            var b64 = toBase64Binary(raw);

            return b64;
        }


        public static Bitmap imageMaker(string chinese)
        {
            int intWidth = 0;
            int intHeight = 0;

            Bitmap objBmpImage = new Bitmap(1, 1);
            Font objFont = new Font("DFKai - SB", 20, FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Graphics objGraphics = Graphics.FromImage(objBmpImage);
            //intWidth = (int)objGraphics.MeasureString(chinese, objFont).Width;
            //intHeight = (int)objGraphics.MeasureString(chinese, objFont).Height;
            intWidth = 256;
            intHeight = 34;
            objBmpImage = new Bitmap(objBmpImage, new Size(intWidth, intHeight) );
            objGraphics = Graphics.FromImage(objBmpImage);
            objGraphics.Clear(Color.White);
            objGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            objGraphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            objGraphics.DrawString(chinese, objFont, new SolidBrush(Color.FromArgb(0, 0, 0)), 0, 0);
            //objBmpImage.Save("f:/myImage.bmp");

            objGraphics.Dispose();


            return objBmpImage;
        }

        public static string toGrayImage(Bitmap bmp)
        {
            Bitmap image1 = bmp;


            //image1 = new Bitmap(@"C:\\Users\\aaron\\Desktop\\js\\brown.bmp", true);

            //Console.WriteLine(image1.GetPixel(0, 0));

            int arrSize = image1.Height * image1.Width * 4;

            byte[] imageB = new byte[arrSize];


            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    var colour = image1.GetPixel(x, y);
                    imageB[x * 4 + y * image1.Width * 4 + 0] = colour.R;
                    imageB[x * 4 + y * image1.Width * 4 + 1] = colour.G;
                    imageB[x * 4 + y * image1.Width * 4 + 2] = colour.B;
                    imageB[x * 4 + y * image1.Width * 4 + 3] = colour.A;

                }
            }
            int halftone = 1;
            var brightness = 1;
            var height = image1.Height;
            var width = image1.Width;
            int[][] m4 = new int[4][];
            m4[0] = new int[] { 0, 9, 2, 11 };
            m4[1] = new int[] { 13, 4, 15, 6 };
            m4[2] = new int[] { 3, 12, 1, 10 };
            m4[3] = new int[] { 16, 7, 14, 5 };
            int[] thermal = new int[] { 0, 7, 13, 19, 23, 27, 31, 35, 40, 44, 49, 52, 54, 55, 57, 59, 61, 62, 64, 66, 67, 69, 70, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 83, 84, 85, 86, 86, 87, 88, 88, 89, 90, 90, 91, 91, 92, 93, 93, 94, 94, 95, 96, 96, 97, 98, 98, 99, 99, 100, 101, 101, 102, 102, 103, 103, 104, 104, 105, 105, 106, 106, 107, 107, 108, 108, 109, 109, 110, 110, 111, 111, 112, 112, 112, 113, 113, 114, 114, 115, 115, 116, 116, 117, 117, 118, 118, 119, 119, 120, 120, 120, 121, 121, 122, 122, 123, 123, 123, 124, 124, 125, 125, 125, 126, 126, 127, 127, 127, 128, 128, 129, 129, 130, 130, 130, 131, 131, 132, 132, 132, 133, 133, 134, 134, 135, 135, 135, 136, 136, 137, 137, 137, 138, 138, 139, 139, 139, 140, 140, 141, 141, 141, 142, 142, 143, 143, 143, 144, 144, 145, 145, 146, 146, 146, 147, 147, 148, 148, 148, 149, 149, 150, 150, 150, 151, 151, 152, 152, 152, 153, 153, 154, 154, 155, 155, 155, 156, 156, 157, 157, 158, 158, 159, 159, 160, 160, 161, 161, 161, 162, 162, 163, 163, 164, 164, 165, 165, 166, 166, 166, 167, 167, 168, 168, 169, 169, 170, 170, 171, 171, 172, 173, 173, 174, 175, 175, 176, 177, 178, 178, 179, 180, 180, 181, 182, 182, 183, 184, 184, 185, 186, 186, 187, 189, 191, 193, 195, 198, 200, 202, 255 };
            byte[] d = imageB;
            int w = width;
            int h = height;
            char[] r = null;
            var arr = ((w + 1 >> 1) * h);
            r = new char[arr];
            int n = 0;
            int p = 0;
            int q = 0;

            var g = brightness;
            for (var j = 0; j < h; j++)
            {
                var i = 0;
                while (i < w)
                {
                    var b = i & 1;
                    var v = thermal[Convert.ToInt32(Math.Pow(((d[p++] * 0.29891 + d[p++] * 0.58661 + d[p++] * 0.11448) * d[p] / 255 + 255 - d[p++]) / 255, 1 / g) * 255) | 0];
                    var v1 = Convert.ToInt32(v / 17) | 0;
                    if (m4[j & 3][i & 3] < v % 17)
                    {
                        v1++;
                    }
                    n |= v1 << ((1 - b) << 2);
                    i++;
                    if (b == 1 || i == w)
                    {
                        r[q++] = Convert.ToChar(n);
                        n = 0;
                    }
                }
            }
            string s = string.Join("", r);


            return s;
        }

        public static string toMonoImage(Bitmap bmp)
        {
            Bitmap image1 = bmp;


            int halftone = 1;
            int brightness = 1;

            int s = halftone;
            int g = brightness;
            int arrSize = image1.Height * image1.Width * 4;
            byte[] imageB = new byte[arrSize];

            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    var colour = image1.GetPixel(x, y);
                    imageB[x * 4 + y * image1.Width * 4 + 0] = colour.R;
                    imageB[x * 4 + y * image1.Width * 4 + 1] = colour.G;
                    imageB[x * 4 + y * image1.Width * 4 + 2] = colour.B;
                    imageB[x * 4 + y * image1.Width * 4 + 3] = colour.A;

                }
            }


            int[][] m8 = new int[8][];
            m8[0] = new int[] { 2, 130, 34, 162, 10, 138, 42, 170 };
            m8[1] = new int[] { 194, 66, 226, 98, 202, 74, 234, 106 };
            m8[2] = new int[] { 50, 178, 18, 146, 58, 186, 26, 154 };
            m8[3] = new int[] { 242, 114, 210, 82, 250, 122, 218, 90 };
            m8[4] = new int[] { 14, 142, 46, 174, 6, 134, 38, 166 };
            m8[5] = new int[] { 206, 78, 238, 110, 198, 70, 230, 102 };
            m8[6] = new int[] { 62, 190, 30, 158, 54, 182, 22, 150 };
            m8[7] = new int[] { 254, 126, 222, 94, 246, 118, 214, 86 };

            byte[] d = imageB;
            int w = image1.Width;
            int h = image1.Height;

            char[] r = null;
            var arr = ((w + 7 >> 3) * h);
            r = new char[arr];

            List<char> array = new List<char>();


            int n = 0;
            int p = 0;
            int q = 0;
            int t = 128;

            List<int> e = new List<int>(); 

            if (s == 1)
            {
                int i = w;
                while (true)
                {
                    if (i == 0)
                    {
                        i = i - 1;
                        break;
                    }
                    i = i - 1;
                    e.Add(0);
                }
                /* while (i == 0) //i-- = i greater than 0, take 1
                 {
                     e.Add(0);
                         i--;
                 }*/
            }
            for (var j = 0; j < h; j++)
            {
                var e1 = 0;
                var e2 = 0;
                int i = 0;
                while (i < w)
                {
                    var b = i & 7;
                    if (s == 0)
                    {
                        t = m8[j & 7][b];
                    }
                    var v = Convert.ToInt32(Math.Pow(((d[p++] * 0.29891 + d[p++] * 0.58661 + d[p++] * 0.11448) * d[p] / 255 + 255 - d[p++]) / 255, 1 / g) * 255) | 0;
                    if (s == 1)
                    {
                        v += e[i] + e1 >> 4;
                        var f = v - (v < t ? 0 : 255);
                        if (i > 0)
                        {
                            e[i - 1] += f;
                        }
                        e[i] = f * 7 + e2;
                        e1 = f * 5;
                        e2 = f * 3;
                    }
                    if (v < t)
                    {
                        n |= 128 >> b;
                    }
                    i++;
                    if (b == 7 || i == w)
                    {
                        r[q++] = Convert.ToChar(n == 16 ? 32 : n);
                        array.Add((char)((n == 16 ? 32 : n)));
                        Console.WriteLine(n);
                        n = 0;
                    }
                }
            }
            string output = string.Join("", r);
            return output;



        }

        public static string toBase64Binary(string s)
        {
            int l = s.Length;
            char[] r = null;
            var arr = ((l + 2) / 3 << 2);
            r = new char[arr];
            string t = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
            var p = (3 - l % 3) % 3;
            var j = 0;
            var i = 0;

            s += "\x00\x00";

            while (i < l)
            {
                var n = s[i++] << 16 | s[i++] << 8 | s[i++];
                r[j++] = t[(n >> 18 & 63)];
                r[j++] = t[(n >> 12 & 63)];
                r[j++] = t[(n >> 6 & 63)];
                r[j++] = t[(n & 63)];
            }

            while (true)
            {
                if (p == 0)
                {
                    p = p - 1;
                    break;
                }
                p = p - 1;
                r[--j] = '=';
            }

            /*   while (p--)
               {
                   r[--j] = "="
               }*/

            string output = string.Join("", r);

            return output;
        }




    }
    public class attributes 
    {
        public string b64;
        public int height;
        public int width;
    }

    public class itemLine
    {
        public string itemName;
        public string itemCode;
        public string chinese;
        public string qty;
        public string price;
        public string chineseB64;
    }

    

}
