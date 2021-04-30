using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpUygulama9a
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac%2==1)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Blue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 100;
            if (timer1.Interval==100)
            {
                button1.Enabled = false;
            }
        }
    }
}
