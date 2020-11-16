using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace littlehua
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        Point point = new Point();
        bool userexit = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!userexit)
            {
                MessageBox.Show("关掉的话我就当作是喜欢了！");
                e.Cancel = true;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int panelwidth;
            int panelhight;
            
            panelwidth = panel1.Width;
            panelhight = panel1.Height;

            point.X = rd.Next(0, panelwidth - button2.Width);
            point.Y = rd.Next(0, panelhight - button2.Height);

            button2.Location = point;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button3.Visible = true;
            label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userexit = true;
            Application.Exit();
        }
    }
}
