using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_management
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();

            dgvform.ColumnCount = 10;
            dgvform.Columns[0].Name = "First Name";
            dgvform.Columns[1].Name = "Last Name";
            dgvform.Columns[2].Name = "Birthdate";
            dgvform.Columns[3].Name = "Gender";
            dgvform.Columns[4].Name = "Phone";
            dgvform.Columns[5].Name = "Department";
            dgvform.Columns[6].Name = "Course";
            dgvform.Columns[7].Name = "Year";
            dgvform.Columns[8].Name = "Kind of Events";
            dgvform.Columns[9].Name = "Place";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new dashboard();
            user.Show();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            var user = new dashboard();
            user.Show();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {

        }

        private void btnevents_Click(object sender, EventArgs e)
        {
            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();

            dgvform.Rows.Add(txtFname.Text,
                txtLname.Text,
                dtpick.Value,
                DEPAR.SelectedItem,
                kurso.SelectedItem,
                year.SelectedItem,
                txtevent.Text,
                place11.SelectedItem);





        }

        private void dgvform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
