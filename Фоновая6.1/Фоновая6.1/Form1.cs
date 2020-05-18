using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фоновая6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (A.Left + 8 + A.Width > B.Left - 8)
            {
                A.Left += ((B.Left - (A.Left + A.Width)) / 2);
                B.Left -= ((B.Left - (A.Left + A.Width)) / 2);
            }
            else
            {
                A.Left += 8;
                B.Left -= 8;
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if(A.Left > 8)
            {
                A.Left -= 8;
            }
            else
            {
                A.Left = 0;
            }
            if(this.Width - B.Width - B.Left > 24)
            {
                B.Left += 8;
            }
            else
            {
                B.Left = this.Width - B.Width-16;
            }
        }
    }
}
