using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using XD合并导出图.Model;

namespace XD合并导出图
{
    public partial class Form1 : Form
    {
        private string XDFileFullName
        {
            set
            {
                this.Txt_XDFile.Text = value;

                var DirectoryName = Path.GetDirectoryName(XDFileFullName);
                if (string.IsNullOrEmpty(ExportImagecDictionary))
                    ExportImagecDictionary = DirectoryName;
                if (string.IsNullOrEmpty(ResultImage))
                {
                    var ResultImageName = Path.GetFileNameWithoutExtension(XDFileFullName);
                    ResultImage = Path.Combine(DirectoryName, ResultImageName + "_Merge.png");
                }
            }
            get { return this.Txt_XDFile.Text; }
        }

        private string ExportImagecDictionary
        {
            set { this.Txt_ExportImagecDictionary.Text = value; }
            get { return this.Txt_ExportImagecDictionary.Text; }
        }

        private string ResultImage
        {
            set { this.Txt_ResultImage.Text = value; }
            get { return this.Txt_ResultImage.Text; }
        }

        private Color Background
        {
            set { this.Pic_BackgroundColor.BackColor = value; }
            get { return this.Pic_BackgroundColor.BackColor; }
        }

        protected Color TitleColor;
        protected Font font;

        private string ExportImageExtension
        {
            get { return this.Cmb_Extension.SelectedItem.ToString(); }
        }

        public Form1()
        {
            InitializeComponent();
            this.Cmb_Extension.SelectedIndex = 0;
            Background = Color.FromArgb(228, 228, 228);
            TitleColor = Color.FromArgb(134, 134, 134);
            Dlg_Color.Color = BackColor;
            Dlg_Font.Color = TitleColor;
            Dlg_Font.ShowColor = true;
            font = (Font)Dlg_Font.Font.Clone();
        }

        private void Btn_XDFile_Click(object sender, EventArgs e)
        {
            if (Dlg_XDFile.ShowDialog() == DialogResult.OK)
            {
                XDFileFullName = Dlg_XDFile.FileName;
            }
        }

        private void Btn_ExportImagecDictionary_Click(object sender, EventArgs e)
        {
            if (Dlg_ExportImagecDictionary.ShowDialog() == DialogResult.OK)
            {
                ExportImagecDictionary = Dlg_ExportImagecDictionary.SelectedPath;
            }
        }

        private void Btn__ResultImage_Click(object sender, EventArgs e)
        {
            if (Dlg_ResultImage.ShowDialog() == DialogResult.OK)
            {
                ResultImage = Dlg_ResultImage.FileName;
            }
        }

        private void Btn_Build_Click(object sender, EventArgs e)
        {
            Bitmap MergeImage = null;
            Graphics graphics = null;
            SolidBrush brush = null;
            try
            {
                var ResultImageExtension = Path.GetExtension(ResultImage);
                ImageFormat imageFormat = ImageFormat.Png;
                switch (ResultImageExtension.ToLower())
                {
                    case ".png": imageFormat = ImageFormat.Png; break;
                    case ".jpg":
                    case ".jpeg": imageFormat = ImageFormat.Jpeg; break;
                    default:
                        {
                            MessageBox.Show("不支持导出类型为" + ResultImageExtension + "的文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                }
                if (File.Exists(ResultImage))
                {
                    if (MessageBox.Show(ResultImage + "文件已存在，是否覆盖？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                }
                this.Btn_Build.Enabled = false;
                var DirectoryName = Path.GetDirectoryName(XDFileFullName);
                var temp = Guid.NewGuid().ToString();
                var tempDir = Path.Combine(DirectoryName, "ExportTemp");
                var TargetDirectoryName = Path.Combine(tempDir, temp);

                ZipFile.ExtractToDirectory(XDFileFullName, TargetDirectoryName);
                var JsonDataFile = Path.Combine(TargetDirectoryName, "resources", "graphics", "graphicContent.agc");
                var JsonDataStr = File.ReadAllText(JsonDataFile);
                var JsonData = JsonConvert.DeserializeObject<XDJsonModel>(JsonDataStr);
                List<Artboard> artboards = new List<Artboard>();
                foreach (var item in JsonData.artboards)
                {
                    artboards.Add(new Artboard()
                    {
                        Name = (string)item.Value["name"],
                        Height = (int)item.Value["height"],
                        ViewportHeight = (int)item.Value["viewportHeight"],
                        Width = (int)item.Value["width"],
                        X = (int)item.Value["x"],
                        Y = (int)item.Value["y"]
                    });
                }
                var Start_X = artboards.Min(t => t.X);
                var Start_Y = artboards.Min(t => t.Y);
                var MergeWidth = artboards.Max(t => t.X + t.Width) + Margin_Left + Margin_Right - Start_X;
                var MergeHeight = artboards.Max(t => t.Y + t.Height) + Margin_Top + Margin_Bottom - Start_Y;
                MergeImage = new Bitmap(MergeWidth, MergeHeight);
                graphics = Graphics.FromImage(MergeImage);
                brush = new SolidBrush(TitleColor);
                graphics.Clear(Background);
                foreach (var item in artboards)
                {
                    var file = Path.Combine(ExportImagecDictionary, item.Name + ExportImageExtension);
                    if (!File.Exists(file))
                        continue;
                    SizeF size = graphics.MeasureString(item.Name, font);
                    using (Image img = Image.FromFile(file))
                    {
                        var Point_X = item.X + Margin_Left - Start_X;
                        var Point_Y = item.Y + Margin_Top - Start_Y;
                        graphics.DrawString(item.Name, font, brush, Point_X, Point_Y - size.Height - TitleMarginBottom);
                        graphics.DrawImage(img, Point_X, Point_Y);
                    }
                }

                MergeImage.Save(ResultImage, imageFormat);
                Directory.Delete(tempDir, true);
                MessageBox.Show(ResultImage + "生成成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Btn_Build.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (MergeImage != null) MergeImage.Dispose();
                if (graphics != null) graphics.Dispose();
                if (brush != null) brush.Dispose();
            }
        }

        private const int Margin_Left = 40;
        private const int Margin_Right = 40;
        private const int Margin_Top = 60;
        private const int Margin_Bottom = 40;
        private const int TitleMarginBottom = 10;

        private void Btn_Font_Click(object sender, EventArgs e)
        {
            Dlg_Font.ShowDialog();
            font = (Font)Dlg_Font.Font.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (font != null) font.Dispose();
        }

        private void Pic_BackgroundColor_Click(object sender, EventArgs e)
        {
            if (Dlg_Color.ShowDialog() == DialogResult.OK)
            {
                Background = Dlg_Color.Color;
            }
        }
    }
}