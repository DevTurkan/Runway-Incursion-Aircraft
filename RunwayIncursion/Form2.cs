using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunwayIncursion
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
       int nLeft,
       int nTop,
       int nRight,
       int Bottom,
       int nWidthEllipse,
       int nHeightEllipse
       );
        public Form2()
        {
            InitializeComponent();
        }

        int pb1 = 0, pb2 = 0, pb3 = 0, xpb1 = 6, ypb1 = 217, xpb2 = -60, ypb2 = 103, xpb3 = 656, ypb3 = 103;

        public double Xcoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Cos(50.06416667 * 3.14 / 180);
        public double Ycoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Sin(50.06416667 * 3.14 / 180);

        private void Form2_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 50, 50));

        }

        #region Ana_sehife

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            if (f2.button3.Visible == false)
            {
                f2.button3.Visible = true;
                f2.button4.Visible = false;
                f2.pictureBox7.Visible = true;
            }

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            if (f2.button4.Visible == false)
            {
                f2.button4.Visible = true;
                f2.button3.Visible = false;
                f2.pictureBox8.Visible = true;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            

        }
        #endregion

        #region Formun_Hereketi_2
        Point lastPoint;

      

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

      
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

     

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Koordinat_16_34
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            double y = Convert.ToDouble(e.Location.Y) + Ycoor - 767 + panel2.Width / 2;
            double x = Convert.ToDouble(e.Location.X) + Xcoor + panel2.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            label3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Coğrafi uzunluq : " + Math.Round(coord2, 0).ToString() + "°" + Math.Round(minutes2, 0).ToString() + "'" + Math.Round(seconds2, 0).ToString() + "''";
            label1.Text = "Coğrafi enlik : " + Math.Round(coord, 0).ToString() + "°" + Math.Round(minutes, 0).ToString() + "'" + Math.Round(seconds, 0).ToString() + "''";

        }
        #endregion

        #region Toqqusma_16_34
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1 = pb1 + 10;
            if (pb1 >= 50 && ypb1 > 102)
            {
                ypb1 = ypb1 - 1;
                pictureBox1.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && ypb1 <= 102)
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
                xpb1 = xpb1 + 1;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && xpb1 >= 144)
            {
                xpb2 = xpb2 + 6;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }

            if (pb1 >= 50 && xpb2 == 138)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                timer1.Enabled = false;

            }
        }
        #endregion

        #region Qarsisinin_alinmasi_16_34
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pb1 = pb1 + 2;

            if (pb1 >= 50 && ypb1 > 102)
            {
                ypb1 = ypb1 - 1;
                pictureBox1.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && ypb1 <= 102)
            {
                pictureBox1.Visible = false;
                pictureBox4.Visible = true;
                xpb1 = xpb1 + 1;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && xpb1 == 62)
            {
                timer2.Enabled = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pb3 = pb3 + 10;
            if (pb3 >= 50 && xpb3 > 342)
            {
                xpb3 = xpb3 - 1;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }


            if (pb3 >= 50 && xpb3 <= 342 && ypb3 >= 102)
            {
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
                ypb3 = ypb3 + 1;
                pictureBox6.Location = new Point(xpb3, ypb3);
            }

            if (pb1 >= 50 && xpb1 >= 62 && xpb1 <= 282 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 2;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && xpb1 >= 282 && xpb1 <= 470 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 4;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }

            if (pb1 >= 50 && xpb1 >= 470 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 6;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
        }
        #endregion

        private void button3_Click(object sender, EventArgs e)
        {
           
                timer1.Start(); // toqqusma
          
        }
        private void button4_Click(object sender, EventArgs e)
        {

            timer2.Start();
            timer3.Start();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(130,119,109,210);

        }

    }
}
