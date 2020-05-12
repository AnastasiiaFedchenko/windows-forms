using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика15._4
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int AmountOfWrongAnswear = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int test = int.Parse(textBox1.Text);
            label2.Left+=3;
            if (test == rnd.Next(10))
            {
                label2.Text = "Угадал!";
            }
            else
            {
                label2.Text = "Не угадал!";
                AmountOfWrongAnswear++;
            }
            if(label2.Left == 90)
            {

                MessageBox.Show("Коэффициент Вашей невезучасти = " + (AmountOfWrongAnswear / 10.0)*100 + "%");
                this.Close();
            }
        }
    }
}
