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
    public partial class addvacantion : Form
    {
        public addvacantion()
        {
            InitializeComponent();
        }

        private void addregbtn_Click(object sender, EventArgs e)
        {
            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\projects\Employment_Center\Employment_Center\Database.mdf;Integrated Security=True";
            using (var myConnection = new SqlConnection(сonnectionString))
            {

                myConnection.Open();
                var sqlCommand = new SqlCommand("INSERT INTO gentable (Отрасль, Специальность, Требования,Опыт_работы, ЗП, График_работы,Местоположение,Обратная_связь) VALUES(@Отрасль, @Специальность, @Требования, @Опыт_работы, @ЗП, @График_работы,@Местоположение, @Обратная_связь)", myConnection);

                sqlCommand.Parameters.Add(new SqlParameter("@Отрасль", addjobbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@Специальность", addspecialitybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@Требования", addreqbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@Опыт_работы", addexpbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@ЗП", addsallarybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@Местоположение", addlocationbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@График_работы", addgraphbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@Обратная_связь", addaboutbox.Text));

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