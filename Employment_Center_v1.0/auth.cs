using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employment_Center_v1._0
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void regbtn_Click(object sender, EventArgs e)
        {

            regform regform = new regform();
            regform.Show();
            Hide();
        }

        private void authbtn_Click(object sender, EventArgs e)
        {
            genform genform = new genform();
            genform.Show();
            Hide();
        }
    }
}
