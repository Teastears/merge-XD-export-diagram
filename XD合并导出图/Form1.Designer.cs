namespace XD合并导出图
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_XDFile = new System.Windows.Forms.TextBox();
            this.Txt_ExportImagecDictionary = new System.Windows.Forms.TextBox();
            this.Txt_ResultImage = new System.Windows.Forms.TextBox();
            this.Btn_XDFile = new System.Windows.Forms.Button();
            this.Btn_ExportImagecDictionary = new System.Windows.Forms.Button();
            this.Btn__ResultImage = new System.Windows.Forms.Button();
            this.Btn_Build = new System.Windows.Forms.Button();
            this.Dlg_ExportImagecDictionary = new System.Windows.Forms.FolderBrowserDialog();
            this.Dlg_XDFile = new System.Windows.Forms.OpenFileDialog();
            this.Dlg_ResultImage = new System.Windows.Forms.SaveFileDialog();
            this.Cmb_Extension = new System.Windows.Forms.ComboBox();
            this.Dlg_Color = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.Pic_BackgroundColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Dlg_Font = new System.Windows.Forms.FontDialog();
            this.Btn_Font = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BackgroundColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "XD文件路径";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输出文件路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "导出图路径";
            // 
            // Txt_XDFile
            // 
            this.Txt_XDFile.Location = new System.Drawing.Point(106, 5);
            this.Txt_XDFile.Name = "Txt_XDFile";
            this.Txt_XDFile.Size = new System.Drawing.Size(472, 21);
            this.Txt_XDFile.TabIndex = 1;
            // 
            // Txt_ExportImagecDictionary
            // 
            this.Txt_ExportImagecDictionary.Location = new System.Drawing.Point(106, 32);
            this.Txt_ExportImagecDictionary.Name = "Txt_ExportImagecDictionary";
            this.Txt_ExportImagecDictionary.Size = new System.Drawing.Size(386, 21);
            this.Txt_ExportImagecDictionary.TabIndex = 1;
            // 
            // Txt_ResultImage
            // 
            this.Txt_ResultImage.Location = new System.Drawing.Point(106, 59);
            this.Txt_ResultImage.Name = "Txt_ResultImage";
            this.Txt_ResultImage.Size = new System.Drawing.Size(472, 21);
            this.Txt_ResultImage.TabIndex = 1;
            // 
            // Btn_XDFile
            // 
            this.Btn_XDFile.Location = new System.Drawing.Point(584, 4);
            this.Btn_XDFile.Name = "Btn_XDFile";
            this.Btn_XDFile.Size = new System.Drawing.Size(75, 23);
            this.Btn_XDFile.TabIndex = 2;
            this.Btn_XDFile.Text = "浏览";
            this.Btn_XDFile.UseVisualStyleBackColor = true;
            this.Btn_XDFile.Click += new System.EventHandler(this.Btn_XDFile_Click);
            // 
            // Btn_ExportImagecDictionary
            // 
            this.Btn_ExportImagecDictionary.Location = new System.Drawing.Point(584, 31);
            this.Btn_ExportImagecDictionary.Name = "Btn_ExportImagecDictionary";
            this.Btn_ExportImagecDictionary.Size = new System.Drawing.Size(75, 23);
            this.Btn_ExportImagecDictionary.TabIndex = 3;
            this.Btn_ExportImagecDictionary.Text = "浏览";
            this.Btn_ExportImagecDictionary.UseVisualStyleBackColor = true;
            this.Btn_ExportImagecDictionary.Click += new System.EventHandler(this.Btn_ExportImagecDictionary_Click);
            // 
            // Btn__ResultImage
            // 
            this.Btn__ResultImage.Location = new System.Drawing.Point(584, 59);
            this.Btn__ResultImage.Name = "Btn__ResultImage";
            this.Btn__ResultImage.Size = new System.Drawing.Size(75, 23);
            this.Btn__ResultImage.TabIndex = 4;
            this.Btn__ResultImage.Text = "浏览";
            this.Btn__ResultImage.UseVisualStyleBackColor = true;
            this.Btn__ResultImage.Click += new System.EventHandler(this.Btn__ResultImage_Click);
            // 
            // Btn_Build
            // 
            this.Btn_Build.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Build.Location = new System.Drawing.Point(584, 85);
            this.Btn_Build.Name = "Btn_Build";
            this.Btn_Build.Size = new System.Drawing.Size(75, 23);
            this.Btn_Build.TabIndex = 5;
            this.Btn_Build.Text = "生成";
            this.Btn_Build.UseVisualStyleBackColor = true;
            this.Btn_Build.Click += new System.EventHandler(this.Btn_Build_Click);
            // 
            // Dlg_XDFile
            // 
            this.Dlg_XDFile.Filter = "XD文件|*.xd";
            this.Dlg_XDFile.Title = "选择XD文件";
            // 
            // Dlg_ResultImage
            // 
            this.Dlg_ResultImage.Filter = "PNG|*.png|JPG|*.jpg";
            // 
            // Cmb_Extension
            // 
            this.Cmb_Extension.FormattingEnabled = true;
            this.Cmb_Extension.Items.AddRange(new object[] {
            ".png",
            ".jpg"});
            this.Cmb_Extension.Location = new System.Drawing.Point(503, 32);
            this.Cmb_Extension.Name = "Cmb_Extension";
            this.Cmb_Extension.Size = new System.Drawing.Size(75, 20);
            this.Cmb_Extension.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "背景颜色";
            // 
            // Pic_BackgroundColor
            // 
            this.Pic_BackgroundColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_BackgroundColor.Location = new System.Drawing.Point(106, 88);
            this.Pic_BackgroundColor.Name = "Pic_BackgroundColor";
            this.Pic_BackgroundColor.Size = new System.Drawing.Size(26, 17);
            this.Pic_BackgroundColor.TabIndex = 9;
            this.Pic_BackgroundColor.TabStop = false;
            this.Pic_BackgroundColor.Click += new System.EventHandler(this.Pic_BackgroundColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "画板标题";
            // 
            // Btn_Font
            // 
            this.Btn_Font.Location = new System.Drawing.Point(340, 85);
            this.Btn_Font.Name = "Btn_Font";
            this.Btn_Font.Size = new System.Drawing.Size(75, 23);
            this.Btn_Font.TabIndex = 10;
            this.Btn_Font.Text = "格式";
            this.Btn_Font.UseVisualStyleBackColor = true;
            this.Btn_Font.Click += new System.EventHandler(this.Btn_Font_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 118);
            this.Controls.Add(this.Btn_Font);
            this.Controls.Add(this.Pic_BackgroundColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_Extension);
            this.Controls.Add(this.Btn_Build);
            this.Controls.Add(this.Btn__ResultImage);
            this.Controls.Add(this.Btn_ExportImagecDictionary);
            this.Controls.Add(this.Btn_XDFile);
            this.Controls.Add(this.Txt_ResultImage);
            this.Controls.Add(this.Txt_ExportImagecDictionary);
            this.Controls.Add(this.Txt_XDFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(689, 157);
            this.MinimumSize = new System.Drawing.Size(618, 157);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XD合并导出";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_BackgroundColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_XDFile;
        private System.Windows.Forms.TextBox Txt_ExportImagecDictionary;
        private System.Windows.Forms.TextBox Txt_ResultImage;
        private System.Windows.Forms.Button Btn_XDFile;
        private System.Windows.Forms.Button Btn_ExportImagecDictionary;
        private System.Windows.Forms.Button Btn__ResultImage;
        private System.Windows.Forms.Button Btn_Build;
        private System.Windows.Forms.FolderBrowserDialog Dlg_ExportImagecDictionary;
        private System.Windows.Forms.OpenFileDialog Dlg_XDFile;
        private System.Windows.Forms.SaveFileDialog Dlg_ResultImage;
        private System.Windows.Forms.ComboBox Cmb_Extension;
        private System.Windows.Forms.ColorDialog Dlg_Color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pic_BackgroundColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FontDialog Dlg_Font;
        private System.Windows.Forms.Button Btn_Font;
    }
}

