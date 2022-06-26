using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageMatches
{
    public partial class Main : Form
    {
        readonly string[] compareFiles = new string[2];

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Match_Click(object sender, EventArgs e)
        {
            if( sourceImg.Image != null && matchImg.Image != null )
            {
                ImageComparison cm = new ImageComparison(sourceImg.Image);
                Tbox_Result.Text = $"[图片源：{compareFiles[0]} 与 {compareFiles[1]}] 的 相似度为：{cm.PerceptualHashSimilarity(matchImg.Image)}%";
                //Tbox_Result.Text = $"[图片源：{compareFiles[0]} 与 {compareFiles[1]}] 的 相似度为：{ImageComparison.PerceptualHashSimilarity(sourceImg.Image, matchImg.Image)}%"; 
                //cm.Dispose();
            }
        }

        private void MatchImg_MouseClick(object sender, MouseEventArgs e)
        {
            if( e.Button is MouseButtons.Right )
            {
                matchImg.Image?.Dispose();
                matchImg.Image = null;
            }
        }

        private void SourceImg_MouseClick(object sender, MouseEventArgs e)
        {
            if( e.Button is MouseButtons.Right )
            {
                sourceImg.Image?.Dispose();
                sourceImg.Image = null;
            }
        }

        private void Btn_Sourceimg_Click(object sender, EventArgs e)
        {
            using( OpenFileDialog o = new OpenFileDialog() { Title = "选择源图像", Filter = "图形图像|*.jpg;*.png;*.jpeg", FileName = null } )
            {
                if( o.ShowDialog() is DialogResult.OK && File.Exists(o.FileName) )
                {
                    using( FileStream fm = new FileStream(o.FileName, FileMode.Open) )
                    {
                        sourceImg.Image?.Dispose();
                        sourceImg.Image = null;
                        compareFiles[0] = Path.GetFileNameWithoutExtension(o.FileName);
                        sourceImg.Image = Image.FromStream(fm);
                        fm.Dispose();
                    }
                }
                o.Dispose();
            }
        }

        private void Btn_MatchImg_Click(object sender, EventArgs e)
        {
            using( OpenFileDialog o = new OpenFileDialog() { Title = "选择匹配图像", Filter = "图形图像|*.jpg;*.png;*.jpeg", FileName = null } )
            {
                if( o.ShowDialog() is DialogResult.OK && File.Exists(o.FileName) )
                {
                    using( FileStream fm = new FileStream(o.FileName, FileMode.Open) )
                    {
                        matchImg.Image?.Dispose();
                        matchImg.Image = null;
                        compareFiles[1] = Path.GetFileNameWithoutExtension(o.FileName);
                        matchImg.Image = Image.FromStream(fm);
                        fm.Dispose();
                    }
                }
                o.Dispose();
            }
        }

        private void SourceImg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if( e.Button is MouseButtons.Left )
            {
                Btn_Sourceimg_Click(null, EventArgs.Empty);
            }
        }

        private void MatchImg_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if( e.Button is MouseButtons.Left )
            {
                Btn_MatchImg_Click(null, EventArgs.Empty);
            }
        }
    }
}
