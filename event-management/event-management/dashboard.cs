using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_management
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dashboard = new user();
            dashboard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dashboard = new dashboard();
            dashboard.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            var dashboard = new user();
            dashboard.Show();
        }

        private void btnevents_Click(object sender, EventArgs e)
        {
            
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
