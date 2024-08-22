using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/progh2/WinFormAdv31/commits/master/");
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(toolStripProgressBar1.Maximum < toolStripProgressBar1.Value + toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value += toolStripProgressBar1.Minimum;
            }
            else
            {
                toolStripProgressBar1.Value += toolStripProgressBar1.Step;
            }
            
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value -= 10;
        }

        private void 확대하기축소하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }
    }
}
