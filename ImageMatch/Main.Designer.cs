namespace ImageMatches
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sourceImg = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_MatchImg = new System.Windows.Forms.Button();
            this.matchImg = new System.Windows.Forms.PictureBox();
            this.Btn_Sourceimg = new System.Windows.Forms.Button();
            this.Btn_Match = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Tbox_Result = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchImg)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceImg
            // 
            this.sourceImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceImg.ErrorImage = null;
            this.sourceImg.InitialImage = null;
            this.sourceImg.Location = new System.Drawing.Point(4, 4);
            this.sourceImg.Margin = new System.Windows.Forms.Padding(4);
            this.sourceImg.Name = "sourceImg";
            this.sourceImg.Size = new System.Drawing.Size(351, 206);
            this.sourceImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceImg.TabIndex = 0;
            this.sourceImg.TabStop = false;
            this.Tip.SetToolTip(this.sourceImg, "双击选择图片；右键清除");
            this.sourceImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SourceImg_MouseClick);
            this.sourceImg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SourceImg_MouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_MatchImg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.matchImg, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Sourceimg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sourceImg, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 259);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_MatchImg
            // 
            this.Btn_MatchImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_MatchImg.Location = new System.Drawing.Point(363, 218);
            this.Btn_MatchImg.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_MatchImg.Name = "Btn_MatchImg";
            this.Btn_MatchImg.Size = new System.Drawing.Size(352, 37);
            this.Btn_MatchImg.TabIndex = 0;
            this.Btn_MatchImg.TabStop = false;
            this.Btn_MatchImg.Text = "选择匹配图片";
            this.Tip.SetToolTip(this.Btn_MatchImg, "选择一个要与图片源比较的图片");
            this.Btn_MatchImg.UseVisualStyleBackColor = true;
            this.Btn_MatchImg.Click += new System.EventHandler(this.Btn_MatchImg_Click);
            // 
            // matchImg
            // 
            this.matchImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matchImg.ErrorImage = null;
            this.matchImg.InitialImage = null;
            this.matchImg.Location = new System.Drawing.Point(363, 4);
            this.matchImg.Margin = new System.Windows.Forms.Padding(4);
            this.matchImg.Name = "matchImg";
            this.matchImg.Size = new System.Drawing.Size(352, 206);
            this.matchImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.matchImg.TabIndex = 1;
            this.matchImg.TabStop = false;
            this.Tip.SetToolTip(this.matchImg, "双击选择图片；右键清除");
            this.matchImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MatchImg_MouseClick);
            this.matchImg.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MatchImg_MouseDoubleClick);
            // 
            // Btn_Sourceimg
            // 
            this.Btn_Sourceimg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Sourceimg.Location = new System.Drawing.Point(4, 218);
            this.Btn_Sourceimg.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Sourceimg.Name = "Btn_Sourceimg";
            this.Btn_Sourceimg.Size = new System.Drawing.Size(351, 37);
            this.Btn_Sourceimg.TabIndex = 0;
            this.Btn_Sourceimg.TabStop = false;
            this.Btn_Sourceimg.Text = "选择源图片";
            this.Tip.SetToolTip(this.Btn_Sourceimg, "选择一个图片作为匹配源");
            this.Btn_Sourceimg.UseVisualStyleBackColor = true;
            this.Btn_Sourceimg.Click += new System.EventHandler(this.Btn_Sourceimg_Click);
            // 
            // Btn_Match
            // 
            this.Btn_Match.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Match.Location = new System.Drawing.Point(4, 4);
            this.Btn_Match.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Match.Name = "Btn_Match";
            this.Btn_Match.Size = new System.Drawing.Size(136, 90);
            this.Btn_Match.TabIndex = 0;
            this.Btn_Match.Text = "匹配";
            this.Tip.SetToolTip(this.Btn_Match, "比较图片源与指定图片的相似度");
            this.Btn_Match.UseVisualStyleBackColor = true;
            this.Btn_Match.Click += new System.EventHandler(this.Btn_Match_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.58177F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.41823F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(727, 373);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09724F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.90276F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_Match, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Tbox_Result, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 271);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(719, 98);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // Tbox_Result
            // 
            this.Tbox_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tbox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbox_Result.Location = new System.Drawing.Point(148, 4);
            this.Tbox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.Tbox_Result.Multiline = true;
            this.Tbox_Result.Name = "Tbox_Result";
            this.Tbox_Result.ReadOnly = true;
            this.Tbox_Result.Size = new System.Drawing.Size(567, 90);
            this.Tbox_Result.TabIndex = 1;
            this.Tbox_Result.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 407);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(771, 446);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图像相似度匹配";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.matchImg)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox matchImg;
        private System.Windows.Forms.Button Btn_Sourceimg;
        private System.Windows.Forms.Button Btn_MatchImg;
        private System.Windows.Forms.Button Btn_Match;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox Tbox_Result;
        private System.Windows.Forms.ToolTip Tip;
    }
}

