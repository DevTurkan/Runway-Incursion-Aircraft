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
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
        }
        int  pb2 = 0, pb3 = 0, pb7=0, xpb2 = 130, ypb2 = 214, xpb3 = -62, ypb3 = 110, xpb4 = 0, ypb4 = 179, xpb7 = 515, ypb7 = 214, xpb8 = 680, ypb8 = 179, xpb9 = 652, ypb9 = 110, xpb10 = 465, ypb10 = 133, xpb11 = 427, ypb11 = 214, xpb102 = 378, ypb102 = 237;


        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            if (f3.button3.Visible == false)
            {
                f3.button3.Visible = true;
                f3.button2.Visible = false;
                f3.pictureBox13.Visible = true;
                f3.pictureBox2.Visible = false;              
                f3.pictureBox7.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
            if (f3.button2.Visible == false)
            {
                f3.button2.Visible = true;
                f3.button3.Visible = false;
                f3.pictureBox2.Visible = true;             
                f3.pictureBox7.Visible = false;
                f3.pictureBox12.Visible = true;
            }
        }

        public double Xcoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Cos(50.06416667 * 3.14 / 180);
        public double Ycoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Sin(50.06416667 * 3.14 / 180);



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
        #region Formun_Hereketi_3
        Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        #endregion

        #region Koordinat_17_35
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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

            label5.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = "Coğrafi uzunluq : " + Math.Round(coord2, 0).ToString() + "°" + Math.Round(minutes2, 0).ToString() + "''" + Math.Round(seconds2, 0).ToString() + "'";
            label3.Text = "Coğrafi enlik : " + Math.Round(coord, 0).ToString() + "°" + Math.Round(minutes, 0).ToString() + "''" + Math.Round(seconds, 0).ToString() + "'";

        }
        #endregion

        #region toqqusma_17_35
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb2 = pb2 + 10;

            if (pb2 >= 50 && xpb2 > 21)
            {
                xpb2 = xpb2 - 1;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
            if (pb2 >= 50 && xpb2 <= 21 && ypb2>=110)
            {
                xpb2 = xpb4;
                ypb2 = ypb4;
                pictureBox2.Visible = false;
                pictureBox4.Visible = true;
                ypb4 = ypb4 - 1;
                pictureBox4.Location = new Point(xpb4, ypb4);
            }
            if (pb2 >= 50 && xpb4 >= 0 && ypb4<=110)
            {
                pictureBox2.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                xpb4 = xpb4 + 2;
                pictureBox5.Location = new Point(xpb4, ypb4);
            }

            if (pb2 >= 50 && xpb4 >= 130)
            {
                xpb3 = xpb3 + 6;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }

            if (pb2 >= 50 && xpb3 == 154)
            {
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
                timer1.Enabled = false;

            }
        }
        #endregion

        #region Qarsisinin_alinmasi_17_35
        private void timer2_Tick(object sender, EventArgs e)
        {
            pb7 = pb7 + 10;

            if (pb7 >= 50 && xpb7 < 640)
            {
                xpb7 = xpb7 + 1;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb7 >= 50 && xpb7 >= 640 && ypb7 >= 110)
            {
                xpb7 = xpb8;
                ypb7 = ypb8;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                ypb8 = ypb8 - 1;
                pictureBox8.Location = new Point(xpb8, ypb8);
            }
            if (pb7 >= 50 && xpb8 <= 680 && ypb8 <= 110)
            {
                xpb8 = xpb9;
                ypb8 = ypb9;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                xpb9 = xpb9 - 1;
                pictureBox9.Location = new Point(xpb9, ypb9);
            }

            if (pb7 >= 50 && xpb9 == 598)
            {
                timer2.Enabled = false;
            }
           

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          

            if (pb7 >= 50 && xpb9 <= 651 && ypb9 <= 110 && xpb3 <= 124 && ypb3 <= 110)
            {
                xpb3 = xpb3 + 6;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
         
            if (pb7 >= 50 && xpb3 >= 124 && xpb3 <= 352 && ypb3 <= 110 && ypb9 <= 110)
            {
                xpb3 = xpb3 + 5;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb7 >= 50 && xpb3 >= 352 && xpb3 <= 424 && ypb3 <= 110 && ypb9 <= 110)
            {
                xpb3 = xpb3 + 3;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }

            if (pb7 >= 50 && xpb3 >= 424 && ypb3 >= 110 && ypb9 <= 110)
            {
                xpb3 = xpb10;
                ypb3 = ypb10;
                pictureBox3.Visible = false;
                pictureBox10.Visible = true;
                ypb10 = ypb10 + 1;
                pictureBox10.Location = new Point(xpb10, ypb10);

                xpb9 = xpb9 - 1;
                pictureBox9.Location = new Point(xpb9, ypb9);

            }
            if (pb7 >= 50 && xpb10 <= 465 && ypb10 >= 171 && ypb9 <= 110)
            {
                xpb10 = xpb11;
                ypb10 = ypb11;
                pictureBox3.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                xpb11 = xpb11 - 1;
                pictureBox11.Location = new Point(xpb11, ypb11);

                xpb9 = xpb9 - 1;
                pictureBox9.Location = new Point(xpb9, ypb9);
            }

            if (pb7 >= 50 && xpb11 <= 391 && ypb11 >= 214 && ypb9 <= 110)
            {
                xpb11 = xpb102;
                ypb11 = ypb102;
                pictureBox3.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                ypb102 = ypb102 + 1;
                pictureBox10.Location = new Point(xpb102, ypb102);

                xpb9 = xpb9 - 2;
                pictureBox9.Location = new Point(xpb9, ypb9);
            }
            if (pb7 >= 50 && xpb9 <= 340 && ypb9 <= 110 && ypb11 >= 214)
            {
                xpb9 = xpb9 - 4;
                pictureBox9.Location = new Point(xpb9, ypb9);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 50, 50));
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(130, 119, 109, 210);
        }

    }
}
