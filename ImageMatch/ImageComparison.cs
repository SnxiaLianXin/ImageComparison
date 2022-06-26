using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageMatches
{
    /// <summary>
    /// 用于比较 <see cref="Image"/> 图像相似度的类。
    /// </summary>
    public class ImageComparison
    {
        bool _disposed = false;
        Image _Source = null;
        readonly Bitmap[] _Temp = new Bitmap[2];

        /// <summary>
        /// 获取或设置要比较的源图片对象。
        /// </summary>
        public Image Source
        {
            get => _Source;
            set
            {
                _Source?.Dispose();
                _Source = null;
                _Source = value;
            }
        }

        /// <summary>
        /// 用指定的 <see cref="Image"/> 对象初始化 <see cref="ImageComparison"/> 类。
        /// </summary>
        /// <param name="source">要用于初始化的源图片。</param>
        public ImageComparison(Image source)
        {
            Source = source;
        }
        /// <summary>
        /// 用指定的 <see cref="Stream"/> 流初始化 <see cref="ImageComparison"/> 类。
        /// </summary>
        /// <param name="stream">要用于初始化的数据流。</param>
        public ImageComparison(Stream stream)
        {
            Source = Image.FromStream(stream);
            stream?.Dispose();
        }

        /// <summary>
        /// 感知哈希算法；获取此图片源与另一个 <see cref="Image"/> 的相似度。
        /// </summary>
        /// <param name="Match">要与源图像匹配的图像。</param>
        /// <returns>一个 0~100 范围的 <see cref="int"/> 整数，该数指定两个图像之间的相似度。</returns>
        public int PerceptualHashSimilarity(Image Match)
        {
            string source = GetHash(Source);
            string match = GetHash(Match);
            int count = 100;
            for( int i = 0; i < source.Length; i++ )
            {
                if( source[i] != match[i] ) count--;
            }
            return count;
        }
        /// <summary>
        /// 感知哈希算法；获取指定的 <see cref="Image"/> 与另一个 <see cref="Image"/> 的相似度。
        /// </summary>
        /// <param name="Source">要匹配的源图像。</param>
        /// <param name="Match">要与源图像匹配的图像。</param>
        /// <returns>一个 0~100 范围的 <see cref="int"/> 整数，该数指定两个图像之间的相似度。</returns>
        public static int PerceptualHashSimilarity(Image Source, Image Match)
        {
            string source = GetHash(Source);
            string match = GetHash(Match);
            int count = 100;
            for( int i = 0; i < source.Length; i++ )
            {
                if( source[i] != match[i] ) count--;
            }
            return count;
        }

        private static string GetHash(Image Img)
        {
            using( Bitmap Bit = new Bitmap(Img, 8, 8) )
            {
                byte[] grayValues = ReduceColor(Bit);
                byte average = CalcAverage(grayValues);
                string reslut = ComputeBits(grayValues, average);
                return reslut;
            }
        }
        private static byte[] ReduceColor(Bitmap image)
        {
            byte[] grayValues = new byte[image.Width * image.Height];
            for( int x = 0; x < image.Width; x++ )
            {
                for( int y = 0; y < image.Height; y++ )
                {
                    Color color = image.GetPixel(x, y);
                    byte grayValue = Convert.ToByte((color.R * 0.299F + color.G * 0.587F + color.B * 0.114F) + 0.5F);
                    grayValues[x * image.Width + y] = grayValue;
                }
            }
            return grayValues;
        }
        private static byte CalcAverage(byte[] values)
        {
            int sum = 0;
            for( int i = 0; i < values.Length; i++ ) sum += (int) values[i];
            return Convert.ToByte(sum / values.Length);
        }
        private static string ComputeBits(byte[] values, byte averageValue)
        {
            char[] result = new char[values.Length];
            for( int i = 0; i < values.Length; i++ )
            {
                result[i] = values[i] < averageValue ? '0' : '1';
            }
            return new string(result);
        }

        /// <summary>
        /// 释放 <see cref="ImageComparison"/> 所占用的资源。
        /// </summary>
        public void Dispose()
        {
            if( !_disposed )
            {
                for( int x = 0; x < _Temp.Length; x++ )
                {
                    _Temp[x]?.Dispose();
                    _Temp[x] = null;
                }
                Source?.Dispose();
                Source = null;
                _disposed = true;
            }
        }
    }
}
