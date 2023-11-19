using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace event_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


          

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            btnstart.Hide();
            progressBar1.Show();
            var form1 = new login();
            form1.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(5);
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
