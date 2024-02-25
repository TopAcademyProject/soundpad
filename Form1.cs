using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundPad_Project
{
    public partial class Form1 : Form
    {
        private Size formOriginalSize;
        private Rectangle recMP;
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize;
            formOriginalSize = this.Size;
            recMP = new Rectangle(Test_Sound.Location, Test_Sound.Size);
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            Resize_Control(Test_Sound, recMP);
        }
        private void Resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);

        }
        private void Select_video_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                Test_Sound.URL = opf.FileName;
            }
        }

        private void Sound_List_Click(object sender, EventArgs e)
        {
            if (Test_Sound.Visible == false)
            {
                Test_Sound.Visible = true;
                Select_video.Visible = true;
            }
            else
            {
                Test_Sound.Visible = false;
                Select_video.Visible = false;
            }

        }
    }
}
