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
    public partial class Form4 : Form
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
        public Form4()
        {
            InitializeComponent();
        }
        int pb1 = 0, pb2 = 0, pb3 = 0, pb31 = 0, pb7=0, pb20=0, pb18=0, xpb1 = 6, ypb1 = 217, xpb2 = -450, ypb2 = 103, xpb24 = 253, ypb24 = 304, xpb23 = 310, ypb23 = 265, xpb22 = 344, ypb22 = 126, xpb3 = 725, ypb3 = 103, xpb31 = 656, ypb31 = 103, xpb33 = 552, ypb33 = 184, xpb34 = 344, ypb34 = 276, xpb7 = 7, ypb7 = 366, xpb71 = 303,xpb20=8, ypb20=490, xpb18=7, ypb18=264, ypb71 = 265, xpb72 = 6, ypb72 = 330, xpb73 = 26, ypb73 = 107;


        #region Combobox1den_secim

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox20.Visible = false;
                pictureBox2.Visible = true;
                
                if (comboBox2.Items.Count > 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Text="";
                    comboBox2.Items.Add("Boeing 767-300");
                }
                else if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Items.Add("Boeing 767-300");                
                }

            }

            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox20.Visible = false;
                pictureBox3.Visible = true;
                if (comboBox2.Items.Count > 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("Airbus A319");
                }
                else if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Items.Add("Airbus A319");
                }

            }
        }
        #endregion
        private void button4_Click(object sender, EventArgs e)
        {

        }


        #region Yenile
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void Form4_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 50, 50));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 10, 10));
            comboBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox2.Width, comboBox2.Height, 10, 10));
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }


        #region Formun_Hereketi_4
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

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        #region Combobox2den_secim
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox2.SelectedItem.ToString()== "Boeing 767-300")
            {
                button2.Visible = true;
                pictureBox20.Visible = true;
                radioButton3.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
               
            }

          

            if (comboBox2.SelectedItem.ToString() == "Airbus A319")
            {
                button2.Visible = true;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton2.Enabled = true;
                pictureBox1.Visible = true;
             
            }
        }
        #endregion

        #region teyyare2_4Prosesi_2_3
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb1 = pb1 + 10;                                     

            if (pb1 >= 50 && ypb1 >= 163)
            {
                ypb1 = ypb1 - 1;
                pictureBox1.Location = new Point(xpb1, ypb1);
            }

            if (pb1 >= 50 && ypb1 <= 163 && ypb1>102 )
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

              
                radioButton3.Enabled = true;
                if (radioButton3.Checked == true)
                {

                    timer1.Enabled = false;
                   
                } 
               
                if (timer1.Enabled == false)
                {
                    radioButton1.Enabled = true;
                }
                


            }
            if (pb1 >= 50 && xpb1 >= 20)
            {
                radioButton2.Enabled = false;
            }
            if (pb1 >= 50 && xpb1 >= 65)
            {
                radioButton3.Enabled = false;
            }

        }

      


        private void timer2_Tick(object sender, EventArgs e) //J yolu
        {
            if (pb1 >= 50 && ypb1 <= 163 && xpb3 > 342)
            {
                xpb3 = xpb3 - 2;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb3 <= 342 && ypb3 > 102)
            {
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
                ypb3 = ypb3 + 1;
                pictureBox6.Location = new Point(xpb3, ypb3);
                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
               
                radioButton3.Enabled = false;
                radioButton1.Enabled = false;
                button3.Enabled = false;
            }
            if (pb1 >= 50 && xpb1 >= 62 && xpb1 <= 272 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 3;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && xpb1 >= 272 && xpb1 <= 468 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 4;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }

            if (pb1 >= 50 && xpb1 >= 468 && xpb3 <= 342 && ypb3 >= 141)
            {
                xpb1 = xpb1 + 6;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }

        }

        private void timer3_Tick(object sender, EventArgs e) //TOQQUSMA
        {

            if (pb1 >= 50 && ypb1 <= 163 && xpb3 > 342)
            {
                xpb3 = xpb3 - 2;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb3 <= 342)
            {
                xpb3 = xpb3 - 2;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb1 >= 50 && xpb1 >= 62 && xpb1 <= 272 && xpb3 <= 342)
            {
                xpb1 = xpb1 + 3;
                pictureBox4.Location = new Point(xpb1, ypb1);
            } 
            if (pb1 >= 50 && xpb1 == 233)
            {
                timer1.Enabled = false;
                timer3.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                button3.Enabled = false;

                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
         
        }

        private void timer4_Tick(object sender, EventArgs e) //L yolu
        {

            if (pb1 >= 50 && ypb1 <= 163 && xpb3 > 594)
            {
                xpb3 = xpb3 - 2;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb3 <= 594 && ypb3 >= 102 && ypb3 < 150)
            {
                pictureBox3.Visible = false;
                pictureBox6.Visible = true;
                ypb3 = ypb3 + 1;

                pictureBox6.Location = new Point(xpb3, ypb3);

                radioButton2.Enabled = false;
                button3.Enabled = false;
            }
            

            if (pb1 >= 50 && ypb1 <= 163 && xpb3 <= 594 && xpb3 >= 530 && ypb3 >= 150)
            {
                xpb3 = xpb33;
                ypb3 = ypb33;
                pictureBox9.Visible = true;
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);

            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 530 && ypb33 >= 184 && ypb33 <= 187)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 530 && xpb33 >= 517 && ypb33 >= 187)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }

            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 517 && ypb33 >= 187 && ypb33 <= 191)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 517 && xpb33 >= 509 && ypb33 >= 191)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }


            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 509 && ypb33 >= 191 && ypb33 <= 196)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 509 && xpb33 >= 498 && ypb33 >= 196)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 498 && ypb33 >= 196 && ypb33 <= 199)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 498 && xpb33 >= 488 && ypb33 >= 199)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 488 && ypb33 >= 199 && ypb33 <= 204)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }


            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 488 && xpb33 >= 477 && ypb33 >= 204)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 477 && ypb33 >= 204 && ypb33 <= 207)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 477 && xpb33 >= 464 && ypb33 >= 207)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }

            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 464 && ypb33 >= 207 && ypb33 <= 212)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 464 && xpb33 >= 450 && ypb33 >= 212)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 450 && ypb33 >= 212 && ypb33 <= 215)
            {
                pictureBox9.Visible = true;//+++
                pictureBox6.Visible = false;
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 450 && xpb33 >= 436 && ypb33 >= 215)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 436 && ypb33 >= 215 && ypb33 <= 220)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 436 && xpb33 >= 423 && ypb33 >= 220)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 423 && ypb33 >= 220 && ypb33 <= 225)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 423 && xpb33 >= 410 && ypb33 >= 225)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 410 && ypb33 >= 225 && ypb33 <= 229)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 410 && xpb33 >= 400 && ypb33 >= 229)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 400 && ypb33 >= 229 && ypb33 <= 233)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 400 && xpb33 >= 390 && ypb33 >= 233)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 390 && ypb33 >= 233 && ypb33 <= 236)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 390 && xpb33 >= 377 && ypb33 >= 236)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 377 && ypb33 >= 236 && ypb33 <= 242)
            {
                ypb33 = ypb33 + 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 377 && xpb33 >= 362 && ypb33 >= 242)
            {
                xpb33 = xpb33 - 1;
                pictureBox9.Location = new Point(xpb33, ypb33);
            }
            if (pb1 >= 50 && ypb1 <= 163 && xpb33 <= 362 && ypb33 >= 242)
            {
                xpb33 = xpb34;
                ypb33 = ypb34;
                pictureBox19.Visible = true;
                pictureBox9.Visible = false;
                ypb34 = ypb34 + 1;
                pictureBox19.Location = new Point(xpb34, ypb34);
            }
            if (pb1 >= 50 && xpb1 >= 62 && xpb1 <= 272)
            {
                xpb1 = xpb1 + 3;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }
            if (pb1 >= 50 && xpb1 >= 272 && xpb1 <= 468)
            {
                xpb1 = xpb1 + 4;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }

            if (pb1 >= 50 && xpb1 >= 468)
            {
                xpb1 = xpb1 + 6;
                pictureBox4.Location = new Point(xpb1, ypb1);
            }

        

        }
        #endregion

        #region teyyare1_2Prosesi_1_4
        private void timer5_Tick(object sender, EventArgs e)//toqqusma
        {
            if (pb20 >= 50 && ypb7 <= 244 && xpb2 <= 105)//asagi
            {
                xpb2 = xpb2 + 5;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
            if (pb20 >= 50 && xpb2 > 105 && xpb2 <= 253)
            {
                xpb2 = xpb2 + 3;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
            if (pb20 >= 50 && xpb2 > 253 && xpb2 < 317)
            {
                xpb2 = xpb2 + 2;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
      

            if (pb20 >= 50 && xpb73 == 111)
            {
                timer5.Enabled = false;
                timer13.Enabled = false;
                pictureBox2.Visible = false;
                pictureBox13.Visible = false;
                pictureBox7.Visible = false;
                pictureBox11.Visible = false;
                pictureBox20.Visible = false;
                pictureBox15.Visible = true;

                button3.Enabled = false;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;

            }
        
        }
        private void timer6_Tick(object sender, EventArgs e)//J yolu
        {
            if (pb20 >= 50 && ypb7 <= 244 && xpb2 <= 105)//asagi
            {
                xpb2 = xpb2 + 5;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
            if (pb20 >= 50 && xpb2 > 105 && xpb2 <= 253)
            {
                xpb2 = xpb2 + 3;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
            if (pb20 >= 50 && xpb2 > 253 && xpb2 < 317)
            {
                xpb2 = xpb2 + 2;
                pictureBox2.Location = new Point(xpb2, ypb2);
            }
              if (pb20 >= 50 && xpb2 >= 317 && ypb2 >= 102)//asagi
              {
                  xpb2 = xpb22;
                  ypb2 = ypb22;
                  pictureBox2.Visible = false;
                  pictureBox13.Visible = true;
                  ypb22 = ypb22 + 1;
                  pictureBox13.Location = new Point(xpb22, ypb22);

                if (timer13.Enabled == false)
                {
                    timer13.Enabled = true;
                }

                radioButton3.Enabled = false;
                radioButton1.Enabled = false;
                button3.Enabled = false;
            }
        }
        private void timer13_Tick(object sender, EventArgs e)
        {
            pb20 = pb20 + 10;
            if (pb20 >= 50 && ypb20 <= 490 && ypb20>=406)//asagi
            {
                ypb20 = ypb20 - 2;
                pictureBox20.Location = new Point(xpb20, ypb20);
            }
            if (pb20 >= 50 && ypb20 <= 406 && ypb20 >= 126)//asagi
            {
                xpb20 = xpb7;
                ypb20 = ypb7;
                pictureBox20.Visible = false;
                pictureBox7.Visible = true;
                ypb7 = ypb7 - 2;
                pictureBox7.Location = new Point(xpb7, ypb7);

                radioButton3.Enabled = true;
                if (radioButton3.Checked == true)
                {

                    timer13.Enabled = false;

                }
                if (timer13.Enabled == false)
                {
                    radioButton1.Enabled = true;
                }

            }

            if (pb20 >= 50 && ypb7 <= 126)//asagi
            {
                xpb7 = xpb73;
                ypb7 = ypb73;
                pictureBox11.Visible = true;
                pictureBox20.Visible = false;
                pictureBox7.Visible = false;
                xpb73 = xpb73 + 2;
                pictureBox11.Location = new Point(xpb73, ypb73);

                radioButton3.Enabled = false;                            

            }

            if (pb20 >= 50 && xpb73 >= 108 && xpb73 <= 270)      
            {
                xpb73 = xpb73 + 3;
                pictureBox11.Location = new Point(xpb73, ypb73);
            }
            if (pb20 >= 50 && xpb73 >= 270 && xpb73 <= 470)
            {
                xpb73 = xpb73 + 4;
                pictureBox11.Location = new Point(xpb73, ypb73);
            }

            if (pb20 >= 50 && xpb73 >= 470)
            {
                xpb73 = xpb73 + 6;
                pictureBox11.Location = new Point(xpb73, ypb73);
            }



        }

        #endregion

        #region teyyare2_3Prosesi_sil 
        private void timer7_Tick(object sender, EventArgs e)
        {
   
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
    
        }
        #endregion  

        #region teyyare3_4Prosesi_sil
        private void timer9_Tick(object sender, EventArgs e)
        {
      

        }
        private void timer10_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
           
          
        }
        private void timer12_Tick(object sender, EventArgs e)
        {
           
        }
        #endregion

        #region Baslat
        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            if (pictureBox1.Visible == true && pictureBox3.Visible == true)
            {
                timer1.Start();
                timer3.Start();
            }
            else if(pictureBox2.Visible == true && pictureBox20.Visible == true)
            {
                timer5.Start();
                timer13.Start();
            }
       

        }
        #endregion

        #region QarsisiniAl
        private void button3_Click(object sender, EventArgs e)
        {

            
                if (pb1 >= 50 && xpb3 <=725)
                {
                
                   
                    if (radioButton1.Checked == true)
                    {
                       timer3.Stop();
                       timer2.Start();
                     
                    
                    }
                   
                  else if (radioButton2.Checked == true)
                  {
                    timer3.Stop();
                    timer1.Start();
                    timer4.Start();
                  }
                  else if (radioButton1.Checked == false && radioButton2.Checked == false)
                  {
                    timer3.Start();
                    timer1.Start();
                  }
                }
            if (pb20 >= 50 && xpb2 >= -440)
            {
                
                if (radioButton1.Checked == true)
                {
                    timer6.Start();
                    timer5.Stop();
                }
                else if (radioButton3.Checked == false && radioButton1.Checked == false)
                {
                    timer13.Start();
                    timer5.Start();
                }
            }

      


        }
        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(130, 119, 109, 210);
        }
    }
}
