using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollText
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
        private void TelopTimer_Tick(object sender, EventArgs e)
        {
            Mainlabel.Left += -2;//テロップ速度
            if (Mainlabel.Right < 0)  Mainlabel.Left = this.ClientSize.Width - Mainlabel.Right;//一番左に行ったら右へlabelを戻す
        }
    }
}
