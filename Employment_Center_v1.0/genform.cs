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
    public partial class genform : Form
    {
        public genform()
        {
            InitializeComponent();
        }

        private void genform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.gentable". При необходимости она может быть перемещена или удалена.
            this.gentableTableAdapter.Fill(this.databaseDataSet.gentable);

        }

        private void exitappbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addvacbtn_Click(object sender, EventArgs e)
        {
            addvacantion addvacantion = new addvacantion();
            addvacantion.Show();
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();

        }
    }
}
