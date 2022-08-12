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
    public partial class Form6 : Form
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
        public Form6()
        {
            InitializeComponent();
        }
        int  pb4=0, pb5 = 0, pb6 = 0, xpb4 = 510, ypb4 = 214, xpb5 = 130, ypb5 = 214, xpb6 = 724, ypb6 = 110, xpb7 = -60, ypb7 = 110,xpb10=14,ypb10=110, xpb16=460, ypb16=129,xpb17=424, ypb17=214,xpb18=372, ypb18=239, xpb9 = 0, ypb9 = 179, xpb12 = 233, ypb12 = 139, xpb13 = 218, ypb13 = 178, xpb14 = 232, ypb14 = 214,xpb19=371,ypb19=240, xpb8=683, ypb8=178, xpb3 = 651, ypb3 = 110;


        #region Formun_Hereketi_6
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
        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Combobox1den_secim
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                if (comboBox2.Items.Count > 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("Airbus A320");
                }
                else if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Items.Add("Airbus A320");
                }


            }

            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
                if (comboBox2.Items.Count > 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Text = "";
                    comboBox2.Items.Add("Boeing 767-300");
                }
                else if (comboBox2.Items.Count == 0)
                {
                    comboBox2.Items.Add("Boeing 767-300");
                }

            }

          
        }


        #endregion

        #region Combobox2den_secim
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
       

            if (comboBox2.SelectedItem.ToString() == "Airbus A320")
            {
                button2.Visible = true;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton2.Enabled = false;
                pictureBox6.Visible = true;
            }

            if (comboBox2.SelectedItem.ToString() == "Boeing 767-300")
            {
                button2.Visible = true;
                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                radioButton2.Enabled = false;
                pictureBox7.Visible = true;
            }
        }
        #endregion

        #region teyyare_3_4Prosesi
        private void timer1_Tick(object sender, EventArgs e)
        {
            pb5 = pb5 + 10;

            if (pb5 >= 50 && xpb5 > 21)
            {
                xpb5 = xpb5 - 1;
                pictureBox5.Location = new Point(xpb5, ypb5);
            }
            if (pb5 >= 50 && xpb5 <= 21 && ypb5 >= 134)
            {
                xpb5 = xpb9;
                ypb5 = ypb9;
                pictureBox5.Visible = false;
                pictureBox9.Visible = true;
                ypb9 = ypb9 - 1;
                pictureBox9.Location = new Point(xpb9, ypb9);

               
            }
            if (pb5 >= 50 && xpb9 >= 0 && xpb9<=174 && ypb9 <= 134)
            {
                xpb9 = xpb10;
                ypb9 = ypb10;
                pictureBox5.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                xpb10 = xpb10 + 2;
                pictureBox10.Location = new Point(xpb10, ypb10);

                radioButton3.Enabled = true;
                if (radioButton3.Checked == true)
                {

                    timer1.Enabled = false;

                }

                if (timer1.Enabled == false)
                {
                    radioButton2.Enabled = true;
                }
            }
            if (pb5 >= 50 && xpb10 >= 174 && xpb10 <= 298 && ypb10 <= 110)
            {
             
                xpb10 = xpb10 + 4;
                pictureBox10.Location = new Point(xpb10, ypb10);
            }
            if (pb5 >= 50 && xpb10 >= 298 && xpb10 <= 478 && ypb10 <= 110)
            {
        
                xpb10 = xpb10 + 5;
                pictureBox10.Location = new Point(xpb10, ypb10);
            }
            if (pb5 >= 50 && xpb10 >= 478 && ypb10 <= 110)
            {
                
                xpb10 = xpb10 + 6;
                pictureBox10.Location = new Point(xpb10, ypb10);
            }
          
        }
        private void timer2_Tick(object sender, EventArgs e) // toqqusma
        {
            if (pb5 >= 50 && xpb5 <= 21 && ypb5 >= 134)
            {
                xpb6 = xpb6 - 6;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb6>=340)
            {
                xpb6 = xpb6 - 4;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb6 <= 340)
            {
                xpb6 = xpb6 - 2;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }

            if (pb5 >= 50 && xpb10 == 172)
            {
                pictureBox10.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox9.Visible = false;
                pictureBox11.Visible = true;
                timer1.Enabled = false;
                timer2.Enabled = false;

                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void timer3_Tick(object sender, EventArgs e) // qarsisini al
        {
            if (pb5 >= 50 && xpb5 <= 21 && ypb5 >= 134)
            {
                xpb6 = xpb6 - 6;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb6 >= 340)
            {
                xpb6 = xpb6 - 4;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb6 <= 340 && xpb6>=268)
            {
                xpb6 = xpb6 - 2;
                pictureBox6.Location = new Point(xpb6, ypb6);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb6 <= 268)
            {
                xpb6 = xpb12;
                ypb6 = ypb12;
                pictureBox6.Visible = false;
                pictureBox12.Visible = true;
                ypb12 = ypb12 + 1;
                pictureBox12.Location = new Point(xpb12, ypb12);

                if (timer1.Enabled == false)
                {
                    timer1.Enabled = true;
                }
                if (timer1.Enabled == true)
                {
                    radioButton3.Enabled = false;
                }
                radioButton2.Enabled = false;
                button3.Enabled = false;
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && ypb12 > 143)
            {
                xpb12 = xpb13;
                ypb12 = ypb13;
                pictureBox6.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
                ypb13 = ypb13 + 1;
                pictureBox13.Location = new Point(xpb13, ypb13);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && ypb13 > 183)
            {
                xpb13 = xpb14;
                ypb13 = ypb14;
                pictureBox6.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                xpb14 = xpb14 + 2;
                pictureBox14.Location = new Point(xpb14, ypb14);
            }
            if (pb5 >= 50 && xpb9 >= 0 && ypb9 <= 134 && xpb14 >= 338)
            {
                xpb14 = xpb19;
                ypb14 = ypb19;
                pictureBox6.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox19.Visible = true;
                ypb19 = ypb19 + 2;
                pictureBox19.Location = new Point(xpb19, ypb19);
            }

        }

        #endregion

        #region teyyare_2_5Prosesi
        private void timer4_Tick(object sender, EventArgs e)
        {
            pb4 = pb4 + 10;
            if (pb4 >= 50 && xpb4 >= 510 && xpb4 <= 640)
            {
                xpb4 = xpb4 + 2;
                pictureBox4.Location = new Point(xpb4, ypb4);
            }
            if (pb4 >= 50 && xpb4 > 640 && ypb4>=135)
            {
                xpb4 = xpb8;
                ypb4 = ypb8;
                pictureBox4.Visible = false;
                pictureBox8.Visible = true;
                ypb8 = ypb8 - 1;
                pictureBox8.Location = new Point(xpb8, ypb8);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb8>=520)
            {
                xpb8 = xpb3;
                ypb8 = ypb3;
                pictureBox8.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
                xpb3 = xpb3 - 1;
                pictureBox3.Location = new Point(xpb3, ypb3);

                radioButton3.Enabled = true;
                if (radioButton3.Checked == true)
                {

                    timer4.Enabled = false;

                }

                if (timer4.Enabled == false)
                {
                    radioButton1.Enabled = true;
                }
            }
            if (pb4 >= 50 && xpb3 <= 520 && xpb3 >= 394)
            {

                pictureBox8.Visible = false;
                pictureBox3.Visible = true;
                xpb3 = xpb3 - 2;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb4 >= 50 && xpb3 <= 394 && xpb3 >= 182)
            {

                pictureBox8.Visible = false;
                pictureBox3.Visible = true;
                xpb3 = xpb3 - 4;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
            if (pb4 >= 50 && xpb3 <= 182)
            {

                pictureBox8.Visible = false;
                pictureBox3.Visible = true;
                xpb3 = xpb3 - 6;
                pictureBox3.Location = new Point(xpb3, ypb3);
            }
        }
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (pb4 >= 50 && xpb4 > 640 && ypb4 >= 135 )
            {
                xpb7 = xpb7 + 6;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb7<= 294)
            {
                xpb7 = xpb7 + 4;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb7 >= 294)
            {
                xpb7 = xpb7 + 2;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && xpb7 == 476)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox15.Visible = true;
                timer5.Enabled = false;
                timer4.Enabled = false;

                radioButton1.Enabled = false;
                radioButton3.Enabled = false;
                button3.Enabled = false;
            }
        }
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (pb4 >= 50 && xpb4 > 640 && ypb4 >= 135)
            {
                xpb7 = xpb7 + 6;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb7 <= 294)
            {
                xpb7 = xpb7 + 4;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb7 <= 428)
            {
                xpb7 = xpb7 + 2;
                pictureBox7.Location = new Point(xpb7, ypb7);
            }
            if (pb4 >= 50 && ypb8 <= 135 && xpb7 >= 428 && ypb7<=182)
            {
                xpb7 = xpb16;
                ypb7 = ypb16;
                pictureBox7.Visible = false;
                pictureBox16.Visible = true;
                ypb16 = ypb16 + 1;
                pictureBox16.Location = new Point(xpb16, ypb16);
                if (timer4.Enabled == false)
                {
                    timer4.Enabled = true;
                }
                if (timer4.Enabled == true)
                {
                    radioButton3.Enabled = false;
                }
                radioButton1.Enabled = false;
                button3.Enabled = false;
            }
            if (pb4 >= 50 && ypb8 <= 135 && ypb16 >= 182 && xpb16>=392)
            {
                xpb16 = xpb17;
                ypb16 = ypb17;
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
                xpb17 = xpb17 - 2;
                pictureBox17.Location = new Point(xpb17, ypb17);
            }
            if (pb4 >= 50 && ypb8 <= 135 && ypb17 >= 214 && xpb17 <= 392)
            {
                xpb17 = xpb18;
                ypb17 = ypb18;
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
                ypb18 = ypb18 + 2;
                pictureBox18.Location = new Point(xpb18, ypb18);
            }
        }
        #endregion



        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            if (pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                timer1.Start();
                timer2.Start();
            }
            if (pictureBox7.Visible == true && pictureBox4.Visible == true)
            {
                timer4.Start();
                timer5.Start();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           

            if (pb5 >= 50 && xpb6 <= 724)
            {


                if (radioButton2.Checked == true)
                {
                    timer2.Stop();
                    timer3.Start();
           

                }

               
                else if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    timer1.Start();
                    timer2.Start();
                }
            }


    

            if (pb4>=50 && xpb7 >= -60)
                {
                     if (radioButton1.Checked == true)
                     {
                        timer5.Stop();
                        timer6.Start();
                       

                     }
                   
                    else if (radioButton1.Checked == false && radioButton3.Checked == false)
                    {
                        timer4.Start();
                        timer5.Start();
                    }
                }
 
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 50, 50));
            comboBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox1.Width, comboBox1.Height, 10, 10));
            comboBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, comboBox2.Width, comboBox2.Height, 10, 10));

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(130, 119, 109, 210);
        }
    }
}
