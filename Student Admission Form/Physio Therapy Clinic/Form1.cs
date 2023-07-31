using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physio_Therapy_Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblH.Text = "Student Registration Form";
            userControl11.Visible= true;
            if (btregistration.Focused == true)
            {
                btregistration.BackColor = Color.Teal;
                bthome.BackColor = panel1.BackColor;
                panel2.BackColor = Color.Teal;
                btinformation.BackColor = panel1.BackColor;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblH.Text = "Student Information Form";
            userControl11.Visible = false;
            frminfo1.Visible= true;
            panel2.BackColor = Color.Brown;
            btinformation.BackColor= Color.Brown;
            btregistration.BackColor= panel1.BackColor; 
            userControl11.Visible= false;
            bthome.BackColor= panel1.BackColor;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lblH.Text = "Student Addmission Form";
            userControl11.Visible= false;
            if (bthome.Focused == true) 
            {
                bthome.BackColor = Color.Navy;
                btregistration.BackColor = panel1.BackColor;
                panel2.BackColor = panel1.BackColor;
                btinformation.BackColor= panel1.BackColor; 
                userControl11.Visible= false;
                frminfo1.Visible= false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bthome.BackColor = Color.Navy;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible= true;
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible= true;
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void frminfo1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
