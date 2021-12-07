
namespace MusicPlayer
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
            this.btSelectMp3 = new System.Windows.Forms.Button();
            this.btup = new System.Windows.Forms.Button();
            this.btdown = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btPlayMusic = new System.Windows.Forms.Button();
            this.btSurf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSelectMp3
            // 
            this.btSelectMp3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSelectMp3.Location = new System.Drawing.Point(23, 30);
            this.btSelectMp3.Name = "btSelectMp3";
            this.btSelectMp3.Size = new System.Drawing.Size(75, 23);
            this.btSelectMp3.TabIndex = 0;
            this.btSelectMp3.Text = "选择音乐";
            this.btSelectMp3.UseVisualStyleBackColor = true;
            this.btSelectMp3.Click += new System.EventHandler(this.btSelectMp3_Click);
            // 
            // btup
            // 
            this.btup.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btup.Location = new System.Drawing.Point(291, 103);
            this.btup.Name = "btup";
            this.btup.Size = new System.Drawing.Size(75, 23);
            this.btup.TabIndex = 1;
            this.btup.Text = "上一曲";
            this.btup.UseVisualStyleBackColor = true;
            this.btup.Click += new System.EventHandler(this.btup_Click);
            // 
            // btdown
            // 
            this.btdown.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btdown.Location = new System.Drawing.Point(291, 199);
            this.btdown.Name = "btdown";
            this.btdown.Size = new System.Drawing.Size(75, 23);
            this.btdown.TabIndex = 2;
            this.btdown.Text = "下一曲";
            this.btdown.UseVisualStyleBackColor = true;
            this.btdown.Click += new System.EventHandler(this.btdown_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(23, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 256);
            this.listBox1.TabIndex = 3;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btPlayMusic
            // 
            this.btPlayMusic.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPlayMusic.Location = new System.Drawing.Point(562, 29);
            this.btPlayMusic.Name = "btPlayMusic";
            this.btPlayMusic.Size = new System.Drawing.Size(75, 23);
            this.btPlayMusic.TabIndex = 4;
            this.btPlayMusic.Text = "播放音乐";
            this.btPlayMusic.UseVisualStyleBackColor = true;
            this.btPlayMusic.Click += new System.EventHandler(this.btPlayMusic_Click);
            // 
            // btSurf
            // 
            this.btSurf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSurf.Location = new System.Drawing.Point(562, 103);
            this.btSurf.Name = "btSurf";
            this.btSurf.Size = new System.Drawing.Size(75, 23);
            this.btSurf.TabIndex = 5;
            this.btSurf.Text = "打开百度";
            this.btSurf.UseVisualStyleBackColor = true;
            this.btSurf.Click += new System.EventHandler(this.btSurf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSurf);
            this.Controls.Add(this.btPlayMusic);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btdown);
            this.Controls.Add(this.btup);
            this.Controls.Add(this.btSelectMp3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSelectMp3;
        private System.Windows.Forms.Button btup;
        private System.Windows.Forms.Button btdown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btPlayMusic;
        private System.Windows.Forms.Button btSurf;
    }
}

