using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GpUygulama9
{
    public partial class Form1 : Form
    {
        int Arac1x = 0;
        int Arac2x = 0;
        int Arac3x = 0;
        int Arac4x = 0;
        int a = 30;
        int b = 30;
        int c = 30;
        int d = 30;
        int sira1 = 0;
        int sira2 = 0;
        int sira3 = 0;
        int sira4 = 0;
        int siraSayac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 1023;
            this.Height = 465;
            
            btnArac1.Location = new Point(0, 0);
            btnArac2.Location = new Point(0, 0);
            btnArac3.Location = new Point(0, 0);
            btnArac4.Location = new Point(0, 0);
            siraSayac = 0;

            btnArac1.Text = "";
            btnArac2.Text = "";
            btnArac3.Text = "";
            btnArac4.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            int HareketKirmizi = random.Next(0, a);
            Arac1x = btnArac1.Location.X + HareketKirmizi;
            btnArac1.Location = new Point(Arac1x, 115);

            int HareketMavi = random.Next(0, b);
            Arac2x = btnArac2.Location.X + HareketMavi;
            btnArac2.Location = new Point(Arac2x, 169);

            int HareketSari = random.Next(0, c);
            Arac3x = btnArac3.Location.X + HareketSari;
            btnArac3.Location = new Point(Arac3x, 255);

            int HareketYesil = random.Next(0, d);
            Arac4x = btnArac4.Location.X + HareketYesil;
            btnArac4.Location = new Point(Arac4x, 309);


            if (Arac1x > this.Width - 150)
            {
                a = 0;
                btnArac1.Location = new Point(this.Width - 150, 115);
                btnArac1.BackColor = Color.Green;
                if (sira1 == 0)
                {
                    siraSayac++;
                    btnArac1.Text = siraSayac.ToString();
                    sira1 = 1;
                }
            }
            

            if (Arac2x > this.Width - 150)
            {
                b = 0;
                btnArac2.Location = new Point(this.Width - 150, 169);
                btnArac2.BackColor = Color.Green;
                if (sira2 == 0)
                {
                    siraSayac++;
                    btnArac2.Text = siraSayac.ToString();
                    sira2 = 1;
                }
            }
            if (Arac3x > this.Width - 150)
            {
                c = 0;
                btnArac3.Location = new Point(this.Width - 150, 255);
                btnArac3.BackColor = Color.Green;
                if (sira3 == 0)
                {
                    siraSayac++;
                    btnArac3.Text = siraSayac.ToString();
                    sira3 = 1;
                }
            }
            if (Arac4x > this.Width - 150)
            {
                d = 0;
                btnArac4.Location = new Point(this.Width - 150, 309);
                btnArac4.BackColor = Color.Green;
                if (sira4 == 0)
                {
                    siraSayac++;
                    btnArac4.Text = siraSayac.ToString();
                    sira4 = 1;
                }
            }





            if (Arac1x > Arac2x && Arac1x > Arac3x && Arac1x > Arac4x)
            {
                btnArac1.BackColor = Color.Yellow;
                
            }
            else
            {

                if (Arac1x == (this.Width - 150))
                {
                    btnArac1.BackColor = Color.Green;
                }
                else
                {
                    btnArac1.BackColor = Color.White;
                    
                }
               
            }

            if (Arac2x > Arac1x && Arac2x > Arac3x && Arac2x > Arac4x)
            {
                btnArac2.BackColor = Color.Yellow;
                
            }
            else
            {

                if (Arac2x == (this.Width - 150))
                {
                    btnArac2.BackColor = Color.Green;
                }
                else
                {
                    btnArac2.BackColor = Color.White;
                    
                }
                
            }

            if (Arac3x > Arac1x && Arac3x > Arac2x && Arac3x > Arac4x)
            {
                btnArac3.BackColor = Color.Yellow;
                
            }
            else
            {

                if (Arac3x == (this.Width - 150))
                {
                    btnArac3.BackColor = Color.Green;
                }
                else
                {
                    btnArac3.BackColor = Color.White;
                    
                }
                
            }

            if (Arac4x > Arac1x && Arac4x > Arac2x && Arac4x > Arac3x)
            {
                btnArac4.BackColor = Color.Yellow;
                
            }
            else
            {
                btnArac4.BackColor = Color.White;
                if (Arac4x == (this.Width - 150))
                {
                    btnArac4.BackColor = Color.Green;
                }
                else
                {
                    btnArac4.BackColor = Color.White;
                   
                }
               
            }



        //    int[] enOndeki = new int[4];
        //    enOndeki[0] = btnArac1.Location.X;
        //    enOndeki[1] = btnArac2.Location.X;
        //    enOndeki[2] = btnArac3.Location.X;
        //    enOndeki[3] = btnArac4.Location.X;




        //    int birinci = enOndeki[0];
        //    for (int i = 0; i < enOndeki.Length; i++)
        //    {
        //        if (birinci < enOndeki[i])
        //        {
        //            birinci = enOndeki[i];
        //            if (birinci == btnArac1.Location.X)
        //            {
        //                btnArac1.Text = "1";
        //                btnArac2.Text = "";
        //                btnArac3.Text = "";
        //                btnArac4.Text = "";

        //            }
        //            if (birinci == btnArac2.Location.X)
        //            {
        //                btnArac2.Text = "1";
        //                btnArac1.Text = "";
        //                btnArac3.Text = "";
        //                btnArac4.Text = "";
        //            }
        //            if (birinci == btnArac3.Location.X)
        //            {
        //                btnArac3.Text = "1";
        //                btnArac2.Text = "";
        //                btnArac1.Text = "";
        //                btnArac4.Text = "";
        //            }
        //            if (birinci == btnArac4.Location.X)
        //            {
        //                btnArac4.Text = "1";
        //                btnArac2.Text = "";
        //                btnArac3.Text = "";
        //                btnArac1.Text = "";
        //            }
        //        }
        //    }

        }

        private void button1_Click(object sender, EventArgs e) //yarisi baslat butonu
        {
            timer1.Start();
            a = 30;
            b = 30;
            c = 30;
            d = 30;
        }

        private void numericHiz_ValueChanged(object sender, EventArgs e)
        {
            if (numericHiz.Value == 1)
            {
                timer1.Interval = 200;
            }
            else if (numericHiz.Value == 2)
            {
                timer1.Interval = 150;
            }
            else if (numericHiz.Value == 3)
            {
                timer1.Interval = 100;
            }
            else if (numericHiz.Value == 4)
            {
                timer1.Interval = 50;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            btnArac1.Location = new Point(0, 115);

            btnArac2.Location = new Point(0, 169);

            btnArac3.Location = new Point(0, 255);

            btnArac4.Location = new Point(0, 309);

            btnArac1.BackColor = Color.White;
            btnArac2.BackColor = Color.White;
            btnArac3.BackColor = Color.White;
            btnArac4.BackColor = Color.White;

            

            a = 30;
            b = 30;
            c = 30;
            d = 30;

            siraSayac = 0;

            btnArac1.Text = "";
            btnArac2.Text = "";
            btnArac3.Text = "";
            btnArac4.Text = "";

             sira1 = 0;
             sira2 = 0;
             sira3 = 0;
             sira4 = 0;

        }
    }
}
