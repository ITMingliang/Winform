using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listSongs = new List<string>();
        SoundPlayer sp;
        private void btSelectMp3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Users\mingliang\Desktop\TEST\Mp3";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.mp3|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径
            string[] mp3Path = ofd.FileNames;

            for (int i = 0; i < mp3Path.Length; i++)
            {
                //将音乐文件名加载到listBox中
                listBox1.Items.Add(Path.GetFileName(mp3Path[i]));
                listSongs.Add(mp3Path[i]);
            }

        }

        /// <summary>
        /// 双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sp = new SoundPlayer();
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
        }
        private void btup_Click(object sender, EventArgs e)
        {
            //获取当前音乐的索引
            int index = listBox1.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = listBox1.Items.Count;
            }
            //将改变后的索引重新赋值给当前选中的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }

        private void btdown_Click(object sender, EventArgs e)
        {
            //获取当前音乐的索引
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新赋值给当前选中的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }

        private void btPlayMusic_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\mingliang\Desktop\TEST\Mp3\G.E.M.邓紫棋 - 龙卷风.mp3");
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }

        private void btSurf_Click(object sender, EventArgs e)
        {
            //通过进程打开应用程序

            //打开笔记本
            //Process.Start("notepad");
            //打开百度
            Process.Start("iexplore", "http://www.baidu.com");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
