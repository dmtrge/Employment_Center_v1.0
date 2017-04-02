using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Employment_Center_v1._0
{
    public partial class regform : Form
    {
        public regform()
        {
            InitializeComponent();
        }

        private void addregbtn_Click(object sender, EventArgs e)
        {
           var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\projects\Employment_Center_v1.0\Database.mdf;Integrated Security=True;Connect Timeout=30";
            using (var myConnection = new SqlConnection(сonnectionString))
            {

                myConnection.Open();
                var sqlCommand = new SqlCommand("INSERT INTO users (login, passwd, ФИО, company) VALUES(@login, @passwd, @ФИО, @company)", myConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@login",addloginbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@passwd",addpasswdbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@ФИО", addfiobox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@company",addcompanybox.Text ));

                try
                {

                    sqlCommand.ExecuteNonQuery();
                }
                finally
                {
                    myConnection.Close();
                }
            } 
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
