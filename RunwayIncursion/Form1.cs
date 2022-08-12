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
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region ButtonForma
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width, button2.Height, 40, 40));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width, button3.Height, 40, 40));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width, button4.Height, 40, 40));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button5.Width, button5.Height, 40, 40));


        }


        #endregion

        #region Formun_Hereketi_1
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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e) //toqqusma
        {
            if (radioButton1.Checked==true) //UEZ 16-34
            {
                Form2 f2 = new Form2();
                f2.Show();
                f2.pictureBox7.Visible = true;
                f2.pictureBox8.Visible = false;
                f2.button3.Visible = true;
                f2.button4.Visible = false;

            }
            else if (radioButton2.Checked == true) //UEZ 17-35
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.pictureBox12.Visible = true;
                f3.pictureBox13.Visible = false;
                f3.button2.Visible = true;
                f3.button3.Visible = false;
                f3.pictureBox2.Visible = true;
                f3.pictureBox7.Visible = false;
            }

           else if(radioButton1.Checked==false || radioButton2.Checked == false)
           {
                MessageBox.Show("Zəhmət olmasa  hansı uçuş-enmə zolağındakı prosesi izləmək istədiyinizi seçin!", "Bildiriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
           }


        }

        private void button3_Click(object sender, EventArgs e) //qarsisini almaq
        {
            if (radioButton1.Checked == true) //UEZ 16-34
            {
                Form2 f2 = new Form2();
                f2.Show();
                f2.pictureBox3.Visible = true;
                f2.pictureBox8.Visible = true;
                f2.pictureBox7.Visible = false;
                f2.button3.Visible = false;
                f2.button4.Visible = true;

            }
            else if (radioButton2.Checked == true) //UEZ 17-35
            {
                Form3 f3 = new Form3();
                f3.Show();
                f3.pictureBox12.Visible = false;
                f3.pictureBox13.Visible = true;
                f3.button2.Visible = false;
                f3.button3.Visible = true;
                f3.pictureBox2.Visible = false;
                f3.pictureBox7.Visible = true;
            }
            else if (radioButton1.Checked == false || radioButton2.Checked == false)
            {
                MessageBox.Show("Zəhmət olmasa prosesi hansı uçuş-enmə zolağında izləmək istədiyinizi seçin!", "Bildiriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Form4 f4 = new Form4();
                f4.Show();                
            }
            else if (radioButton2.Checked == true)
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
            else if (radioButton1.Checked == false || radioButton2.Checked == false)
            {
                MessageBox.Show("Zəhmət olmasa prosesi hansı uçuş-enmə zolağında izləmək istədiyinizi seçin!", "Bildiriş", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }
    }
}
